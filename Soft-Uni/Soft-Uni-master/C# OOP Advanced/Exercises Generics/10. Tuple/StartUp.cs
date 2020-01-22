using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public static void Main(string[] args)
    {

        var nameAndAdress = Console.ReadLine().Split();
        var fullName = nameAndAdress[0] + " " + nameAndAdress[1];
        var address = nameAndAdress[2];
        var firstTuple = new Tuple<string, string>(fullName, address);
        Console.WriteLine(firstTuple);

        var personAndBeer = Console.ReadLine().Split();
        var name = personAndBeer[0];
        var beer = int.Parse(personAndBeer[1]);
        var secondTuple = new Tuple<string, int>(name, beer);
        Console.WriteLine(secondTuple);

        var integerAndDouble = Console.ReadLine().Split();
        var firstNum = int.Parse(integerAndDouble[0]);
        var secondNum = double.Parse(integerAndDouble[1]);
        var thirdTuple = new Tuple<int, double>(firstNum, secondNum);
        Console.WriteLine(thirdTuple);
        
    }
}

