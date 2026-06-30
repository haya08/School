using AutoMapper;

namespace School.Core.Mapping.Student
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetStudentQueryMapping();
            AddStudentCommandMapping();
            EditStudentCommandMapping();
        }
    }
}
