using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class Manager
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
