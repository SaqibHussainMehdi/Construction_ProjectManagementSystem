using Microsoft.EntityFrameworkCore;

namespace Construction_Company.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Engineer_Supervisor> engineer_Supervisors { get; set; }
        public DbSet<Customer> customers { get; set; }

        public DbSet<Manager> managers { get; set; }    
        public DbSet<SignUp> signUps { get; set; }
        public DbSet<UserType> userTypes { get; set; }
    }
}
