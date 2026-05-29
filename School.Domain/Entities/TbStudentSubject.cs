using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain.Entities
{
    public class TbStudentSubject
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }

        [ForeignKey("StudentId")]
        public TbStudent Student { get; set; }
        [ForeignKey("SubjectId")]
        public TbSubject Subject { get; set; }
    }
}
