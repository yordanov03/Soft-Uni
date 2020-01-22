﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_оf_The_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));
            string lastdigit = PrintLastDigit(number);
            Console.WriteLine(lastdigit);
            

        }

        static string PrintLastDigit(long number)
        {
            
            long lastdigitsaved = 0;
            lastdigitsaved = number % 10;


            switch (lastdigitsaved)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one"; 

                case 2:
                    return "two"; 
                case 3:
                    return "three"; 
                case 4:
                    return "four"; 
                case 5:
                    return "five"; 
                case 6:
                    return "six"; 
                case 7:
                    return "seven"; 
                case 8:
                    return "eight"; 
                case 9:
                    return "nine";
                default:
                    return 8;
                
                  
            }
            return "";
        }
    }
}
