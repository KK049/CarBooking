using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarBooking.Data;
using CarBooking.Models;

namespace CarBooking.Pages.QueryRecord
{
    public class CreateModel : PageModel
    {
        private readonly CarBooking.Data.CarBookingContext _context;

        public CreateModel(CarBooking.Data.CarBookingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Query Query { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Query.Add(Query);
            await _context.SaveChangesAsync();

            return Page();
        }
    }
}
