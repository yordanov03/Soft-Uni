using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class NameComparer : IComparer<Person>
{
    public int Compare(Person firstPerson, Person secondPerson)
    {
        int result = firstPerson.Name.Length.CompareTo(secondPerson.Name.Length);

        if (result == 0)
        {
            result = firstPerson.Name.ToLower().ToString().CompareTo(secondPerson.Name.ToLower().ToString());
        }
        return result;
    }
}

