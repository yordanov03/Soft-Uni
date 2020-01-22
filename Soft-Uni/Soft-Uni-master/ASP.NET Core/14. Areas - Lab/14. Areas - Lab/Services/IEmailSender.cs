using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14._Areas___Lab.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
