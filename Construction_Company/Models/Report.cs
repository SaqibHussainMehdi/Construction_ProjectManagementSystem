namespace Construction_Company.Models
{
    public class Report
    {
        public int Report_Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime date_created { get; set; }
        public int Task_Id { get; set; }
        public Task task { get; set; }

    }
}
