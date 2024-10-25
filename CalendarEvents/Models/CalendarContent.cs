namespace Expense_Tracker.CalendarEvents.Models
{
    public class CalendarContent
    {
        public int BookingId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }

        public string ThemeColor { get; set; }

        public bool Fullday { get; set; }

    }
}
