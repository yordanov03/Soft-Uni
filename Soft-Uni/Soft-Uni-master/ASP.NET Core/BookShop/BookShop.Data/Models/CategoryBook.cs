using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Data.Models
{
   public class CategoryBook
    {
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
    }
}
