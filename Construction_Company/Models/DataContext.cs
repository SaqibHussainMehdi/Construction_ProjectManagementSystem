using Microsoft.EntityFrameworkCore;

namespace Construction_Company.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<CustomerLogin> customerLogins { get; set; }
        public DbSet<Inquirey> inquireys { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Phase> phases { get; set; }
        public DbSet<ProjectAssignment> ProjectAssignments { get; set; }
        public DbSet<ProjectStatus> projectStatuses { get; set; }
        public DbSet<Receipt> receipts { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserType> userTypes { get; set; }
    }
}
