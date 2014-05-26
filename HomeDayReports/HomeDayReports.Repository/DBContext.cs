using System.Data.Entity;
using HomeDayReports.Model;

namespace HomeDayReports.Repository
{
    public class DBContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<BusinesIdea> BusinesIdeas { get; set; }
        public DbSet<DoneTask> DoneTasks { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DayReport> DayReports { get; set; }
    }
}
