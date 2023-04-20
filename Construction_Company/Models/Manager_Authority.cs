namespace Construction_Company.Models
{
    public class Manager_Authority
    {
        public int Manager_Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public ICollection<Project> projects{ get; set; }
        public ICollection<Approval> approvals { get; set; }
    }
}
