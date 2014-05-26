using System;
using System.Collections.Generic;

namespace HomeDayReports.Model
{
    public class DayReport
    {
        public int Id { get; set; }
        public DateTime ReportDate { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Idea> Ideas { get; set; }
        public virtual ICollection<BusinesIdea> BusinesIdeas { get; set; }
        public virtual ICollection<DoneTask> DoneTasks { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
