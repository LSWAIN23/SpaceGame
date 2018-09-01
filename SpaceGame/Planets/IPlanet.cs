using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Planets
{
    public enum PlanetName { Earth, AlphaCentauri, Barrie, M63, NewfoundAlien, Pluto, Kelt, StarGaze };

    public interface IPlanet
    {
        PlanetName Name { get; set; }
        Coordinate Coordinates { get; set; }
        List<Item> ItemList { get; set; }
        List<Item> GenerateItems();
        string GetPlanetName();
    }
}
