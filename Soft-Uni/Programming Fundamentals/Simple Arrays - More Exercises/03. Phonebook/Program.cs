using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbersInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var namesInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string [] mixed = new string[phoneNumbersInput.Length + namesInput.Length];
            int index = 0;

            for (int i = 0; i < mixed.Length; i++)
            {
                var insertedName = Console.ReadLine();
                if (namesInput.Contains(insertedName))
                {

                }
            }


            
        }
    }
}
