using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain.Entities
{
    public class TbStudent
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(100)]
        [Phone]
        public string PhoneNumber { get; set; }
        public Guid DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public TbDepartment Department { get; set; }
    }
}
