using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Team
    {
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public Team(string name)
    {
        this.Name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public List<Person> FirstTeam
    {
        get {return this.firstTeam; }
    }
    public List<Person> ReserveTeam
    {
        get { return this.reserveTeam; }
    }

    public void AddPlayer(Person person)
    {
        if (person.Age>40)
        {
            firstTeam.Add(person);
        }
        else
        {
            reserveTeam.Add(person);
        }
    }
    }

