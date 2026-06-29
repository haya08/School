using School.Domain.Entities;

namespace School.Service.Abstracts
{
    public interface IStudentService
    {
        Task<List<TbStudent>> GetStudentListAsync();
        Task<TbStudent> GetStudentByIdAsync(Guid id);
        Task<string> AddAsync(TbStudent student);
    }
}
