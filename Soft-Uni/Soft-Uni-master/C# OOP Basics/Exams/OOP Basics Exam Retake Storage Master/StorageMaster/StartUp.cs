using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace StorageMaster
{
    
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var storageMaster = new Core.Factories. StorageMaster();
            var command = Console.ReadLine();

            while (command!="END")
            {
                var separated = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var action = separated[0];
                var input = separated.Skip(1).ToList();

                try
                {
                    switch (action)
                    {
                        case "AddProduct":
                            Console.WriteLine( storageMaster.AddProduct(input[0], double.Parse(input[1])));
                            break;
                        case "RegisterStorage":
                          Console.WriteLine(storageMaster.RegisterStorage(input[0], input[1]));
                            break;
                        case "SelectVehicle":
                            Console.WriteLine(storageMaster.SelectVehicle(input[0], int.Parse(input[1])));
                            break;
                        case "LoadVehicle":
                            Console.WriteLine(storageMaster.LoadVehicle(input));
                            break;
                        case "SendVehicleTo":
                            Console.WriteLine(storageMaster.SendVehicleTo(input[0], int.Parse(input[1]), input[2]));
                            break;
                        case "UnloadVehicle":
                            Console.WriteLine(storageMaster.UnloadVehicle(input[0], int.Parse(input[1])));
                            break;
                        case "GetStorageStatus":
                            Console.WriteLine(storageMaster.GetStorageStatus(input[0]));
                            break;
                    }
                }
                catch (InvalidOperationException oe)
                {
                    Console.WriteLine($"Error: {oe.Message}");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(storageMaster.GetSummary());
        }
    }
}
