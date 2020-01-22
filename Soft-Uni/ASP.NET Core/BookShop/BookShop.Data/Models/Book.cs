using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Data.Models
{
    public class Book
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Copies { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public string Edition { get; set; }
        public List<CategoryBook> Categories { get; set; }
    }
}
