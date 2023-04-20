namespace Construction_Company.Models
{
    public class Engineer_Supervisor
    {
        public int Engineer_Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
