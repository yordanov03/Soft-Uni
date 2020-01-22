using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var inputCells = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();


        Smartphone smartphone = new Smartphone();

        for (int i = 0; i < inputCells.Count; i++)
        {
            smartphone.CallPeople(inputCells[i]);
        }

        var inputSites = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        if (inputSites.Count == 0)
        {
            Console.WriteLine($"Browsing: !");

        }

        for (int i = 0; i < inputSites.Count; i++)
        {

            smartphone.Browsing(inputSites[i]);
        }


    }
}



