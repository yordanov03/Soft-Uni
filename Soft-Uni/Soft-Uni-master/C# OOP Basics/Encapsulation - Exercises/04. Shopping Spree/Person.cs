using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;
    private decimal money;

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            this.name = value;
        }

    }
    public decimal Money
    {
        get { return this.money; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }

    public List<Product> Products { get; set; }
    public Person(string name, decimal money)
    {
        this.Money = money;
        this.Name = name;
        this.Products = new List<Product>();
    }

    public decimal SubstractMoney(decimal amount)
    {
        return this.money -= amount;
    }
}

