namespace Construction_Company.Models
{
    public class Task
    {
        public int Task_Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int Project_Id { get; set; }

        public Project project { get; set; }

        public int Engineer_Id { get; set; }

        public Engineer_Supervisor Engineer_Supervisor { get; set; }

        public ICollection<Stage> stages { get; set; }
        public ICollection<Report> reports { get; set; }
    }
}
