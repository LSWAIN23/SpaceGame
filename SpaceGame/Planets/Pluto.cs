using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Planets
{
    public class Pluto : IPlanet
    {
        public PlanetName Name { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Item> ItemList { get; set; }

        public string GetPlanetName()
        {
            return nameof(Name);
        }

        public Pluto()
        {
            Name = PlanetName.Pluto;
            Coordinates = new Coordinate(-100, 180);
            ItemList = GenerateItems();
        }

        public List<Item> GenerateItems()
        {
            return new List<Item>
            {
                new Item("Alien Robot", 1200, 1, 1200),
                new Item("Plutonium", 2500, 1, 2500)
            };
        }
    }
}
