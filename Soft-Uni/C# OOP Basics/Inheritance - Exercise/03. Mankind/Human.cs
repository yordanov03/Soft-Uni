using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Human
{
    private string fistName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
    public  string FirstName
    {
        get { return this.fistName; }
        set
        {
            var firstLetter = value.ToCharArray();
            if (firstLetter[0]<'A'||firstLetter[0]>'Z')
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }
            if (value.Length<4)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            this.fistName = value;
        }
    }
    public string LastName
    {
        get { return this.lastName; }
        set
        {
            var firstLetter = value.ToCharArray();
            if (firstLetter[0]<'A' || firstLetter[0]>'Z')
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }
            if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName ");
            }
            this.lastName = value;
        }
    }
}


