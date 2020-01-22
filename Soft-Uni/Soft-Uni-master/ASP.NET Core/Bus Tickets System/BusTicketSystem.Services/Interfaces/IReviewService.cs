using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Models;

namespace BusTicketsSystem.Services.Interfaces
{
   public interface IReviewService
    {
        Review[] PrintReviewsByBusCompany(int busCompnayId);
        void PublishReview(Customer customer, float grade, BusCompany busCompany, string content);
    }
}
