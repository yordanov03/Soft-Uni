using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exam_Preparation_I
{
    class Program
    {
        static void Main(string[] args)
        {
            var localTime = Console.ReadLine();
            ulong numberOfSteps = ulong.Parse(Console.ReadLine());
            ulong timeForStep = ulong.Parse(Console.ReadLine());

            ulong additionalTime = numberOfSteps * timeForStep;

            var newlocalTime = DateTime.ParseExact(localTime, "HH:mm:ss", CultureInfo.InvariantCulture);
            var withAddedTime = newlocalTime.AddSeconds(additionalTime);
            Console.WriteLine($"Time Arrival: {withAddedTime.TimeOfDay}");
        }
    }
}
