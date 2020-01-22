using _14.Areas_Lab.Infrastructure.Mapping;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14.Areas_Lab.Models
{
    public class UserViewModel:IMapFrom<ApplicationUser>, IHaveCustomMappings

    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string MailAddress { get; set; }

        public void ConfigureMapping(Profile profile) => profile.CreateMap<ApplicationUser, UserViewModel>().ForMember(u => u.MailAddress, cfg => cfg.MapFrom(u => u.Email));
    }
}
