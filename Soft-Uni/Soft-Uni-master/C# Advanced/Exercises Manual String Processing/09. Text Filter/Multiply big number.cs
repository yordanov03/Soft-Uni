using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var toBeFiltered = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var text = Console.ReadLine();
            

            for (int i = 0; i < toBeFiltered.Count; i++)
            {
                var replaced = "";
                string replacer = "";
                for (int k = 0; k < toBeFiltered[i].Length; k++)
                {
                    replacer += "*";
                }

                replaced = text.Replace(toBeFiltered[i], replacer);
                text = replaced;
            }
            Console.WriteLine(text.ToString());
        }
    }
}
