using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Client.Core.Commands.Contracts;
using BusTicketsSystem.Models;
using BusTicketsSystem.Services;
using BusTicketsSystem.Services.Interfaces;
using System.Linq;

namespace BusTicketsSystem.Client.Core.Commands
{
    public class PublishReviewCommand : ICommand
    {
        private readonly IReviewService reviewService;
        private readonly ICustomerService customerService;
        private readonly IBusCompanyService busCompanyService;

        public PublishReviewCommand(IReviewService reviewService, ICustomerService customerService, IBusCompanyService busCompanyService)
        {
            this.reviewService = reviewService;
            this.customerService = customerService;
            this.busCompanyService = busCompanyService;
        }
        public string Execute(params string[] data)
        {
            int customerId = int.Parse(data[0]);
            var grade = float.Parse( data[1]);
            var busCompanyName = data[2];
            var content = data[3];

            Customer customer = customerService.GetCustomerById(customerId);
            BusCompany busCompany = busCompanyService.GetBusCompanyByName(busCompanyName);

            if (customer == null || busCompany == null)
            {
                throw new ArgumentException($"Incorecet parameters!");
            }

            reviewService.PublishReview(customer, grade, busCompany, content);

            return $"Customer {customer.FirstName} {customer.LastName} published review for company {busCompany.BusCompanyName}";
        }
    }
}
