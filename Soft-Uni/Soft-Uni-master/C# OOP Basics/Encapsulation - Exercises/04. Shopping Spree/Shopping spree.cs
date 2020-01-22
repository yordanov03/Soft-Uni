using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
        var allPeople = new List<Person>();
        var allProducts = new List<Product>();

        try
        {
            var peopleInput = new List<Person>(Console.ReadLine()
                    .Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Split('='))
                    .Select(p => new Person(p[0], decimal.Parse(p[1]))));

            var producstInput = new List<Product>(Console.ReadLine().Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Split('=')).Select(p => new Product(p[0], decimal.Parse(p[1]))));
        }
        
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Input has to consist of: Name and Money");
            return;
        }
        
        catch (FormatException)
        {
            Console.WriteLine("Money parameter has to be a digit");
            return;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        var input = Console.ReadLine();

        while (input!="END")
        {
            var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var buyer = allPeople.Where(b => b.Name == separated[0]).FirstOrDefault();
            var currentproduct = allProducts.Where(p => p.Name == separated[1]).FirstOrDefault();

            if (buyer.Money>=currentproduct.Cost)
            {
                Console.WriteLine($"{buyer.Name} bought {currentproduct.Name}");
                buyer.SubstractMoney(currentproduct.Cost);
                buyer.Products.Add(new Product(currentproduct.Name, currentproduct.Cost));
            }
            else
            {
                Console.WriteLine($"{buyer.Name} can't afford {currentproduct.Name}");
            }
            input = Console.ReadLine();
        }

        foreach (var person in allPeople)
        {
            if (person.Products.Count==0)
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
            else
            {
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(product => product.Name))}");
            }
            
        }
    }
    }

