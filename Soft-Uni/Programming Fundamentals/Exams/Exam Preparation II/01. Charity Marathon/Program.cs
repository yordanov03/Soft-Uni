using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int averageNumberOfLaps = int.Parse(Console.ReadLine());
            long lapLenght = long.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            trackCapacity = trackCapacity * days;
            runners = Math.Min(trackCapacity, runners);
            long totalMeters = runners * averageNumberOfLaps * lapLenght;
            long totalKm = totalMeters / 1000;
            double moneyRaised = moneyPerKm * totalKm;

            Console.WriteLine($"Money raised: { moneyRaised:f2}");

        }
    }
}
