using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Family
    {
    List<Person> people;

    public Family()
    {
        this.people = new List<Person>();
    }
    public List<Person> People
    {
        get { return this.people; }
    }

    public void AddMember(Person member)
    {
        people.Add(member);
    }

    public Person GetTheOldestMember()
    {
        return people.OrderByDescending(p => p.Age).FirstOrDefault();
    }
    }

