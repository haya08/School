using School.Core.Features.Student.Commands.Models;
using School.Domain.Entities;

namespace School.Core.Mapping.Student
{
    public partial class StudentProfile
    {
        public void EditStudentCommandMapping()
        {
            CreateMap<EditStudentCommand, TbStudent>();
        }
    }
}
