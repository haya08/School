using School.Core.Features.Student.Queries.Results;
using School.Domain.Entities;
using AutoMapper;

namespace School.Core.Mapping.Student
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetStudentQueryMapping();
            AddStudentCommandMapping();
        }
    }
}
