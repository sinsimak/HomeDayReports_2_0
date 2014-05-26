namespace HomeDayReports.Model
{
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Summ { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public DayReport DayReport { get; set; }
        public int DayReportId { get; set; }
    }
}
