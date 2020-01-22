using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Program
    {
        static void Main(string[] args)
        {
        int numberOfSongs = int.Parse(Console.ReadLine());
        List<Songs> allSongs = new List<Songs>();
        int minutes = 0;
        int seconds = 0;
        int hours = 0;

        for (int i = 0; i < numberOfSongs; i++)
        {
            var input = Console.ReadLine().Split(new[] {';',':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            try
            {
                allSongs.Add(new Songs(input[0], input[1], int.Parse(input[2]), int.Parse(input[3])));
                Console.WriteLine("Song added.");
                minutes += int.Parse(input[2]);
                seconds += int.Parse(input[3]);
            }
            catch (Exception ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
        Console.WriteLine($"Songs added: {allSongs.Count}");
        minutes+=seconds/60;
        hours += minutes / 60;
        minutes = minutes % 60;
        seconds = seconds % 60;
        Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");

        }
    }

