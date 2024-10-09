using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ExpensesDB : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public ExpensesDB(DbContextOptions<ExpensesDB> options)
            : base(options)
        {

        }
    }
}
