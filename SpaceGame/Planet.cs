/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class Planet
    {
        public string Name { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Item> ItemList { get; set; }

        public Planet(PlanetName planetName)
        {
            Name = GetPlanetName(planetName);
            ItemList = GenerateItems(planetName);
            Coordinates = GetCoordinates(planetName);
        }

        public string GetPlanetName(PlanetName planetName)
        {
            switch (planetName)
            {
                case PlanetName.Earth:
                    return "Earth";
                case PlanetName.AlphaCentauri:
                    return "Alpha Centauri";
                case PlanetName.Barrie:
                    return "Barrie";
                case PlanetName.M63:
                    return "M63";
                case PlanetName.NewfoundAlien:
                    return "Newfound Alien";
                case PlanetName.Pluto:
                    return "Pluto";
                case PlanetName.Kelt:
                    return "Kelt";
                case PlanetName.StarGaze:
                    return "Star Gaze";
                default:
                    return "";
            }
        }


        private List<Item> GenerateItems(PlanetName planetName)
        {
            switch (planetName)
            {
                case PlanetName.Earth:
                    return new List<Item>
                    {
                        new Item("Rocks", 100, 1, 100),
                        new Item("Diamonds", 200, 1, 200)
                    };
                case PlanetName.AlphaCentauri:
                    return new List<Item>
                    {
                        new Item("Orbs", 150, 1, 150),
                        new Item("Plasma", 300, 1, 300)
                    };
                case PlanetName.Barrie:
                    return new List<Item>
                    {
                        new Item("Metal", 500, 1, 500),
                        new Item("Ions", 1000, 1, 1000)
                    };
                case PlanetName.M63:
                    return new List<Item>
                    {
                        new Item("Dark Matter", 700, 1, 700),
                        new Item("Laser Rifles", 1500, 1, 1500)
                    };
                case PlanetName.NewfoundAlien:
                    return new List<Item>
                    {
                        new Item("Space Flower", 2000, 1, 2000),
                        new Item("Space Beer", 2500, 1, 2500)
                    };
                case PlanetName.Pluto:
                    return new List<Item>
                    {
                        new Item("Alien Robot", 1200, 1, 1200),
                        new Item("Plutonium", 2500, 1, 2500)
                    };
                case PlanetName.Kelt:
                    return new List<Item>
                    {
                        new Item("One Mans Trash", 1500, 1, 1500),
                        new Item("Malten Lava Droplet", 2800, 1, 2800)
                    };
                case PlanetName.StarGaze:
                    return new List<Item>
                    {
                        new Item("Medeorite Dust", 2000, 1, 2000),
                        new Item("Starlight Elixer", 4000, 1, 4000)
                    };
                default:
                    return null;
            };
         
        }
        
        private Coordinate GetCoordinates(PlanetName planetName)
        {
            switch (planetName)
            {
                case PlanetName.Earth:
                    return new Coordinate(0, 0);
                case PlanetName.AlphaCentauri:
                    return new Coordinate(0, -4.367);
                case PlanetName.Barrie:
                    return new Coordinate(-4.6, 5);
                case PlanetName.M63:
                    return new Coordinate(1657, 1745);
                case PlanetName.NewfoundAlien:
                    return new Coordinate(2787, -2500);
                case PlanetName.Pluto:
                    return new Coordinate(-100, 180);
                case PlanetName.Kelt:
                    return new Coordinate(-623, 841);
                case PlanetName.StarGaze:
                    return new Coordinate(1087, -412);
                default:
                    return new Coordinate(-1,-1);
            }
        }
    }
}

*/