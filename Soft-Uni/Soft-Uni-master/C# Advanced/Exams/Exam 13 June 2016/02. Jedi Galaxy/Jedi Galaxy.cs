using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Jedi_Galaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var separatedInput = input.Split(' ').Select(int.Parse).ToList();
            int[][] galaxy = new int[separatedInput[0]][];
            int gatheredStars = 0;
            int counter = 0;

            for (int i = 0; i < separatedInput[0]; i++)
            {
                galaxy[i] = new int[separatedInput[0]];

                for (int j = 0; j < separatedInput[1]; j++)
                {
                    galaxy[i][j] = counter;
                    counter++;
                }
            }

            var coordinatesIvo = Console.ReadLine();

            while (coordinatesIvo!= "Let the Force be with you")
            {
                var separatedIvo = coordinatesIvo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                var coordinatesEvilForce = Console.ReadLine();
                var separatedEvilForce = coordinatesEvilForce.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                int ivoRow = separatedIvo[0];
                int ivoCol = separatedIvo[1];
                

                int evilForceRow = separatedEvilForce[0];
                int evilForceCol = separatedEvilForce[1];
                 
                // EvilForce

                for (int i = 0; i < separatedInput[0]; i++)
                {
                    if (evilForceRow>=0 && evilForceRow<separatedInput[0] && evilForceCol>=0 && evilForceCol<separatedInput[1])
                    {
                        galaxy[evilForceRow][evilForceCol] = 0;
                        evilForceRow--;
                        evilForceCol--;
                    }
                  else if (evilForceCol<0 && evilForceRow>=separatedInput[0])
                    {
                        i--;
                        evilForceCol++;
                        evilForceRow--;
                        
                    }
                    else if (evilForceRow>=separatedInput[0] && evilForceCol>=separatedInput[1])
                    {
                        i--;
                        evilForceCol--;
                        evilForceRow--;
                    }
                    else if (evilForceCol>=separatedInput[1])
                    {
                        i--;
                        evilForceCol--;
                        evilForceRow--;
                       
                    }
                    else if (evilForceCol<0)
                    {
                        i--;
                        evilForceRow++;
                        evilForceCol++;
                        
                    }
                    
                }

                //Ivo rotation

                for (int i = 0; i < separatedInput[0]; i++)
                {
                    if (ivoRow>=0 && ivoRow<separatedInput[0] && ivoCol>=0 && ivoCol<separatedInput[1])
                    {
                        gatheredStars += galaxy[ivoRow][ivoCol];
                        ivoRow--;
                        ivoCol++;
                    }
                    else if (ivoCol<0 && ivoRow>=separatedInput[0])
                    {
                        ivoCol++;
                        ivoRow--;
                        i--;
                    }
                    else if (ivoCol>=separatedInput[1] && ivoRow>=separatedInput[0])
                    {
                        ivoCol--;
                        ivoRow--;
                        i--;
                    }
                    else if (ivoCol>=separatedInput[0])
                    {
                        ivoRow--;
                        ivoCol--;
                        i--;
                    }
                    else if (ivoCol<0)
                    {
                        ivoCol++;
                        ivoRow--;
                        i--;
                    }
                    else if (ivoRow>=separatedInput[0])
                    {
                        i--;
                        ivoRow--;
                        ivoRow--;
                    }
                    
                }

                coordinatesIvo = Console.ReadLine();
            }

            Console.WriteLine(gatheredStars);
        }
    }
}
