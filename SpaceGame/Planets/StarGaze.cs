using System.Collections.Generic;
using SpaceGame.Planets;

namespace SpaceGame
{
    public class StarGaze : IPlanet
    {
        public PlanetName Name { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Item> ItemList { get; set; }
        public List<Item> CargoList { get; set; }

        public string GetPlanetName()
        {
            return "Star Gaze";
        }

        public StarGaze()
        {
            Name = PlanetName.StarGaze;
            Coordinates = new Coordinate(1087, -412);
            ItemList = GenerateItems();
        }

        public List<Item> GenerateItems()
        {
            return new List<Item>
            {
                new Item("Medeorite Dust", 2000, 1, 2000),
                new Item("Starlight Elixer", 4000, 1, 4000)
            };
        }
    }
}