﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cubic_Artillery
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxCapacity = int.Parse(Console.ReadLine());
            var bunkers = new Queue<string>();
            var weapons = new Queue<int>();
            string inputLine = Console.ReadLine();
            var leftCapacity = maxCapacity;
            while (inputLine!= "Bunker Revision")
            {
                var tokens = inputLine.Split(' ');

                foreach (var element in tokens)
                {
                    int weapon;
                    var isDigit = int.TryParse(element, out weapon);

                    if (!isDigit)
                    {
                        bunkers.Enqueue(element);
                    }
                    else
                    {
                        var isSaved = false;
                        while (bunkers.Count>1)
                        {
                            if (leftCapacity>=weapon)
                            {
                                weapons.Enqueue(weapon);
                                leftCapacity -= weapon;
                                isSaved = true;
                                break;
                            }
 
                            if (weapons.Count==0)
                            {
                                Console.WriteLine($"{bunkers.Dequeue()} -> Empty");
                            }
                            else
                            {
                                Console.WriteLine($"{bunkers.Dequeue()} -> {string.Join(", ",weapons)}");
                            }
                            weapons.Clear();
                            leftCapacity = maxCapacity;
                        }
                        if (!isSaved)
                        {
                            if (weapon<=maxCapacity)
                            {
                                while (leftCapacity < weapon)

                                {
                                    leftCapacity += weapons.Dequeue();
                                }
                                    weapons.Enqueue(weapon);
                                    leftCapacity -= weapon;
                                
                                
                            }
                        }
                    }
                }
                inputLine = Console.ReadLine();
            }
        }
    }
}
