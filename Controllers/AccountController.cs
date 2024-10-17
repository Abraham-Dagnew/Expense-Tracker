using Expense_Tracker.Models;
using Expense_Tracker.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<Users> signInManager;
        private readonly UserManager<Users> userManager;
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register (RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                Users users = new Users
                {
                    FullName = model.Name,
                    Email = model.Email,
                    UserName = model.Email,
                };
                var result = await
            }
            }
        public IActionResult VerifyEmail()
        {
            return View();
        }
        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}