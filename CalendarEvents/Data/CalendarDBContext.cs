using Microsoft.EntityFrameworkCore;
using Expense_Tracker.CalendarEvents.Models;

namespace Expense_Tracker.CalendarEvents.Data

{
    public class CalendarDBContext : DbContext 
    {
        public CalendarDBContext(DbContextOptions<CalendarDBContext> options): base(options)  { }

        public virtual DbSet<CalendarContent> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
