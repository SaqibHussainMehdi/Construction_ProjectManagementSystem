namespace Construction_Company.Models
{
    public class Cost
    {
        public int Cost_Id { get; set; }
        public int labor_cost { get; set; }
        public int material_cost { get; set; }
        public int Stage_Id { get; set; }
        public Stage stage { get; set; }
    }
}
