using School.Core.Features.Student.Commands.Models;
using School.Core.Features.Student.Queries.Results;
using School.Domain.Entities;

namespace School.Core.Mapping.Student
{
    public partial class StudentProfile
    {
        public void AddStudentCommandMapping()
        {
            CreateMap<AddStudentCommand, TbStudent>();
        }
    }
}
