using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class UserType
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string TypeDesc { get; set; }
        public ICollection<User> users { get; set; }
    }
}
