using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Library
{
    private List<Books> books;

    public Library(params Books [] books)
    {
        this.books = new List<Books>(books);
    }
}

