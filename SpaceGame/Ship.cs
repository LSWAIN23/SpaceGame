using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SpaceGame.Planets;


namespace SpaceGame
{
    public enum ShipUpgrade { NoobShip, Stargazer, Velociraptor };

    public class Ship
    {
        public int CargoCapacity { get; set; }
        public int CurrentWarpSpeed { get; set; }
        public IPlanet CurrentPlanet { get; set; }
        public ShipUpgrade Upgrade { get; set; }
        public int MaxWarpSpeed { get; set; }
        public int FuelUnits { get; set; }
        public double MaxLightYears { get; set; }
        public List<Item> ItemsPurchased { get; set; }
        public double TotalTimeTraveled { get; set; }
        public List<Item> CargoList { get; set; }
        public List<Item> ItemsSold { get; set; }
        public Ship(IPlanet planet)
        {
            CargoCapacity = 10;
            CurrentWarpSpeed = 1;
            CurrentPlanet = planet;
            Upgrade = ShipUpgrade.NoobShip;
            MaxWarpSpeed = CalculateMaxWarpSpeed();
            FuelUnits = 10;
            MaxLightYears = CalculateMaxLightYears();
        }

        public int CalculateMaxWarpSpeed()
        {
            switch (Upgrade)
            {
                case ShipUpgrade.NoobShip:
                    return 1;
                case ShipUpgrade.Stargazer:
                    return 2;
                case ShipUpgrade.Velociraptor:
                    return 7;
                default:
                    return 0;
            }
        }

        public double CalculateMaxLightYears()
        {
            return FuelUnits * 10;
        }

        public void SetWarpSpeed(int warpSpeed)
        {
            Console.WriteLine("At what warp speed would you like to travel?");

        }

        public void FlyTo(IPlanet planet)
        {
            if (TotalTimeTraveled >= 40)
            {
                Console.WriteLine("If you travel here, you will lose the game. Travel anyway? (Y/N)");
            }
            int fuelExpended = TravelSystem.CalculateFuel();
            if (fuelExpended >= FuelUnits)
            {
                Console.WriteLine("If you travel here, you will run out of fuel and lose the game. Travel anyway? (Y/N)");
            }

            CurrentPlanet = planet;
            Console.WriteLine("Traveling...");
            Console.WriteLine($"You have now arrived at: {CurrentPlanet.GetPlanetName()}");
            FuelUnits -= fuelExpended;
        }

        public void AddItemPurchased(Item item)
        {
            ItemsPurchased.Add(item);
            CargoCapacity -= item.CargoUnits;
        }
        public void DeleteItemSold(Item item)
        {
            ItemsSold.Remove(item);
            CargoCapacity += item.CargoUnits;
        }
    }
}

  