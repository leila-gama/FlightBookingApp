using FlightBookingApp.Core.Data;
using FlightBookingApp.Core.ModelsAggregate;
using FlightBookingApp.Core.ModelsAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingApp.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregate
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
