using School.Domain.Entities;

namespace School.Service.Abstracts
{
    public interface IStudentService
    {
        Task<List<TbStudent>> GetStudentListAsync();
        Task<TbStudent> GetStudentByIdAsync(Guid id);
        Task<TbStudent> GetStudentByEmail(string email);
        Task<string> AddAsync(TbStudent student);
        Task<bool> IsEmailExists(string email);
        Task<string> UpdateAsync(TbStudent student);
    }
}
