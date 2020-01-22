using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndCodeWizards
{

   public  class StartUp
    {
        public static void Main(string[] args)
        {

            var input = Console.ReadLine();
            DungeonMaster dungeonMaster = new DungeonMaster();

            while (!string.IsNullOrEmpty(input))
            {
                var separaedInput = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = separaedInput[0];
                var arguments = separaedInput.Skip(1).ToArray();

                try
                {
                    switch (command)
                    {
                        case "JoinParty":
                            Console.WriteLine(dungeonMaster.JoinParty(arguments));
                            break;
                        case "AddItemToPool":
                            Console.WriteLine(dungeonMaster.AddItemToPool(arguments));
                            break;
                        case "PickUpItem":
                            Console.WriteLine(dungeonMaster.PickUpItem(arguments));
                            break;
                        case "UseItem":
                            Console.WriteLine(dungeonMaster.UseItem(arguments));
                            break;
                        case "UseItemOn":
                            Console.WriteLine(dungeonMaster.UseItemOn(arguments));
                            break;
                        case "GiveCharacterItem":
                            Console.WriteLine(dungeonMaster.GiveCharacterItem(arguments));
                            break;
                        case "GetStats":
                            Console.WriteLine(dungeonMaster.GetStats());
                            break;
                        case "Attack":
                            Console.WriteLine(dungeonMaster.Attack(arguments));
                            break;
                        case "Heal":
                            Console.WriteLine(dungeonMaster.Heal(arguments));
                            break;
                        case "EndTurn":
                            Console.WriteLine(dungeonMaster.EndTurn());
                            break;
                    }
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine($"Parameter Error: {ae.Message}");
                }
                catch (InvalidOperationException oe)
                {
                    Console.WriteLine($"Invalid Operation: {oe.Message}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Final stats:");
            Console.WriteLine(dungeonMaster.GetStats());
        }

    }
}
