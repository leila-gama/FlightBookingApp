using FlightBookingApp.Core.ModelsAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingApp.Booking.Domain.Models.ValueObjects
{
    public record Trip(string FlightNumber, long AircraftId, long DepartureAirportId, long ArriveAirportId,
       DateTime FlightDate, decimal Price, string Description, string SeatNumber);
}
