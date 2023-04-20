namespace Construction_Company.Models
{
    public class Approval
    {
        public int Approval_Id { get; set; }
        public string Approved_by { get; set; }
        public DateTime date_approved { get; set; }
        public int Project_Id { get; set; }
        public Project project { get; set; }
        public int Manager_Id { get; set; }
        public Manager_Authority Manager_Authority { get; set; }
    }
}
