using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Children
{
    public string childName;
    public string childBirthday;

    public Children(string childName, string childBirthday)
    {
        this.ChildName = childName;
        this.childBirthday = childBirthday;
    }

    private string ChildName
    {
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(Children)}'s name cannot be empty or whitespace!");
            }
            this.childName = value;
        }
    }
}
