using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RaceTower
{
    private Track track;
    private TyreFactory tyreFactory;
    private DriverFactory driverFactory;
    private List<Driver> allDrivers;
    private List<Driver> failedDrivers;
    private string weather;
    public bool raceIsOver;

    public RaceTower()
    {
        this.tyreFactory = new TyreFactory();
        this.driverFactory = new DriverFactory();
        this.allDrivers = new List<Driver>();
        this.failedDrivers = new List<Driver>();
        this.weather = "Sunny";
        this.raceIsOver = false;
    }
    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.track = new Track(lapsNumber, trackLength);
    }
    public void RegisterDriver(List<string> commandArgs)
    {
        try
        {
            string typeOfDriver = commandArgs[0];
            string nameOfDriver = commandArgs[1];
            int hp = int.Parse(commandArgs[2]);
            double fuelAmount = double.Parse(commandArgs[3]);
            var tyreArgs = commandArgs.Skip(4).ToList();

            Tyre tyre = tyreFactory.CreateTyre(tyreArgs);
            Car car = new Car(hp, fuelAmount, tyre);
            Driver driver = driverFactory.CreateDriver(typeOfDriver, nameOfDriver, car);
            allDrivers.Add(driver);
        }
        catch { }

    }

    public void DriverBoxes(List<string> commandArgs)
    {
        string reasonToBox = commandArgs[0];
        string driversName = commandArgs[1];
        var tyreArgs = commandArgs.Skip(2).ToList();
        var selectedDriver = allDrivers.Where(d => d.Name == driversName).FirstOrDefault();
        selectedDriver.TotalTime += 20;

        switch (reasonToBox)
        {
            case "ChangeTyres":
                Tyre newTyre = tyreFactory.CreateTyre(tyreArgs);
                selectedDriver.Car.ChangeTyres(newTyre);
                break;
            case "Refuel":
                selectedDriver.Car.Refuel(double.Parse(commandArgs[2]));
                break;
        }
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        int lapsToPogressWith = int.Parse(commandArgs[0]);

        if (lapsToPogressWith > this.track.LapsNumber - this.track.CurrentLap)
        {
            try
            {
                throw new ArgumentException($"There is no time! On lap {this.track.CurrentLap}.");
            }
            catch (Exception e)
            {
                return e.Message;
                
            }
            

        }

        for (int i = 0; i < lapsToPogressWith; i++)
        {
            foreach (var driver in allDrivers)
            {
                
                    driver.CompleteLap(this.track.TrackLength);
                
                
                    if (driver.Car.FuelAmount < 0)
                    {
                        allDrivers.Remove(driver);
                        driver.FailureReason = "Out of fuel";
                        failedDrivers.Add(driver);
                    }
                    if (driver.Car.Tyre.Degradation < 30)
                    {
                        if (driver.Car.Tyre.GetType().Name == "Ultrasoft" || driver.Car.Tyre.Degradation < 0)
                        {
                            driver.FailureReason = "Blown Tyre";
                            allDrivers.Remove(allDrivers[i]);
                            failedDrivers.Add(allDrivers[i]);
                            break;
                        }
                    }
                
            }
            Overtake(allDrivers);
            this.track.CurrentLap++;
        }
        var allDriversRacing = allDrivers.OrderBy(d => d.TotalTime).ToList();
        var nonRacingDrivers = failedDrivers.OrderBy(d => d.TotalTime).ToList();
        allDrivers = allDriversRacing;
        failedDrivers = nonRacingDrivers;
        StringBuilder sb = new StringBuilder();

        if (this.track.CurrentLap == this.track.LapsNumber)
        {
            raceIsOver = true;
            sb.AppendLine($"{allDrivers[0].Name} wins the race for {allDrivers[0].TotalTime:F3}");
        }
        else
        {
            sb.AppendLine($"Lap {this.track.CurrentLap}/{this.track.LapsNumber}");
        }

        return sb.ToString().Trim();
    }

    public string GetLeaderboard()
    {
        var sb = new StringBuilder();
        var orderedDrivers = allDrivers.OrderBy(d => d.TotalTime).ToList();
        var notRacingDrivers = failedDrivers.OrderBy(d => d.TotalTime).ToList();

        for (int i = 0; i < allDrivers.Count; i++)
        {
            sb.AppendLine($"{i + 1} {allDrivers[i].Name} {allDrivers[i].TotalTime:F3}");
            if (allDrivers[i].FailureReason != null)
            {
                sb.Append($" / {allDrivers[i].FailureReason}");
            }
        }
        for (int i = 0; i < notRacingDrivers.Count; i++)
        {
            sb.AppendLine($"{orderedDrivers.Count + i + 1} {notRacingDrivers[i].Name} {notRacingDrivers[i].FailureReason}");
        }
        return sb.ToString().Trim();
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        this.weather = commandArgs[0];
    }
    public List<Driver> Overtake(List<Driver> driversRacing)
    {
        for (int i = allDrivers.Count - 1; i >= 1; i--)
        {
            if (allDrivers[i].TotalTime - allDrivers[i - 1].TotalTime <= 2)
            {
                if (allDrivers[i].GetType().Name == "AggressiveDriver" && allDrivers[i].Car.Tyre.GetType().Name == "UltrasoftTyre")
                {
                    if (weather == "Foggy")
                    {
                        allDrivers[i].FailureReason = "Crashed";
                        failedDrivers.Add(allDrivers[i]);
                        allDrivers.Remove(allDrivers[i]);
                    }
                    else
                    {
                        var overtaken = allDrivers[i - 1];
                        allDrivers[i - 1] = allDrivers[i];
                        allDrivers[i] = overtaken;
                        allDrivers[i].TotalTime += 3;
                        allDrivers[i - 1].TotalTime -= 3;
                        
                    }
                }
                else if (allDrivers[i].GetType().Name == "EnduranceDriver" && allDrivers[i].Car.Tyre.GetType().Name == "HardTyre")
                {
                    if (weather == "Rainy")
                    {
                        allDrivers[i].FailureReason = "Crashed";
                        failedDrivers.Add(allDrivers[i]);
                        allDrivers.Remove(allDrivers[i]);
                    }
                    else
                    {
                        var overtaken = allDrivers[i - 1];
                        allDrivers[i - 1] = allDrivers[i];
                        allDrivers[i] = overtaken;
                        allDrivers[i].TotalTime += 3;
                        allDrivers[i - 1].TotalTime -= 3;
                        
                    }
                }
                else if (allDrivers[i].TotalTime - allDrivers[i - 1].TotalTime <= 2)
                {
                    var overtaken = allDrivers[i - 1];
                    allDrivers[i - 1] = allDrivers[i];
                    allDrivers[i] = overtaken;
                    allDrivers[i].TotalTime += 2;
                    allDrivers[i - 1].TotalTime -= 2;
                   
                }
            }
        }
        var driversAfterOvertaking = driversRacing.OrderBy(d => d.TotalTime).ToList();
        return driversAfterOvertaking;
    }
}

