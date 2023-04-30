using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class SignUp
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
       

        public ICollection<UserType> userTypes { get; set; }
    }
}
