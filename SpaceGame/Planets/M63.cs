using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Planets
{
    public class M63 : IPlanet
    {
        public PlanetName Name { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Item> ItemList { get; set; }

        public string GetPlanetName()
        {
            return nameof(Name);
        }

        public M63()
        {
            Name = PlanetName.M63;
            Coordinates = new Coordinate(1657, 1745);
            ItemList = GenerateItems();
        }

        public List<Item> GenerateItems()
        {
            return new List<Item>
            {
                new Item("Dark Matter", 700, 1, 700),
                new Item("Laser Rifles", 1500, 1, 1500)
            };
        }
    }
}
