using System.Collections.Generic;

namespace HomeDayReports.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
