namespace Construction_Company.Models
{
    public class Stage
    {
        public int Stage_Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int Task_Id { get; set; }
        public Task task { get; set; }
        public ICollection<Cost> costs { get; set; }
    }
}
