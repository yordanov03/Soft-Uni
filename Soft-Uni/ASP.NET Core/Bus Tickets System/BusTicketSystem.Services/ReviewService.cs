using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Models;
using BusTicketsSystem.Services.Interfaces;
using BusTicketsSystem.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BusTicketsSystem.Services
{
    public class ReviewService : IReviewService
    {
        private readonly BusTicketSystemContext context;

        public ReviewService(BusTicketSystemContext context)
        {
            this.context = context;
        }


        public Review[] PrintReviewsByBusCompany(int busCompnayId)
        {
            var reviews = context.Reviews.Where(r => r.BusCompanyId == busCompnayId).ToArray();
            return reviews;
        }

        public void PublishReview(Customer customer, float grade, BusCompany busCompany, string content)
        {
            var review = new Review { Customer = customer, BusCompany = busCompany, ReviewContent = content, Grade = grade };
            context.Reviews.Add(review);
            context.SaveChanges();
        }
    }
}
