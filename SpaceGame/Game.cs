
using SpaceGame.Planets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class Game
    {
        private readonly int _yearsLeft;
        public int TotalMoney { get; set; }
        public double TotalTimeTraveled { get; set; }
        public List<IPlanet> Planets { get; set; }
        public Ship GameShip { get; set; }

        public Game()
        {
            _yearsLeft = 40;
            TotalMoney = 5000;
            TotalTimeTraveled = 0;
            Planets = GeneratePlanets();
            GameShip = new Ship(GetPlanet(PlanetName.Earth));
        }
        
        private List<IPlanet> GeneratePlanets()
        {
            return new List<IPlanet>()
            {
                new Earth(),
                new AlphaCentauri(),
                new Barrie(),
                new M63(),
                new NewfoundAlien(),
                new Pluto(),
                new Kelt(),
                new StarGaze()
            };
        }

        public IPlanet GetPlanet(PlanetName name)
        {
            foreach(IPlanet p in Planets)
            {
                if (p.Name == name)
                {
                    return p;
                }
            }
            return null;
        }

        public IPlanet GetPlanet(string planetName)
        {
            foreach(IPlanet planet in Planets)
            {
                if (planet.GetPlanetName().ToUpper() == planetName.ToUpper())
                    return planet;
            }
            return null;
        }

        private bool IsGameLost()
        {
            if (TotalMoney <= 0)
            {
                Console.WriteLine("\nYou have lost the game.");
                return true;
            }
            if (TotalTimeTraveled >= _yearsLeft)
            {
                Console.WriteLine("\nYou have lost the game.");
                return true;
            }
            return false;
        }

        public void Start()
        {
            DisplayIntroMenu();
            while (!IsGameLost())
            {
                ActionsMenu();
            }
        }

        public void DisplayIntroMenu()
        {
            StringBuilder menu = new StringBuilder();
            menu.AppendLine("(You may press Ctrl+C at any time to exit the game)\n");
            menu.AppendLine("*****Welcome to SpaceGame!*****\n");
            menu.AppendLine("You own a basic ship and have the following stats:");
            menu.AppendLine(BuildStatsMenu());
            menu.AppendLine();
            menu.AppendLine("In this game you control a ship. You have the option to:");
            menu.AppendLine("1.) Buy - items from planets");
            menu.AppendLine("2.) Sell - items you hold to any planet");
            menu.AppendLine("3.) Travel - to and from planets");
            menu.AppendLine();
            menu.AppendLine("The game is lost when you run out of money or exceed 40 years of travel.");
            menu.AppendLine("HAVE FUN!\n");
            menu.AppendLine("Press any key to enter the game...");
            Console.WriteLine(menu.ToString());
            Console.ReadKey();
            Console.Clear();
        }

        public string BuildStatsMenu()
        {
            StringBuilder menu = new StringBuilder();
            menu.AppendLine();
            menu.AppendLine("+-----------------------------------+");
            menu.AppendLine($"| Ship Cargo Capacity: {GameShip.CargoCapacity}");
            menu.AppendLine($"| Current Planet: {GameShip.CurrentPlanet.Name}");
            menu.AppendLine($"| Total Money: {TotalMoney}");
            menu.AppendLine($"| Total Time Traveled: {TotalTimeTraveled}");
            menu.AppendLine("+-----------------------------------+");
            return menu.ToString();
        }

        public void DisplayStatsMenu()
        {
            Console.WriteLine(BuildStatsMenu());
        }

        public void DisplayActionsMenu()
        {
            string menu = BuildActionsMenu();
            Console.Write(menu);
        }

        private string BuildActionsMenu()
        {
            StringBuilder actionsMenu = new StringBuilder();
            actionsMenu.AppendLine();
            actionsMenu.AppendLine($"You are currently on planet {GameShip.CurrentPlanet.Name}");
            actionsMenu.AppendLine();
            actionsMenu.AppendLine("Choose from one of the following actions: ");
            actionsMenu.AppendLine("1.) Buy 2.) Sell 3.) Travel");
            actionsMenu.Append("\nAction: ");
            return actionsMenu.ToString();
        }

        private bool IsValidAction(string action)
        {
            if (action == "BUY" || action == "SELL" || action == "TRAVEL")
                return true;

            return false;
        }

        private void ActionsMenu()
        {
            string userAction = "";

            do
            {
                DisplayActionsMenu();
                userAction = Console.ReadLine().Trim().ToUpper();
            } while (!IsValidAction(userAction));

            ProcessUserAction(userAction);
        }

        private void ProcessUserAction(string action)
        {
            if (action == "BUY")
                ShopMenu();
            else if (action == "SELL")
                SellMenu();
            else if (action == "TRAVEL")
                TravelMenu();
        }

        private void SellMenu()
        {
            string userSelection = "";
            do
            {
                DisplaySellMenu();
                userSelection = Console.ReadLine().Trim().ToUpper();
            } while (!IsValidItem(userSelection));


            Item itemSelected = GameShip.CurrentPlanet.CargoList.Where(x => x.Name.ToUpper() == userSelection.ToUpper()).FirstOrDefault();
            TotalMoney -= itemSelected.SellValue;
            Console.WriteLine($"\nYou've sold {itemSelected.Name}");
            Console.WriteLine($"You now have {TotalMoney} left.\n");
        }

        public void DisplaySellMenu()
        {
            StringBuilder sell = new StringBuilder();
            sell.AppendLine();
            sell.AppendLine($"Welcome to {GameShip.CurrentPlanet.Name}\'s Cargo! Please select an item you would like to sell:\n");
            sell.AppendLine(BuildSellMenu());
            sell.Append("\nSelection: ");
            Console.Write(sell.ToString());
        }

        private string BuildSellMenu()
        {
            StringBuilder sellMenu = new StringBuilder();
            int itemNumber = 1;
            sellMenu.AppendLine("+---------------------------------------------+");
            sellMenu.AppendLine("\tName          Value          Weight(CargoUnits)");
            sellMenu.AppendLine("+---------------------------------------------+");
            foreach (Item item in GameShip.CurrentPlanet.CargoList)
            {
                sellMenu.Append(itemNumber + ".)\t");
                sellMenu.Append(item.Name);
                sellMenu.Append("          ");
                sellMenu.Append(item.SellValue);
                sellMenu.Append("          ");
                sellMenu.Append(item.CargoUnits);
                sellMenu.AppendLine();
                --itemNumber;
            }
            sellMenu.AppendLine("+---------------------------------------------+");
            return sellMenu.ToString();
        }

        private void ShopMenu()
        {
            string userSelection = "";
            do
            {
                DisplayShopMenu();
                userSelection = Console.ReadLine().Trim().ToUpper();
            } while (!IsValidItem(userSelection));

            Item itemSelected = GameShip.CurrentPlanet.ItemList.Where(x => x.Name.ToUpper() == userSelection.ToUpper()).FirstOrDefault();
            TotalMoney -= itemSelected.Price;
            Console.WriteLine($"\nYou've purchased {itemSelected.Name}");
            Console.WriteLine($"You now have {TotalMoney} left.\n");
        }

        public void DisplayShopMenu()
        {
            StringBuilder buy = new StringBuilder();
            buy.AppendLine();
            buy.AppendLine($"Welcome to {GameShip.CurrentPlanet.Name}\'s Shop! Please select an item you would like to buy:\n");
            buy.AppendLine(BuildItemMenu());
            buy.Append("\nSelection: ");
            Console.Write(buy.ToString());
        }

        private string BuildItemMenu()
        {
            StringBuilder itemMenu = new StringBuilder();
            int itemNumber = 1;
            itemMenu.AppendLine("+---------------------------------------------+");
            itemMenu.AppendLine("\tName          Price          Weight(CargoUnits)");
            itemMenu.AppendLine("+---------------------------------------------+");
            foreach (Item item in GameShip.CurrentPlanet.ItemList)
            {
                itemMenu.Append(itemNumber + ".)\t");
                itemMenu.Append(item.Name);
                itemMenu.Append("          ");
                itemMenu.Append(item.Price);
                itemMenu.Append("          ");
                itemMenu.Append(item.CargoUnits);
                itemMenu.AppendLine();
                ++itemNumber;
            }
            itemMenu.AppendLine("+---------------------------------------------+");
            return itemMenu.ToString();
        }

        private bool IsValidItem(string itemName)
        {
            foreach (Item item in GameShip.CurrentPlanet.ItemList)
            {
                if (itemName.ToUpper() == item.Name.ToUpper())
                    return true;
            }

            Console.WriteLine("Your selection was invalid! Please try another selection");
            return false;
        }

        public void TravelMenu()
        {
            string userSelection = "";
            do
            {
                DisplayTravelMenu();
                userSelection = Console.ReadLine();
            } while (!IsValidPlanet(userSelection));

            GameShip.FlyTo(GetPlanet(userSelection));
            double __yearsLeft = (_yearsLeft - TotalTimeTraveled);
            Console.WriteLine(_yearsLeft);
        }
        
        private void DisplayTravelMenu()
        {
            Console.WriteLine(BuildTravelMenu());
        }
        
        private string BuildTravelMenu()
        {
            StringBuilder menuBuilder = new StringBuilder();      
            string planetList = BuildPlanetsList();
            menuBuilder.AppendLine("Please select a planet to travel to:");
            menuBuilder.AppendLine(planetList); 
            menuBuilder.Append("Type name: ");
            return menuBuilder.ToString();
        }

        private string BuildPlanetsList()
        {
            StringBuilder planetList = new StringBuilder();
            int menuNumber = 1;

            foreach(IPlanet planet in Planets)
            {
                planetList.Append(menuNumber + ".) ");
                planetList.AppendLine(planet.GetPlanetName());
                menuNumber++;
            }

            return planetList.ToString().TrimEnd();
        }

        private bool IsValidPlanet(string planetName)
        {
            foreach(IPlanet p in Planets)
            {
                if (planetName.ToUpper() == p.GetPlanetName().ToUpper())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
