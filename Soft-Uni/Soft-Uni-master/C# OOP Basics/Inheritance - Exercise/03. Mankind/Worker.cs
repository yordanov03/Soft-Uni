using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Worker :Human
    {
    private decimal weekSalary;
        private decimal hoursPerDay;

    public Worker(string firstName, string lastNmae, decimal weekSalary, decimal hoursPerDay):base(firstName,lastNmae)
    {
        this.WeeklySalary = weekSalary;
        this.HoursPerDay = hoursPerDay;
    }
    public decimal WeeklySalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value<=10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }
    public decimal HoursPerDay
    {
        get { return this.hoursPerDay; }
        set
        {
            if (value<1 || value>12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.hoursPerDay = value;
        }
    }

    public override string ToString()
    {
        var salaryPerHour = weekSalary /(5* hoursPerDay);

        return $"First Name: {FirstName}\n" +
            $"Last Name: {LastName}\n" +
            $"Week Salary: {WeeklySalary:F2}\n" +
            $"Hours per day: {HoursPerDay:F2}\n" +
            $"Salary per hour: {salaryPerHour:F2}";

    }
}

