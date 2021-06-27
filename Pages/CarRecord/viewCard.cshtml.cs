using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Pages.CarRecord
{
    public class viewCardModel : PageModel
    {
        private readonly CarBooking.Data.CarBookingContext _context;

        public viewCardModel(CarBooking.Data.CarBookingContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get; set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }

    }
}
