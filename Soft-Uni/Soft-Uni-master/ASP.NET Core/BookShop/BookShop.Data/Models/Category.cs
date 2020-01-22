using System;
using System.Collections.Generic;

namespace BookShop.Data.Models
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public List<CategoryBook> Books { get; set; }
    }
}
