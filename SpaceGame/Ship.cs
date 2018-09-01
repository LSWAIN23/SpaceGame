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

        public Ship(IPlanet defaultPlanet)
        {
            CurrentPlanet = defaultPlanet;
        }

        public Ship(ShipUpgrade upgrade)
        {
            CargoCapacity = 10;
            CurrentWarpSpeed = 1;
           // CurrentPlanet = defaultPlanet;d
            Upgrade = upgrade;
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
            CurrentPlanet = planet;
            Console.WriteLine("Traveling...");
            Console.WriteLine($"You have now arrived at: {CurrentPlanet}");
        }
    }
}
