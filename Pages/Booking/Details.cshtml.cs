using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarBooking.Data;
using CarBooking.Models;

namespace CarBooking.Pages.Booking
{
    public class DetailsModel : PageModel
    {
        private readonly CarBooking.Data.CarBookingContext _context;

        public DetailsModel(CarBooking.Data.CarBookingContext context)
        {
            _context = context;
        }

        public BookingCars BookingCars { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookingCars = await _context.BookingCars.FirstOrDefaultAsync(m => m.id == id);

            if (BookingCars == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
