using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class Inquiry
    {
        [Key]
        public int Id { get; set; }
        public int Area { get; set; }
        public int RatePerSqFt { get; set; }
        public bool HomeDrawing { get; set; }
        public int HomeDrawingPerSqFt { get; set; }
        public bool GreyStructure { get; set; }
        public int GreyStructurePerSqFt { get; set; }
        public bool Finishing { get; set; }
        public int FinishingPerSqFt { get; set; }

    }
}
