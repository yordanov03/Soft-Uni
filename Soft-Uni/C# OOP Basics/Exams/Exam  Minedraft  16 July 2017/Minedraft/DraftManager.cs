using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DraftManager
{
    private List<Harvester> allHarveters;
    private List<Provider> allProviders;
    private HarvesterFactory harvesterFactory;
    private ProviderFactory providerFactory;
    private string mode;
    private double totalEnergyStored;
    private double totalMinedOre;

    public DraftManager()
    {
        allHarveters = new List<Harvester>();
        allProviders = new List<Provider>();
        harvesterFactory = new HarvesterFactory();
        providerFactory = new ProviderFactory();
        mode = "Full";
        totalEnergyStored = 0;
        totalMinedOre = 0;
        
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var harvester = harvesterFactory.CreateHarvester(arguments);
            allHarveters.Add(harvester);
            return $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";
        }
        catch (ArgumentException ae)
        {

            return ae.Message;
        }
    }
    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            var provider = providerFactory.CreateProvider(arguments);
            allProviders.Add(provider);
            return $"Successfully registered {arguments[0]} Provider - {arguments[1]}";
        }
        catch (ArgumentException ae)
        {

            return ae.Message;
        }
    }
    public string Day()
    {
        var totalEnergyRequired = allHarveters.Sum(h => h.EnergyRequirement);
        var totalOreOutput = allHarveters.Sum(h => h.OreOutput);
        double currentMinedOre = 0;
        totalEnergyStored += allProviders.Sum(p => p.EnergyOutput);
        var energy = allProviders.Sum(p => p.EnergyOutput);

        if (mode=="Half")
        {
            totalEnergyRequired = totalEnergyRequired * 0.6;
            totalOreOutput = totalOreOutput * 0.5;
        }
        else if(mode == "Energy")
        {
            totalEnergyRequired = 0;
            totalOreOutput = 0;
        }
        if (totalEnergyStored>=totalEnergyRequired)
        {
            totalEnergyStored -= totalEnergyRequired;
            totalMinedOre += totalOreOutput;
            currentMinedOre = totalOreOutput;
        }

        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.")
            .AppendLine($"Energy Provided: {energy}")
            .Append($"Plumbus Ore Mined: {currentMinedOre}");

        return sb.ToString();
        

    }
    public string Mode(List<string> arguments)
    {
        mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }
    public string Check(List<string> arguments)
    {
        var id = arguments[0];

        if (this.allProviders.Any(p => p.ID == id))
        {
            var provider = this.allProviders.FirstOrDefault(p => p.ID == id);

            return provider.ToString();
        }
        if (this.allHarveters.Any(h => h.ID == id))
        {
            var harvest = this.allHarveters.FirstOrDefault(h => h.ID == id);

            return harvest.ToString();
        }

        return $"No element found with id - {id}";

    }
    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown")
            .AppendLine($"Total Energy Stored: {totalEnergyStored}")
            .AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");

        return sb.ToString().Trim();

    }

}

