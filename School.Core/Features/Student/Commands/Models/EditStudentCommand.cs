using MediatR;
using School.Core.Bases;

namespace School.Core.Features.Student.Commands.Models
{
    public class EditStudentCommand : IRequest<Response<string>>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public Guid? DepartmentId { get; set; }
    }
}
