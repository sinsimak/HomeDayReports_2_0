﻿namespace HomeDayReports.Model
{
    public class Idea
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DayReport DayReport { get; set; }
        public int DayReportId { get; set; }
    }
}
