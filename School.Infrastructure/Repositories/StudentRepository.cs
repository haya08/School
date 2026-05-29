using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using School.Infrastructure.Abstracts;
using School.Infrastructure.Context;

namespace School.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        #region Fields
        private readonly ApplicationDBContext _dbContext;
        #endregion

        #region Constructors
        public StudentRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Functions
        public async Task<List<TbStudent>> GetStudentListAsync()
        {
            return await _dbContext.students.ToListAsync();
        }
        #endregion
    }
}
