using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class Phase
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public  int RatePerUnit { get; set; }
    }
}
