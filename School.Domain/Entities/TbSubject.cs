using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain.Entities
{
    public class TbSubject
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Period { get; set; }

        public ICollection<TbStudentSubject> StudentSubjects { get; set; }
        public ICollection<TbDepartmentSubject> DepartmentSubjects { get; set; }
    }
}
