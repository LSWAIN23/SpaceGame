using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Planets
{
    public class Earth : IPlanet
    {
        public PlanetName Name { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Item> ItemList { get; set; }

        public string GetPlanetName()
        {
            return nameof(Name);
        }

        public Earth()
        {
            Name = PlanetName.Earth;
            Coordinates = new Coordinate(0, 0);
            ItemList = GenerateItems();
        }

        public List<Item> GenerateItems()
        {
            return new List<Item>
            {
                new Item("Rocks", 100, 1, 100),
                new Item("Diamonds", 200, 1, 200)
            };
        }
    }
}
