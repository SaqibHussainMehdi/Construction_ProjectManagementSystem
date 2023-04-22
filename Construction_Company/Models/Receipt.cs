using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class Receipt
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(100)]
        public string ReceiptDescr { get; set; }
        public int RecoverAmount { get; set; }
        public CustomerLogin customerLogin { get; set; }
        //public ProjectAssignment projectAssignment { get; set; }
    }
}
