using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();
        ListyIterator<string> listyIterator = null;

        while (input != "END")
        {
            var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            switch (separated[0])
            {
                case "Create":
                    var elements = separated.Skip(1).ToArray();
                    listyIterator = new ListyIterator<string>(elements);
                    break;
                case "Move":
                    Console.WriteLine(listyIterator.Move());
                    break;
                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());
                    break;
                case "Print":
                    try
                    {
                        Console.WriteLine(listyIterator.Print());
                    }
                    catch (ArgumentException ae)
                    {

                        Console.WriteLine(ae.Message);
                    }
                    break;
            }
            input = Console.ReadLine();
        }
    }
}

