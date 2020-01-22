using AutoMapper;
using BookShop.Common.Mapping;
using BookShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop.Services.Models
{
    public class AuthorInfoServiceModel:IMapFrom<Author>, IHaveCustomMapping
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<string> BookTitles { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<Author, AuthorInfoServiceModel>().ForMember(ai => ai.BookTitles, cfg => cfg.MapFrom(t => t.Books.Select(b => b.Title)));
        }
    }
}
