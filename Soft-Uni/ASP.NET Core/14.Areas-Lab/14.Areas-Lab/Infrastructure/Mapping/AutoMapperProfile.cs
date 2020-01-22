using _14.Areas_Lab.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace _14.Areas_Lab.Infrastructure.Mapping
{
    public class AutoMapperProfile : Profile
    {
        private readonly string[] Assemblies = new[]
        {
            "14.Areas-Lab",
            "14.Areas-Lab.Services"
        };
        public AutoMapperProfile()
        {
            //var types = new List<Type>();

            //foreach (var assemblyName in this.Assemblies)
            //{
            //    types.AddRange(Assembly.Load(assemblyName).GetTypes());
            //}

            var allTypes = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.GetName().Name.Contains("Areas-Lab")).SelectMany(a => a.GetTypes());

            AppDomain.CurrentDomain.GetAssemblies().Where(a => a.GetName().Name.Contains("14.Areas-Lab")).SelectMany(a => a.GetTypes()).Where(t => t.IsClass && !t.IsAbstract
            && t.GetInterfaces().Where(i => i.IsGenericType).Select(i => i.GetGenericTypeDefinition()).Contains(typeof(IMapFrom<>)))
                .Select(t => new
                {
                    Destination = t,
                    Source = t.GetInterfaces().Where(i => i.IsGenericType).Select(i => new { Defintion = i.GetGenericTypeDefinition(), Arguments = i.GetGenericArguments() })
                    .Where(i => i.Defintion == typeof(IMapFrom<>)).SelectMany(i => i.Arguments).First()}).ToList().ForEach(mapping=>this.CreateMap(mapping.Source, mapping.Destination));

            //var types = Assembly.GetExecutingAssembly().GetTypes();

            //this.CreateMap<ApplicationUser, UserViewModel>().ForMember(u=>u.MailAddress,cfg=>cfg.MapFrom(u=>u.Email));

            allTypes.Where(t => t.IsClass && !t.IsAbstract && typeof(IHaveCustomMappings).IsAssignableFrom(t))
                .Cast<IHaveCustomMappings>().ToList().ForEach(mapping=>mapping.ConfigureMapping(this));
        }
    }
}
