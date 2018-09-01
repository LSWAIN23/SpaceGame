using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Planets
{
    public class NewfoundAlien : IPlanet
    {
        public PlanetName Name { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Item> ItemList { get; set; }

        public string GetPlanetName()
        {
            return nameof(Name);
        }

        public NewfoundAlien()
        {
            Name = PlanetName.NewfoundAlien;
            Coordinates = new Coordinate(2787, -2500);
            ItemList = GenerateItems();
        }

        public List<Item> GenerateItems()
        {
            return new List<Item>
            {
                new Item("Space Flower", 2000, 1, 2000),
                new Item("Space Beer", 2500, 1, 2500)
            };
        }
    }
}
