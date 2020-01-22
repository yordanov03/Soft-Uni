using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Employee>();
            int numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEmployees; i++)
            {
                var employeeInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var employee = new Employee(employeeInfo[0], decimal.Parse(employeeInfo[1]), employeeInfo[2], employeeInfo[3]);

                if (employeeInfo.Length>5)
                {
                    employee.age = int.Parse(employeeInfo[5]);
                }
                if (employeeInfo.Length>4)
                {
                    var ageOrEmail=employeeInfo[4];
                    if (ageOrEmail.Contains("@"))
                    {
                        employee.email = ageOrEmail;
                    }
                    else
                    {
                        employee.age = int.Parse(ageOrEmail);
                    }
                }
                people.Add(employee);
            }

        var result = people.GroupBy(e => e.department)
                .Select(e => new { Department = e.Key, AvarageSalary = e.Average(emp => emp.salary), Employees = e.OrderByDescending(emp => emp.salary) })
                .OrderByDescending(e => e.AvarageSalary).FirstOrDefault();
            Console.WriteLine($"Highest Average Salary: {result.Department}");

            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.name} {employee.salary:F2} {employee.email} {employee.age}");
            }
        }
    }

