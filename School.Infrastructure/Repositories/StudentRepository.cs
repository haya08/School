using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using School.Infrastructure.Abstracts;
using School.Infrastructure.Bases;
using School.Infrastructure.Context;

namespace School.Infrastructure.Repositories
{
    public class StudentRepository : GenericRepository<TbStudent>, IStudentRepository
    {
        #region Fields
        private readonly DbSet<TbStudent> _dbSet;
        #endregion

        #region Constructors
        public StudentRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            _dbSet = dbContext.Set<TbStudent>();
        }
        #endregion

        #region Functions
        public async Task<List<TbStudent>> GetStudentListAsync()
        {
            return await _dbSet.Include(s => s.Department).ToListAsync();
        }
        #endregion
    }
}
