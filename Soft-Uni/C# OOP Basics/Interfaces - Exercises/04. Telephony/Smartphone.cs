using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Smartphone :ICallable, IBrowseable
    {

    public Smartphone()
    {

    }
    public void CallPeople(string number)
    {
        if (number.All(c => c >= '0' && c <= '9'))
        {
            Console.WriteLine($"Calling... {number}");
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }

    public void Browsing(string site)
    {
        bool IsLettersOnly = true;
        IsLettersOnly = site.Any(char.IsDigit);

        if (IsLettersOnly==false)
        {
            Console.WriteLine($"Browsing: {site}!");
        }
        
        else
        {
            Console.WriteLine($"Invalid URL!");
        }
    }
    }

