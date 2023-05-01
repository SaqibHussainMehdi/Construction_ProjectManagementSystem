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
        public DbSet<Inquiry> inquiries { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Phase> phases { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<ProjectStatus> projectStatuses { get; set; }
        public DbSet<Receipt> receipts { get; set; }

        public DbSet<Manager> managers { get; set; }    
        public DbSet<SignUp> signUps { get; set; }
        public DbSet<UserType> userTypes { get; set; }
    }
}
