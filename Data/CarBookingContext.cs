using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarBooking.Models;

namespace CarBooking.Data
{
    public class CarBookingContext : DbContext
    {
        public CarBookingContext (DbContextOptions<CarBookingContext> options)
            : base(options)
        {
        }

        public DbSet<CarBooking.Models.Car> Car { get; set; }

        public DbSet<CarBooking.Models.BookingCars> BookingCars { get; set; }

        public DbSet<CarBooking.Models.Query> Query { get; set; }

        public DbSet<CarBooking.Models.Login> Login { get; set; }

        
    }
}
