using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using School.Infrastructure.Abstracts;
using School.Service.Abstracts;

namespace School.Service.Implementations
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IStudentRepository _studentRepository;
        #endregion

        #region Constructors
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        #endregion

        #region Functions
        public async Task<string> AddAsync(TbStudent student)
        {
            //check on duplicate emails
            var isDuplicate = await IsEmailExists(student.Email);
            if (isDuplicate)
                return "Student already exists";

            await _studentRepository.AddAsync(student);
            await _studentRepository.SaveChangesAsync();
            return "Added successfully!";
        }

        public async Task<string> UpdateAsync(TbStudent student)
        {
            await _studentRepository.UpdateAsync(student);
            await _studentRepository.SaveChangesAsync();
            return "Updated successfully!";
        }

        public async Task<TbStudent> GetStudentByIdAsync(Guid id)
        {
            //return await _studentRepository.GetByIdAsync(id);
            return await _studentRepository.GetTableNoTracking()
                                           .Include(s => s.Department)
                                           .Where(s => s.Id.Equals(id))
                                           .FirstOrDefaultAsync();
        }

        public async Task<TbStudent> GetStudentByEmail(string email)
        {
            return await _studentRepository.GetTableNoTracking()
                                           .Include(s => s.Department)
                                           .Where(s => s.Email == email)
                                           .FirstOrDefaultAsync();
        }

        public async Task<List<TbStudent>> GetStudentListAsync()
        {
            return await _studentRepository.GetStudentListAsync();
        }
        #endregion

        #region Helper functions
        public async Task<bool> IsEmailExists(string email)
        {
            var result = await _studentRepository.GetTableNoTracking().Where(s => s.Email == email).FirstOrDefaultAsync();
            return result != null;
        }
        #endregion
    }
}
