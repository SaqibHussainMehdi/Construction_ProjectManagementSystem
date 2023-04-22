using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class Phase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string PhaseDesc { get; set; }
        [Required]
        [MaxLength(100)]
        public string RatePerUnit { get; set; }
        public ICollection<Inquirey> inquireys { get; set; }
    }
}
