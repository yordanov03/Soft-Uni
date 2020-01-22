using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Champion_s_League
{
   public class Team
    {
        public string teamName { get; set; }
       public HashSet<string> opponents { get; set; }
      public  int wins { get; set; }
    }
}
