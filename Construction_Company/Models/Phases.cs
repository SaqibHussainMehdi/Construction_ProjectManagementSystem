using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class Phases
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public  int RatePerUnit { get; set; }
    }
}
