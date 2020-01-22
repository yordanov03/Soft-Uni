using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookShop.Data;
using BookShop.Data.Models;
using BookShop.Services.Interfaces;
using BookShop.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Services.Implementations
{
    public class AuthorService : IAuthorService
    {
        private readonly BookShopDbContext db;
        private readonly IMapper mapper;

        public AuthorService(BookShopDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public string CreateAuthor(string firstName, string lastName)
        {
            var author = new Author { FirstName = firstName, LastName = lastName };
            this.db.Add(author);
            this.db.SaveChanges();
            return author.Id;
        }

        public AuthorInfoServiceModel GetAuthor(string id)
        {
            return this.db.Authors.Where(a => a.Id == id).ProjectTo<AuthorInfoServiceModel>(mapper.ConfigurationProvider).FirstOrDefault();
        }
    }
}
