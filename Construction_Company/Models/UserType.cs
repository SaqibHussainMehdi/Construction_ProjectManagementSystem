using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class UserType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string TypeDescription { get; set; }
        public SignUp signUp { get; set; }
    }
}
