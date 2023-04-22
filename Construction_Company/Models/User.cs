using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public UserType userType { get; set; }
    }
}
