using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Student:Human
    {
    private string facultyNumber;

    public Student(string firstName, string lastName,string facultyNumber):base(firstName,lastName)
    {
        this.FacultyNumber = facultyNumber;
    }
    private string FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if (value.Length<4 || value.Length>11)
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return $"First Name: {base.FirstName}\n" +
            $"Last Name: {LastName}\n" +
            $"Faculty number: {facultyNumber}";
    }
}

