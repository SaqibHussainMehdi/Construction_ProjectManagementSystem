using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }   
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

    }
}
