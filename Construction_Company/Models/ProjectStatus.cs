using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class ProjectStatus
    {
        [Key]
        public int Id { get; set; }
        public string CompletionStatus { get; set; }
    }
}
