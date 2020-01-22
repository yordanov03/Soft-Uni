using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Student_system
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            var studentSystem = new StudentSystem();
            while ((command = Console.ReadLine())!="Exit")
            {
                studentSystem.ParseCommand(command);
            }
        }
    }
}
