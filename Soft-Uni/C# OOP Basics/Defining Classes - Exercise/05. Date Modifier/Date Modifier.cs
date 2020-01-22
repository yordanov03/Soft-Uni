using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


    public class Program
    {
        static void Main(string[] args)
        {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();
        Console.WriteLine(DateModifier.DifferenceBetweenDates(firstDate, secondDate));
        }
    }

