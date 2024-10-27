using Expense_Tracker.CalendarEvents.Models;

namespace Expense_Tracker.CalendarEvents.Data
{
    public interface ICalendarBooking
    {
        Task<List<CalendarContent>> GettAllBooking();
        Task<bool> RemoveBooking(int bookingId);
        Task<CalendarContent> SaveBooking(CalendarContent booking);
    }
}