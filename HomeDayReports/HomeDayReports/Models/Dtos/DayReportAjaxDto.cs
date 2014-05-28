using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeDayReports.Model;

namespace HomeDayReports.Models.Dtos
{
    public class DayReportAjaxDto
    {
        public DayReport DayReport { get; set; }
        public int BusinesIdeasCount { get; set; }
        public int DoneTasksCount { get; set; }
        public int EventsCount { get; set; }
        public int ExpensesCount { get; set; }
        public int IdeasCount { get; set; }
    }
}