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
            // check for duplicate email
            var result = await _studentRepository.GetTableNoTracking().Where(s=>s.Email == student.Email).FirstOrDefaultAsync();
            if (result != null)
                return "Student already exists";

            await _studentRepository.AddAsync(student);
            await _studentRepository.SaveChangesAsync();
            return "Added successfully!";
        }
        public async Task<TbStudent> GetStudentByIdAsync(Guid id)
        {
            //return await _studentRepository.GetByIdAsync(id);
            return await _studentRepository.GetTableNoTracking()
                                           .Include(s => s.Department)
                                           .Where(s => s.Id.Equals(id))
                                           .FirstOrDefaultAsync();
        }

        public async Task<List<TbStudent>> GetStudentListAsync()
        {
            return await _studentRepository.GetStudentListAsync();
        }
        #endregion
    }
}
