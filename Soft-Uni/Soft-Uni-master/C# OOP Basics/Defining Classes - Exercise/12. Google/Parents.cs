using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Parents
{
    public string parentName;
    public string parentBirthday;

    public Parents(string parentName, string parentBirthday)
    {
        this.ParentName = parentName;
        this.parentBirthday = parentBirthday;
    }

    private string ParentName
    {
        set
        {
            if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(parentName)}'s name cannot be empty or whitespace!");
            }
            this.parentName = value;
        }
    }
}

