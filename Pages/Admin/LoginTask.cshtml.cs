using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarBooking.Data;
using CarBooking.Models;
namespace CarBooking.Pages.Admin
{
    public class LoginTaskModel : PageModel
    {
        private readonly CarBooking.Data.CarBookingContext _context;

        public LoginTaskModel(CarBooking.Data.CarBookingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Login Login { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Login.Add(Login);

            if (Login.Email.Equals("Admin@gmail.com") && Login.Password.Equals("12345"))
            {
                return RedirectToPage("./Dashboard");
            }
            else {
                return RedirectToPage("./invalid");
            }

            

            
        }

    }
}
