using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Stateless
{
    class Program
    {
        static void Main(string[] args)
        {

            var state = Console.ReadLine();
            var fiction = Console.ReadLine();

            while (state != "collapse")
            {

                while (fiction.Length > 0)
                {


                    if (state.Contains(fiction))
                    {
                        int index = -1;
                        index = state.IndexOf(fiction);
                        if (index >= 0)
                        {
                            state = state.Replace(fiction, "");
                        }
                        if (state.Length==0)
                        {
                            state = "(void)";
                            break;
                        }

                    }
                    
                    else if (fiction.Length>2)
                    {
                        fiction = fiction.Remove(0, 1);
                        fiction = fiction.Remove(fiction.Length - 1, 1);

                    }
                    else
                    {
                        break;
                    }


                }
                
                Console.WriteLine(state.Trim());
                state = Console.ReadLine();
                fiction = Console.ReadLine();
            }

        }
    }
}
