using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Planets
{
    public class AlphaCentauri : IPlanet
    {
        public PlanetName Name { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Item> ItemList { get; set; }

        public string GetPlanetName()
        {
            return nameof(Name);
        }

        public AlphaCentauri()
        {
            Name = PlanetName.AlphaCentauri;
            Coordinates = new Coordinate(0, -4.367);
            ItemList = GenerateItems();
        }

        public List<Item> GenerateItems()
        {
            return new List<Item>
            {
                new Item("Orbs", 150, 1, 150),
                new Item("Plasma", 300, 1, 300)
            };
        }
    }
}
