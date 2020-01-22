using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Client.Core.Commands.Contracts;
using BusTicketsSystem.Models;
using BusTicketsSystem.Services.Interfaces;

namespace BusTicketsSystem.Client.Core.Commands
{
    public class PrintInfoCommand : ICommand
    {
        private readonly IBusStationService busStationService;
        private readonly ITripService tripService;

        public PrintInfoCommand(IBusStationService busStationService, ITripService tripService)
        {
            this.busStationService = busStationService;
            this.tripService = tripService;
        }

        public string Execute(params string[] data)
        {
            var busStation = busStationService.GetBusStationById(int.Parse(data[0]));
            var sb = new StringBuilder();
            sb.Append($"{busStation.BusStationName}, {busStation.Town.TownName}");
            sb.AppendLine("Arrivals:");

            foreach (var arrival in busStation.ArrivalTrips)
            {
                int tripId = arrival.TripId;
                Trip trip = tripService.GetTripById(tripId);
                sb.AppendLine($"From: {trip.OriginBusStation.BusStationName} | Arrive at {trip.ArrivalTime.ToString("dd-MM-yyyy")} | Status: {trip.Status}");
            }

            sb.AppendLine("Departures:");

            foreach (var departure in busStation.DepartureTrips)
            {
                int tripId = departure.TripId;
                Trip trip = tripService.GetTripById(tripId);
                sb.AppendLine($"To {trip.DestinationBusStation.BusStationName} | Depart at: {trip.DepartureTime.ToString("dd-MM-yyyy")} | Status {trip.Status}");
            }
            return sb.ToString();
        }
    }
}
