using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var timeNow = DateTime.ParseExact(input, "HH:mm:ss", CultureInfo.InvariantCulture);
            var newtimenow=timeNow.AddSeconds(90);

            Console.WriteLine(newtimenow.TimeOfDay);
        }
    }
}
