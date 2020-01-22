using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        Books bookOne = new Books("Animal Farm", 2003, "George Orwell");
        Books bookTwo = new Books("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
        Books bookThree = new Books("The Documents in the Case", 1930);

        Library libraryOne = new Library();
        Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

        foreach (var book in libraryTwo)
        {
            Console.WriteLine(book.Title);
        }
    }
}

