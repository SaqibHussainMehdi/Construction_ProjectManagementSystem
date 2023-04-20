namespace Construction_Company.Models
{
    public class Quote
    {
        public int Quote_Id { get; set; }
        public DateTime date { get; set; }
        public int estimated_cost { get; set; }
        public int Customer_Id { get; set; }
        public Customer customer { get; set; }
        public int Project_Id { get; set; }
        public Project project { get; set; }

    }
}
