using School.Core.Features.Student.Queries.Results;
using School.Domain.Entities;
using AutoMapper;

namespace School.Core.Mapping.Student
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        { 
            CreateMap<TbStudent, GetStudentListDto>()
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name));
        }
    }
}
