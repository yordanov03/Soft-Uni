using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Student
    {
        public string name;
        public int age;
        public double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.grade = grade;
        }

    public override string ToString()
    {

        var gradeComment = GetGradeComment();
        return $"{Name} is {Age} years old.{gradeComment}";
    }
    public string GetGradeComment()
    {

        if (Grade >= 5.00)
        {
            return " Excellent student.";
        }
        else if (Grade < 5.00 && Grade >= 3.50)
        {
            return " Average student.";
        }
        else
        {
            return " Very nice person.";
        }

    }
}
