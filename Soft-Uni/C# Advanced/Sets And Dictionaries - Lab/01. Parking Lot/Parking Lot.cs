using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new SortedSet<string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var command = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var movement = command[0];
                var carNumber = command[1];

                if (movement == "IN")
                {
                    parking.Add(carNumber);
                }
                else
                {
                    if (parking.Contains(carNumber))
                    {
                        parking.Remove(carNumber);
                    }
                }

                input = Console.ReadLine();
            }

            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }

            else
            {
                foreach (var item in parking)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

