using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class Receipt
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public string ReceiptDescription { get; set; }
    }
}
