
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
            TotalMoney = 1000;
            TotalTimeTraveled = 0;
            Planets = GeneratePlanets();
            GameShip = new Ship(ShipUpgrade.NoobShip);
            Ship = GetPlanet(PlanetName.Earth);
        }

        public IPlanet GetPlanet(PlanetName name)
        {
            if()
            {
                return Name;
            }
        }

        private bool IsGameLost()
        {
            if (TotalMoney <= 0) return true;
            if (TotalTimeTraveled >= _yearsLeft) return true;
            return false;
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

        public void Start()
        {
            DisplayIntroMenu();
            while (!IsGameLost())
            {
                ActionsMenu();
                break;
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
                return; // SellMenu();
            else if (action == "TRAVEL")
                TravelMenu();
        }

        private void ShopMenu()
        {
            string userSelection = "";
            do
            {
                DisplayShopMenu();
                userSelection = Console.ReadLine().Trim().ToUpper();
            } while (!IsValidItem(userSelection));
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
                if (itemName.ToUpper() == item.Name)
                    return true;
            }

            Console.WriteLine("Your selection was invalid! Please try another selection");
            return false;
        }

        public void TravelMenu()
        {
            do
            {
                DisplayTravelMenu();
            } while (!IsValidPlanet(userSelection));
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
                planetList.AppendLine();
                menuNumber++;
            }

            return planetList.ToString().TrimEnd();
        }

        private bool IsValidPlanet(string PlanetName)
        {
            foreach(IPlanet planet in Planets)
            {
                if (PlanetName.ToUpper() == PlanetName)
                {
                    return true;
                }
            }
            return false;
        }

        private IPlanet GetPlanet(string PlanetName)
        {
            foreach(IPlanet planet in Planets)
            {
                if(PlanetName.ToUpper() == PlanetName)
                {
                    return planet;
                }
            }
            return null;
        }

    }
}
