using Microsoft.AspNetCore.Identity;

namespace Expense_Tracker.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
