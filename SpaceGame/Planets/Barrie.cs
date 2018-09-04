using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Planets
{
    public class Barrie : IPlanet
    {
        public PlanetName Name { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Item> ItemList { get; set; }
        public List<Item> CargoList { get; set; }

        public string GetPlanetName()
        {
            return "Barrie";
        }

        public Barrie()
        {
            Name = PlanetName.Barrie;
            Coordinates = new Coordinate(-4.6, 5);
            ItemList = GenerateItems();
        }

        public List<Item> GenerateItems()
        {
            return new List<Item>
            {
                new Item("Metal", 500, 1, 500),
                new Item("Ions", 1000, 1, 1000)
            };
        }
    }
}
