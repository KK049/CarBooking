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
    public class IndexModel : PageModel
    {
        private readonly CarBooking.Data.CarBookingContext _context;

        public IndexModel(CarBooking.Data.CarBookingContext context)
        {
            _context = context;
        }

        public IList<BookingCars> BookingCars { get;set; }

        public async Task OnGetAsync()
        {
            BookingCars = await _context.BookingCars.ToListAsync();
        }
    }
}
