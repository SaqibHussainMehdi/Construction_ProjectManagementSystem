using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }    
        public DateTime TargetDate { get; set; }
    }
}
