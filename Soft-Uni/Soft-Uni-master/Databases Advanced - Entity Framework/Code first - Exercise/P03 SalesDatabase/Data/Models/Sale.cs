using System;
using System.Collections.Generic;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    public class Sale
    {
        public Sale()
        {

        }

        public Sale(DateTime date, Product product, Customer customer, Store stroe)
        {
            this.Date = date;
            this.Product = product;
            this.Customer = customer;
            this.Store = Store;
        }

        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
    }
}
