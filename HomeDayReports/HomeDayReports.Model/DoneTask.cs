namespace HomeDayReports.Model
{
    public class DoneTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Analysis { get; set; }
        public DayReport DayReport { get; set; }
        public int DayReportId { get; set; }
    }
}
