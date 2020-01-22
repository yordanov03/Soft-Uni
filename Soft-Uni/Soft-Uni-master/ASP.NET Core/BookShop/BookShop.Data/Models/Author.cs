using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Data.Models
{
    public class Author:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Book> Books { get; set; } = new List<Book>();
    }
}
