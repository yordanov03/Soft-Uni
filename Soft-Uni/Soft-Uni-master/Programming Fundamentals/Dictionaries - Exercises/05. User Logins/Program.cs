using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, string>();
            var line = Console.ReadLine();
            var unsuccessfulLogins = 0;

            while (line!="login")
            {
                var split = line.Split();
                var username = split[0];
                var password = split[split.Length-1];

                database[username] = password;
                line = Console.ReadLine();
            }
            line = Console.ReadLine();

            while (line!="end")
            {
                var split = line.Split();
                var username = split[0];
                var password = split[split.Length - 1];
                

                if (database.ContainsKey(username) && database.ContainsValue(password))
                {
                    Console.WriteLine($"{username}: logged in successfully");
                  
                }

                else if (!database.ContainsKey(username) || !database.ContainsValue(password))
                
                {
                    Console.WriteLine($"{username}: login failed" );
                    unsuccessfulLogins++;
                }
                line = Console.ReadLine();
            }
            if (unsuccessfulLogins > 0)
            {
                Console.WriteLine("unsuccessful login attempts: {0}", unsuccessfulLogins);
            }
        }
    }
}
