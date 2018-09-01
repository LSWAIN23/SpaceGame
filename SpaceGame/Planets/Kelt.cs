using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Planets
{
    public class Kelt : IPlanet
    {
        public PlanetName Name { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Item> ItemList { get; set; }

        public string GetPlanetName()
        {
            return nameof(Name);
        }

        public Kelt()
        {
            Name = PlanetName.Kelt;
            Coordinates = new Coordinate(-623, 841);
            ItemList = GenerateItems();
        }

        public List<Item> GenerateItems()
        {
            return new List<Item>
            {
                new Item("One Mans Trash", 1500, 1, 1500),
                new Item("Malten Lava Droplet", 2800, 1, 2800)
            };
        }
    }
}
