using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface ICommando:ISpecialiasedSolider
    {
    Dictionary<string,string> Missions { get; }
    void CompleteMission();
    }

