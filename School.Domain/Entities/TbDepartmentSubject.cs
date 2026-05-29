using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain.Entities
{
    public class TbDepartmentSubject
    {
        [Key]
        public Guid Id { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid SubjectId { get; set; }

        [ForeignKey("DepartmentId")]
        public TbDepartment Department { get; set; }
        [ForeignKey("SubjectId")]
        public TbSubject Subject { get; set; }
    }
}
