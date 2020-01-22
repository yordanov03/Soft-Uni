using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Models;

namespace BusTicketsSystem.Services.Interfaces
{
    public interface ITripService
    {
        Trip GetTripById(int tripId);
    }
}
