using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Pages.Booking
{
    public class ProductModel : PageModel
    {
        private readonly CarBooking.Data.CarBookingContext _context;

        public ProductModel(CarBooking.Data.CarBookingContext context)
        {
            _context = context;
        }

        public IList<BookingCars> BookingCars { get; set; }

        public async Task OnGetAsync()
        {
            BookingCars = await _context.BookingCars.ToListAsync();
        }
    }
}
