using FlightBookingApp.Flight.Domain.Aircrafts.Models;
using FlightBookingApp.Flight.Domain.Airports;
using FlightBookingApp.Flight.Domain.Seats;
using FlightBookingApp.Flight.Domain.Flights;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FlightBookingApp.Flight.Infra.Context
{
    public class FlightDbContext : DbContext
    {
        public FlightDbContext(DbContextOptions<FlightDbContext> options) : base(
             options)
        {
        }

        public DbSet<Domain.Flights.Flight> Flights => Set<Domain.Flights.Flight>();
        public DbSet<Airport> Airports => Set<Airport>();
        public DbSet<Aircraft> Aircraft => Set<Aircraft>();
        public DbSet<Seat> Seats => Set<Seat>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

    }
}
