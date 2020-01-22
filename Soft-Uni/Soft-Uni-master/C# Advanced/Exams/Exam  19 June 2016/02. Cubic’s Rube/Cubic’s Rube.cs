using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _02.Cubic_s_Rube
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());
            int[,,] cube = new int[dimension, dimension, dimension];
            var input = Console.ReadLine();
            BigInteger sumOfImpact = 0L;
            int numbersOfCellsImpacted = 0;
            var history = new List<BigInteger>();
            bool hasPassed = false;

            while (input != "Analyze")
            {
                var separated = input.Split(' ').Select(BigInteger.Parse).ToList();

                for (int i = 0; i < history.Count; i+=3)
                {
                    if (separated[0] == history[i] && separated[1]==history[i+1] && separated[2]==history[i+2] )
                    {
                        hasPassed = true;
                    }
                }
                if (hasPassed==false)
                {
                    if (separated[0] < dimension && separated[0] > -1 && separated[1] < dimension && separated[1] > -1 && separated[2] > -1 && separated[2] < dimension && separated[3]!=0)
                    {
                        
                            sumOfImpact += separated[3];
                        
                        
                        numbersOfCellsImpacted++;
                        history.Add(separated[0]);
                        history.Add(separated[1]);
                        history.Add(separated[2]);
                    }
                }
                hasPassed = false;
                input = Console.ReadLine();
            }

            Console.WriteLine($"{sumOfImpact} \n{((dimension * dimension * dimension) - numbersOfCellsImpacted)}");

        }
    }
}
