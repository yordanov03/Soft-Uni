using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class StartUp
    {
        static void Main(string[] args)
        {
        string name = Console.ReadLine();
        ICar ferrari = new Ferrari("488-Spider");

        Console.Write(ferrari.Model);
        ferrari.Brakes();
        ferrari.GasPedal();
        Console.Write(name);
        }
    }

