using School.Domain.Entities;

namespace School.Infrastructure.Abstracts
{
    public interface IStudentRepository
    {
        Task<List<TbStudent>> GetStudentListAsync();
    }
}
