using System;
using Microsoft.EntityFrameworkCore;
using BusTicketsSystem.Data;
using Microsoft.Extensions.DependencyInjection;
using BusTicketsSystem.Client.Core;
using BusTicketsSystem.Models;
using BusTicketsSystem.Services.Interfaces;
using BusTicketsSystem.Services;

namespace BusTicketsSystem.Client
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var db = new BusTicketSystemContext();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            IServiceProvider serviceProvider = ConfigureServices();

            IDatabaseService databaseInitilizer = serviceProvider.GetService<IDatabaseService>();
            ICommandDispatcher commandDispatcher = serviceProvider.GetService<ICommandDispatcher>();

            Engine engine = new Engine(commandDispatcher, databaseInitilizer);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddDbContext<BusTicketSystemContext>(options => options.UseSqlServer(ServerConfig.ConnectionString));

            services.AddTransient<ICommandDispatcher, CommandDispatcher>();
            services.AddTransient<IBusCompanyService, BusCompanyService>();
            services.AddTransient<IBusStationService, BusStationService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IDatabaseService, DatabaseService>();
            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient<ITicketService, TicketService>();
            services.AddTransient<ITripService, TripService>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
