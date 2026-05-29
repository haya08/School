using System.ComponentModel.DataAnnotations;

namespace School.Domain.Entities
{
    public class TbDepartment
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public ICollection<TbStudent> Students { get; set; }
    }
}
