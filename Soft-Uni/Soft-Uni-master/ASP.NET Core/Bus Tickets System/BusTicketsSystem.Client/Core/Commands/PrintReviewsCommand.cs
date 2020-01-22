using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Client.Core.Commands.Contracts;
using BusTicketsSystem.Services.Interfaces;

namespace BusTicketsSystem.Client.Core.Commands
{
    public class PrintReviewsCommand : ICommand
    {
        private readonly IReviewService reviewService;

        public PrintReviewsCommand(IReviewService reviewService)
        {
            this.reviewService = reviewService;
        }
        public string Execute(params string[] data)
        {
            var reviews = reviewService.PrintReviewsByBusCompany(int.Parse(data[0]));
            var sb = new StringBuilder();

            foreach (var review in reviews)
            {
                sb.AppendLine($"{review.ReviewId} {review.Grade} {review.DateTimeOfPublishing} {review.Customer.FirstName}" +
                    $"{review.Customer.LastName} {review.ReviewContent}");
            }
            return sb.ToString();
        }
    }
}
