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
