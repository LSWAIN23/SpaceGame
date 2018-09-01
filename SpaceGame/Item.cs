using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int CargoUnits { get; set; }
        public int SellValue { get; set; }

        public Item(string itemName, int itemPrice, int cargoUnits, int sellValue)
        {
            Name = itemName;
            Price = itemPrice;
            CargoUnits = cargoUnits;
            SellValue = sellValue;
        }
    }
}

