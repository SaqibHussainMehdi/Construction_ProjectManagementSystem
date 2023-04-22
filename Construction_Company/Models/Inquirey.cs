using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class Inquirey
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public int Area { get; set; }
        [Required]
        [MaxLength(100)]
        public int   RatePerSqFt { get; set; }
        [Required]
        public bool HomeDrawing { get; set; }
        [Required]
        [MaxLength(100)]
        public int HomeDrawingPerSqFt { get; set; }
        [Required]
        public bool GreyStructure { get; set; }
        [Required]
        [MaxLength(100)]
        public int GreyStructurePerSqFt { get; set; }
        [Required]
        public bool Finishing { get; set; }
        [Required]
        [MaxLength(100)]
        public int FinishingPerSqF { get; set; }
        public Phase phase { get; set; }
        public CustomerLogin customerLogin { get; set; }
    }
}
