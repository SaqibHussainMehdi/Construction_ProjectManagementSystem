namespace Construction_Company.Models
{
    public class Payment
    {
        public int Payment_Id { get; set; }
        public string amount { get; set; }
        public DateTime Date { get; set; }
        public int Project_Id { get; set; }
        public Project project { get; set; }
    }
}
