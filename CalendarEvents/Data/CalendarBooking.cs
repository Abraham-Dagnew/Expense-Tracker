using Microsoft.EntityFrameworkCore;
using Expense_Tracker.CalendarEvents.Models;
namespace Expense_Tracker.CalendarEvents.Data
{
    public class CalendarBooking : ICalendarBooking
    {


        private CalendarDBContext _db;
        public CalendarBooking(CalendarDBContext db)
        {
            _db = db;
        }
        public async Task<List<CalendarContent>> GettAllBooking()
        {
            return await _db.Bookings.ToListAsync();
        }
        public async Task<CalendarContent> SaveBooking(CalendarContent booking)
        {
            if (booking.BookingId > 0)
            {
                //Update the booking
                var v = _db.Bookings.Where(a => a.BookingId == booking.BookingId).FirstOrDefault();
                if (v != null)
                {
                    v.Subject = booking.Subject;
                    v.Start = booking.Start;
                    v.End = booking.End;
                    v.Description = booking.Description;
                    v.Fullday = booking.Fullday;
                    v.ThemeColor = booking.ThemeColor;
                }

                else
                    _db.Bookings.Add(booking);


            }
            await _db.SaveChangesAsync();

            return booking;
        }

        public async Task<bool> RemoveBooking(int bookingId)
        {
            var booking = _db.Bookings.Where(a => a.BookingId == bookingId).FirstOrDefault();
            if (booking != null)
            {
                _db.Bookings.Remove(booking);
                await _db.SaveChangesAsync();
            }

            return true;
        }
    }
}



