using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13.Identity_lab.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
