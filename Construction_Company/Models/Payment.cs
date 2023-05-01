using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string PaymentStatus { get; set; }
        public int Paid { get; set; }
    }
}
