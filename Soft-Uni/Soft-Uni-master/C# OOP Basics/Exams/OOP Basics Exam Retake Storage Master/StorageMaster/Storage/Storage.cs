using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Storage
{
    private string name;
    private int capacity;
    private int garageSlots;
    private Vehicle[] garage;
    private List<Product> products;
    private bool isFull;

    public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
    {
        this.Name = name;
        this.Capacity = capacity;
        this.GarageSlots = garageSlots;
        this.garage = new Vehicle[garageSlots];
        this.products = new List<Product>();
        this.InitializeGarage(vehicles);

    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public int Capacity
    {
        get { return this.capacity; }
        set { this.capacity = value; }
    }
    public int GarageSlots
    {
        get { return this.garageSlots; }
        set { this.garageSlots = value; }
    }
    public bool IsFull
    {
        get { return this.isFull; }
        set
        {
            if (products.Sum(p => p.Weight) >= this.Capacity)
            {
                value = true;
            }
            else
            {
                value = false;
            }
            this.isFull = value;
        }
    }
    public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);
    public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();

    public Vehicle GetVehicle(int garageSlot)
    {
        if (garageSlot >= GarageSlots)
        {
            throw new InvalidOperationException("Invalid garage slot!");
        }
        var vehicle = this.garage[garageSlot];

        if (vehicle == null)
        {
            throw new InvalidOperationException("No vehicle in this garage slot!");
        }
        return vehicle;
    }
    public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
    {
        var vehicle = GetVehicle(garageSlot);
        var freeSlot = deliveryLocation.Garage.Any(s=>s==null);

        if (!freeSlot)
        {
            throw new InvalidOperationException("No room im garage!");
        }
        this.garage[garageSlot] = null;
        var destinationSlot = Array.IndexOf(deliveryLocation.garage, null);
        deliveryLocation.garage[destinationSlot] = vehicle;
        return destinationSlot;
    }
    public int UnloadVehicle(int garageSlot)
    {
        if (IsFull==true)
        {
            throw new InvalidOperationException("Storage is full!");

        }
        var vehicle = GetVehicle(garageSlot);
        int productsCount = 0;

        while (vehicle.IsEmpty==false && this.IsFull==false)
        {
            var unloadedProduct = vehicle.Unload();
            this.products.Add(unloadedProduct);
            productsCount++;
            if (vehicle.Trunk.Count == 0)
            {
                vehicle.IsEmpty = true;
            }
            if (this.Capacity==this.Products.Count)
            {
                this.IsFull = true;
            }

        }
        
        return productsCount;
    }
    private void InitializeGarage(IEnumerable<Vehicle> vehicles)
    {
        var garageSlot = 0;
        foreach (var vehicle in vehicles)
        {
            this.garage[garageSlot] = vehicle;
            garageSlot++;
        }
    }
}

