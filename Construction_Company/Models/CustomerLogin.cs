using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class CustomerLogin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]    
        public string UserName { get; set; }
        [Required]
        [MaxLength(100)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [MaxLength(100)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        public ICollection<Inquirey> inquireys { get; set; }
        public ICollection<Receipt> receipts { get; set; }
        public ICollection<ProjectAssignment> projectAssignments { get; set; }


    }
}
