using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Parse_URLs
{
    class Program
    {
        static void Main(string[] args)
        {
            var URL = Console.ReadLine().Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (URL.Count!=2 || URL[1].IndexOf('/')==-1)
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                var protocol = URL[0];
                var serverEndIndex = URL[1].IndexOf('/');
                var server = URL[1].Substring(0, serverEndIndex);
                var resource = URL[1].Substring(serverEndIndex + 1);
                

                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resource}");

            }
            
        }
    }
}
