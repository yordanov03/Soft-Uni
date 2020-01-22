using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Resizable_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            string[] command = Console.ReadLine().Split(' ');
            int index = 0;
            while (command[0] !="end")
            
            {
                
                if (command[0] == "push")
                {
                    int input = int.Parse(command[1]);
                    array[index] = input;
                    index++;
                    if (index == array.Length)
                    {
                        int[] array2 = new int[array.Length * 2];
                        for (int i = 0; i < array.Length; i++)
                        {
                            array2[i] = array[i];
                        }
                        array = array2;
                    }
                }
                else if (command[0] == "pop")
                {
                    index--;
                   
                }
                else if (command[0] == "removeAt")
                {
                    int removeAtIndex = int.Parse(command[1]);
                    for (int i = removeAtIndex; i < array.Length-1; i++)
                    {
                        array[i] = array[i + 1];
                    }
                    index--;
                }
                else
                {
                    index = 0;
                }
                command = Console.ReadLine().Split(' ');
            }

            if (index ==0)
            {
                Console.WriteLine("empty array");
            }
            for (int i = 0; i < index; i++)
            {
                Console.Write(array[i] + " ");

            }
        }
    }
}
