using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JSON_stringify
{

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dnevnik = new List<Student>();

            while (input!= "stringify")
            {
                var separated = input.Split(new[] { ' ', '“', ':', '”', ',', '“', '-', '”', ',', '“', '>', '”', ',', '“', '”', '.' }, StringSplitOptions.RemoveEmptyEntries);
                var nameOfStudent = separated[0];
                var ageOfStudent = int.Parse(separated[1]);
                var gradesOfStudent = separated.Skip(2).ToList();

                var student = new Student();
                student.name = nameOfStudent;
                student.age = ageOfStudent;
                student.grades = gradesOfStudent ;

                dnevnik.Add(student);
                input = Console.ReadLine();
            }

            string output = "[";

            for (int i = 0; i < dnevnik.Count; i++)
            {
                var currentStudent = dnevnik[i];
                output += "{";
                output += "name:\"" + currentStudent.name + "\"" + ",";
                output += "age:" + currentStudent.age + ",";
                output += "grades:[" + string.Join(", ", currentStudent.grades) + "]}";

                if (i<dnevnik.Count-1)
                {
                    output += ",";
                }
            }
            output += "]";

            Console.WriteLine(output);
        }
    }
}
