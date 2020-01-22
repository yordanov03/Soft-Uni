using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface IEngeneer:ISpecialiasedSolider
    {
        Dictionary<string,int> Repairs { get; }
    }

