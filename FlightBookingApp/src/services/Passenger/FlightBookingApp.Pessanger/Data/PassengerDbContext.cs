﻿using Microsoft.EntityFrameworkCore;

namespace FlightBookingApp.Passenger.Data
{
    public class PassengerDbContext : DbContext
    {
        public PassengerDbContext(DbContextOptions<PassengerDbContext> options) : base(options)
        {
        }

        public DbSet<Passengers.Models.Passenger> Passengers => Set<Passengers.Models.Passenger>();
    }
}
