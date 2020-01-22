using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Students_Joined_to_Specialties
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var specialityAndNumber = new List<Student>();

            while (input!="Students:")
            {
                var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                specialityAndNumber.Add(new Student { SpecialityName = separated[0] + " " + separated[1], FacultyNumber = separated[2] });
                input = Console.ReadLine();
            }

            var inputNames = Console.ReadLine();
            var numberAndName = new List<NumberAndNames>();

            while (inputNames!="END")
            {
                var separated = inputNames.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                numberAndName.Add(new NumberAndNames { FacultyNumber = separated[0], NameStudent = separated[1] + " " + separated[2] });
                inputNames = Console.ReadLine();
            }

            var joined = specialityAndNumber.Join(numberAndName, st => st.FacultyNumber, p => p.FacultyNumber, (st, p) => new { Name = p.NameStudent, FacNum = st.FacultyNumber, Spec = st.SpecialityName });

            foreach (var item in joined.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{item.Name} {item.FacNum} {item.Spec}");
            }
        }
    }
}
