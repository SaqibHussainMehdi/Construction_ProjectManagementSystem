using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class ProjectStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public int CompPercent { get; set; }
        public ProjectAssignment projectAssignment { get; set; }
    }
}
