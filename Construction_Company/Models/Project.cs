namespace Construction_Company.Models
{
    public class Project
    {
        public int Project_Id  { get; set; }
        public string? Name { get; set; }
        public int Customer_Id { get; set; }
        public Customer? customer { get; set; }
        public int Manager_Id { get; set; }
        public Manager_Authority manager_Authority { get; set; }
        public ICollection<Task> tasks { get; set; }
        public ICollection<Quote> quotes { get; set; }
        public ICollection<Approval> approvals { get; set; }
        public ICollection<Payment> payments { get; set; }
    }
}
