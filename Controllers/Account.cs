using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class Account : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
