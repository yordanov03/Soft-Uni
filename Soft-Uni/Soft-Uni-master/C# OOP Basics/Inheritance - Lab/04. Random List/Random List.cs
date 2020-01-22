using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Random_List: List<string>
    {
    Random random = new Random();

    public string RandomString()
    {
        string result = null;
        if (this.Count > 0)
        {
            var randomIndex = random.Next(0, this.Count - 1);
            result = this[randomIndex];
            this.RemoveAt(randomIndex);
        }
        return result;
    }

}

