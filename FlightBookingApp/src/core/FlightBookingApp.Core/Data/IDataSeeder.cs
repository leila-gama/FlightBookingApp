﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingApp.Core.Data
{
    public interface IDataSeeder
    {
        Task SeedAllAsync();
    }
}
