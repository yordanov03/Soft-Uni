using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class StartUp
    {
        public static void Main(string[] args)
        {
            var scale = new Scale<string>("Pesho", "Gosho");
            Console.WriteLine(scale.GetHeavier());
        }
    }

