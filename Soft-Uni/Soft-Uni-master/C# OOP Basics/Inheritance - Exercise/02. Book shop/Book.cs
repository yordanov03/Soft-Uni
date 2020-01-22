using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public  class Book
    {
    private string title;
    private string author;
    private decimal price;

    public Book(string title, string author, decimal price)
    {
        
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public string Title
    {
        get { return this.title; }
        set
        {
            if (value.Length<3)
            {
                throw new ArgumentException("Title not valid!");
            }
            this.title = value;
        }
    }
    private string Author
    {
        get { return this.author; }
        set
        {
            var separated = value.Split(' ').ToList();
            var split = separated[1].ToCharArray();
            var firstLetter = split[0];
            

            if (char.IsDigit(firstLetter))
            {
                throw new ArgumentException("Author not valid!");
            }
            this.author = value;
        }
    }
    public virtual decimal Price
    {
        get { return this.price; }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException("Price not valid!");
            }
            this.price = value;
        }
    }
    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");

        string result = resultBuilder.ToString().TrimEnd();
        return result;
    }

}

