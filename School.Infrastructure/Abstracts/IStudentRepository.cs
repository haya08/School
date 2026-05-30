using School.Domain.Entities;
using School.Infrastructure.Bases;

namespace School.Infrastructure.Abstracts
{
    public interface IStudentRepository : IGenericRepository<TbStudent>
    {
        Task<List<TbStudent>> GetStudentListAsync();
    }
}
