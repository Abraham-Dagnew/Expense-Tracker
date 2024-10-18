using Expense_Tracker.DB;
using Expense_Tracker.Models;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker
{
    public class Program
    {
        public static void Main(string[] args)
            {
                var builder = WebApplication.CreateBuilder(args);

                // Add services to the container.
                builder.Services.AddControllersWithViews();
                builder.Services.AddDbContext<ExpensesDB>(options =>
                    options.UseInMemoryDatabase("ExpensesDB")
                );

                builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

                builder.Services.AddIdentity<Users, IdentityRole>(options =>
                {
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequiredLength = 8;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                    options.User.RequireUniqueEmail = true;
                    options.SignIn.RequireConfirmedAccount = false;
                    options.SignIn.RequireConfirmedEmail = false;
                    options.SignIn.RequireConfirmedPhoneNumber = false;
                })
                    .AddEntityFrameworkStores<AppDbContext>()
                    .AddDefaultTokenProviders();


                var app = builder.Build();

                if (!app.Environment.IsDevelopment())
                {
                    app.UseExceptionHandler("/Home/Error");
                    app.UseHsts();
                }

                app.UseHttpsRedirection();
                app.UseStaticFiles();

                app.UseRouting();

                app.UseAuthorization();

            app.MapControllerRoute(
                name: "login",
                pattern: "{controller=Account}/{action=Login}/{id?}"); 

            app.MapControllerRoute(
                name: "home",
                pattern: "{controller=Home}/{action=Index}/{id?}"); 


            app.Run();
            }

            private static void AddEntityFrameworkstores<T>(WebApplicationBuilder builder)
            {
                throw new NotImplementedException();
            }
        }
    }
