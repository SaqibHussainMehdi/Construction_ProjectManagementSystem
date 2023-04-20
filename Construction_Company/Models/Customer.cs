namespace Construction_Company.Models
{
    public class Customer
    {
        public int Customer_Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public ICollection<Project> projects { get; set; }
        public ICollection<Quote> Quotes { get; set; }
    }
}
