using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSON_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { '{',  '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var dnevnik = new List<Student>();

            for (int i = 1; i < input.Count; i+=2)
            {
                var split = input[i].Split(new[] { '"',',',':','[',']' }, StringSplitOptions.RemoveEmptyEntries);
                var name = split[1];
                var age = int.Parse(split[3]);
                var grades = split.Skip(5).ToList();

                var currentStudent = new Student();
                currentStudent.name = name;
                currentStudent.age = age;
                currentStudent.grades = grades;
                if (currentStudent.grades.Count==0)
                {
                    currentStudent.grades.Add("None");
                }
                

                dnevnik.Add(currentStudent);
            }

            foreach (var item in dnevnik)
            {
                Console.WriteLine($"{item.name} : {item.age} -> {string.Join(",",item.grades)}");
            }
            
        }
    }
}
