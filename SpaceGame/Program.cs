using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
            //int total = 10000;
            //string planet = "earth";
            //for (; total > 0;)

            //{
            //    string thing1 = "rock";
            //    string thing2 = "diamond";
            //    int itemAmount;
            //    Console.WriteLine($"Amount of Money: {total}");
            //    Console.WriteLine($"Current Planet:{planet}");
            //    Console.WriteLine($"You have a {vehicle.shiptype} that goes warp speed {vehicle.warpspeed} with a cargo space of {vehicle.cargo}");
            //    Console.WriteLine("Buy, Sell, Travel: ");

            //    string travel = (Console.ReadLine());

            //    switch (travel)
            //    {
            //        case "travel":
            //            Console.WriteLine($"What planet would you like to travel to: Earth, Alpha Centauri, Barrie, M63, Newfound Alien");
            //            bool isGood = false;
            //            int one = int.Parse(Console.ReadLine());

            //            {
            //                try
            //                {

            //                    if (one < 1 || one > 5)
            //                    {
            //                        Console.WriteLine("Invalid input.");
            //                        isGood = false;
            //                    }
            //                    else
            //                    {
            //                        isGood = true;
            //                    }
            //                }
            //                catch
            //                {
            //                    Console.WriteLine("Invalid input.");
            //                }

            //            } while (!(isGood)) ;

            //            switch (one)
            //            {
            //                case 1:
            //                    Console.WriteLine("Earth");
            //                    planet = "Earth";

            //                    break;
            //                case 2:
            //                    Console.WriteLine("Alpha Centauri");
            //                    planet = "Alpha Centauri";
            //                    break;
            //                case 3:
            //                    Console.WriteLine("M63");
            //                    planet = "M63";
            //                    break;
            //                case 4:
            //                    Console.WriteLine("Barrie");
            //                    planet = "Barrie";
            //                    break;
            //                case 5:
            //                    Console.WriteLine("Newfound Alien");
            //                    planet = "Newfound Alien";
            //                    break;
            //                default:
            //                    Console.WriteLine("ou're lost");
            //                    break;
            //            }
            //            break;

            //        case "sell":
            //            Console.WriteLine("What do you want to sell?");

            //            break;

            //        case "buy":
            //            Console.WriteLine("What do you want to buy: Ship Upgrades or Items");
            //            string choice = Console.ReadLine();
            //            while (choice == "ship upgrades")
            //            {
            //                Console.WriteLine("ship upgrades: fastship, fastership:");
            //                string ship = Console.ReadLine();

            //                switch (ship)
            //                {
            //                    case "fastship":
            //                        Console.WriteLine("You have bought fastship");
            //                        vehicle.warpspeed = 2;
            //                        vehicle.shiptype = "fast";
            //                        vehicle.cargo = 20;
            //                        total = total - 5000;

            //                        break;

            //                    case "fastership":
            //                        Console.WriteLine("You have bought faster ship");
            //                        vehicle.warpspeed = 7;
            //                        vehicle.shiptype = "faster";
            //                        vehicle.cargo = 30;
            //                        total = total - 10000;
            //                        break;
            //                }
            //                break;
            //            }

            //            while (choice == "items")
            //            {
            //                Console.WriteLine($"What item do you want to buy: 1={thing1}, 2={thing2}:");
            //                string items = Console.ReadLine();
            //                switch (items)
            //                {
            //                    case "1":
            //                        Console.WriteLine($"bought {thing1}");
            //                        total = total - 100;
            //                        break;
            //                    case "2":
            //                        Console.WriteLine($"bought {thing2}");
            //                        total = total - 200;
            //                        break;
            //                }
            //                break;
            //            }
            //            break;
            //    }
            //}
            //if (total > 0)
            //{

            //}
            //Console.WriteLine("You lost");
        }
    }
}
    

