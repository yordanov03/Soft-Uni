using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14.Areas_Lab.Infrastructure.Mapping
{
    public interface IHaveCustomMappings
    {
        void ConfigureMapping(Profile profile);
    }
}
