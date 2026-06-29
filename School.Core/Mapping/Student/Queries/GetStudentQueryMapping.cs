using School.Core.Features.Student.Queries.Results;
using School.Domain.Entities;

namespace School.Core.Mapping.Student
{
    public partial class StudentProfile
    {
        public void GetStudentQueryMapping()
        {
            CreateMap<TbStudent, GetStudentDto>()
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name));
        }
    }
}
