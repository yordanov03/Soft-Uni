using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Track
    {
    public Track(int lapsNumber, int trackLength)
    {
        this.LapsNumber = lapsNumber;
        this.TrackLength = trackLength;
        this.CurrentLap = 0;
    }
    public int LapsNumber { get; set; }
    public int TrackLength { get; private set; }
    public int CurrentLap { get; set; }
    }

