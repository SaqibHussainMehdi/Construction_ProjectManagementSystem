using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class ProjectAssignment
    {
        [Key]
        public int Id { get; set; }
        public DateTime TargetDate { get; set; }
        public CustomerLogin customerLogin { get; set; }
        public ICollection<Receipt> receipts { get; set; }
        public ICollection<ProjectStatus> projectStatuses { get; set; }
        public ICollection<Payment> payments { get; set; }
    }
}
