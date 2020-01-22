using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var customStack = new CustomStack<string>();

        while (input != "END")
        {
            var separated = input.Split(new[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            try
            {
                switch (separated[0])
                {
                    case "Push":
                        var toBePushed = separated.Skip(1).ToArray();
                        customStack.Push(toBePushed);
                        break;
                    case "Pop":
                        customStack.Pop();
                        break;
                }
            }
            catch (Exception ae)
            {

                Console.WriteLine(ae.Message);
            }
            input = Console.ReadLine();
        }

        foreach (var item in customStack)
        {
            Console.WriteLine(item);
        }
    }
}

