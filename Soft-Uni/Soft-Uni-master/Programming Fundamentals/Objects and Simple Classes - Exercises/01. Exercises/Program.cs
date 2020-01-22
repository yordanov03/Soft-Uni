using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var results = new Exercise();

            while (inputLine!="go go go")
            {
                var inputParams = inputLine.Split(new[] { ' ', '>', '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string topic = inputParams[0];
                string courseName = inputParams[1];
                string judgeContestLink = inputParams[2];
                var problems = inputParams.Skip(3).ToList();

                
                results.topic = topic;
                results.courseName = courseName;
                results.JudgeContestLink = judgeContestLink;
                results.Problems = problems;

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"Exercises: {results.topic}");
            Console.WriteLine($"Problems for exercises and homework for the {results.courseName} course @ SoftUni.");
            Console.WriteLine($"Check your solutions here: \n{results.JudgeContestLink}");

            int count = 1;

            foreach (var item in results.Problems)
            {
                Console.WriteLine($"{count}. {item}");
                count++;
            }
        }
    }
}
