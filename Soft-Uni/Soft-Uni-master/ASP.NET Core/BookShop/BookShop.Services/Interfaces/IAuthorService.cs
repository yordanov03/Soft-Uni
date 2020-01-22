using BookShop.Data.Models;
using BookShop.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Services.Interfaces
{
    public interface IAuthorService
    {
        AuthorInfoServiceModel GetAuthor(string id);
        string CreateAuthor(string firstName, string lastName);
    }
}
