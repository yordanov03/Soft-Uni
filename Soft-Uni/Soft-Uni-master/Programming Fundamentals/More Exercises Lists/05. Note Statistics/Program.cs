using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<string> notes = new List<string>();
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();
            double naturalsSum = 0;
            double sharpsSum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == 261.63)
                {
                    notes.Add("C");
                    naturals.Add("C");
                    naturalsSum += 261.63;
                    
                }
                else if (input[i] == 277.18)
                {
                    notes.Add("C#");
                    sharps.Add("C#");
                    sharpsSum += 277.18;
                    
                }
                else if (input[i] == 293.66)
                {
                    notes.Add("D");
                    naturals.Add("D");
                    naturalsSum += 293.66;
                    
                }
                else if (input[i] == 311.13)
                {
                    notes.Add("D#");
                    sharps.Add("D#");
                    sharpsSum += 311.13;
                    
                }
                else if (input[i] == 329.63)
                {
                    notes.Add("E");
                    naturals.Add("E");
                    naturalsSum += 329.63;
                   
                }
                else if (input[i] == 349.23)
                {
                    notes.Add("F");
                    naturals.Add("F");
                    naturalsSum += 349.23;
                 
                }
                else if (input[i] == 369.99)
                {
                    notes.Add("F#");
                    sharps.Add("F#");
                    sharpsSum += 369.99;
                  
                }
                else if (input[i] == 392.00)
                {
                    notes.Add("G");
                    naturals.Add("G");
                    naturalsSum += 392.00;
                   
                }
                else if (input[i] == 415.30)
                {
                    notes.Add("G#");
                    sharps.Add("G#");
                    sharpsSum += 415.30;
                    
                }
                else if (input[i] == 440.00)
                {
                    notes.Add("A");
                    naturals.Add("A");
                    naturalsSum += 440.00;
                    
                }
                else if (input[i] == 466.16)
                {
                    notes.Add("A#");
                    sharps.Add("A#");
                    sharpsSum += 466.16;
                    
                }
                else if (input[i] == 493.88)
                {
                    notes.Add("B");
                    naturals.Add("B");
                    naturalsSum += 493.88;
                 
                }
                
            }

            Console.WriteLine("Notes: {0}",string.Join(" ", notes));
            Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));
            Console.WriteLine($"Naturals sum: {naturalsSum}");
            Console.WriteLine($"Sharps sum: {sharpsSum}");

            
        }
    }
}
