using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Core.Factories
{
    public class StorageMaster
    {
        private ProductFactory productFactory;
        private StorageFactory storageFactory;
        private List<Product> allProducts;
        private List<Storage> allStorages;
        private Vehicle currentVehicle;

        public StorageMaster()
        {
            this.productFactory = new ProductFactory();
            this.storageFactory = new StorageFactory();
            this.allProducts = new List<Product>();
            this.allStorages = new List<Storage>();
        }



        public string AddProduct(string type, double price)
        {
            Product newProduct = productFactory.CreateProduct(type, price);
            allProducts.Add(newProduct);
            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            Storage newStorage = storageFactory.CreateStorage(type, name);
            allStorages.Add(newStorage);
            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            var selectedStorage = allStorages.Where(s => s.Name == storageName).FirstOrDefault();
            var selectedVehicle = selectedStorage.GetVehicle(garageSlot);
            currentVehicle = selectedVehicle;
            return $"Selected {selectedVehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            foreach (var product in productNames)
            {
                var productToRemove = allProducts.Where(p => p.GetType().Name == product).LastOrDefault();
                if (productToRemove == null)
                {
                    throw new InvalidOperationException($"{product} is out of stock!");
                }
                allProducts.Remove(productToRemove);
                currentVehicle.LoadProduct(productToRemove);
            }
            return $"Loaded {currentVehicle.Trunk.Count}/{productNames.Count()} products into {currentVehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            var sourceStorage = allStorages.Where(s => s.Name == sourceName).FirstOrDefault();
            var destinationStorage = allStorages.Where(s => s.Name == destinationName).FirstOrDefault();
            if (sourceStorage == null)
            {
                throw new InvalidOperationException("Invalid source storage!");
            }
            if (destinationStorage == null)
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }
            var currentVehicle = sourceStorage.GetVehicle(sourceGarageSlot);
            var destinationGarageSlot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);
            return $"Sent {currentVehicle.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            var selectedStorage = allStorages.Where(s => s.Name == storageName).FirstOrDefault();
            var selectedVehicle = selectedStorage.GetVehicle(garageSlot);
            int productsCountBeforeUnloading = selectedVehicle.Trunk.Count;
            var unloadedProductsCount = selectedStorage.UnloadVehicle(garageSlot);

            return $"Unloaded {unloadedProductsCount}/{productsCountBeforeUnloading} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            var sb = new StringBuilder();
            var selectedStorage = allStorages.Where(s => s.Name == storageName).FirstOrDefault();
            var orderedProducts = selectedStorage.Products.GroupBy(p => p.GetType().Name).Select(p => new { Name = p.Key, Count = p.Count() }).OrderByDescending(p => p.Count).ThenBy(p => p.Name).Select(p => $"{p.Name} ({p.Count})").ToList();
            sb.Append($"Stock ({selectedStorage.Products.Sum(p => p.Weight)}/{selectedStorage.Capacity}): [{string.Join(", ", orderedProducts)}]");
            var allVehicles = new List<string>();

            foreach (var garageSlot in selectedStorage.Garage)
            {
                if (garageSlot == null)
                {
                    allVehicles.Add("empty");
                }
                else
                {
                    allVehicles.Add(garageSlot.GetType().Name);
                }
            }
            sb.AppendLine();
            sb.AppendLine($"Garage: [{string.Join("|", allVehicles)}]");
            return sb.ToString().TrimEnd('\n', '\r');
        }

        public string GetSummary()
        {
            var sorted = allStorages.OrderByDescending(s => s.Products.Sum(p => p.Price));
            var sb = new StringBuilder();

            foreach (var storage in sorted)
            {
                sb.AppendLine($"{storage.Name}:");
                sb.AppendLine($"Storage worth: ${storage.Products.Sum(p => p.Price):F2}");
            }
            return sb.ToString().TrimEnd();
        }

    }

}