using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            Car batmobile = new Car(8F, 1000);
            //batmobile.MilesPerGallon = 8F; //calling the set passing 8 as the value
            Console.WriteLine(batmobile.MilesPerGallon); //calling the get

            int number = 5;
            Console.WriteLine(number);

            Car herbie = new Car(12F, 50);//a constructor
            //herbie.MilesPerGallon = 12F;

            Car.ModelDetails();
            batmobile.CarDetails();
            herbie.CarDetails();

            List<string> items = new List<string>()
            {
                "sword",
                "invisibility potion",
                "shield"
            };
            Inventory backpack = new Inventory(15, items);

            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 200, 50, 100000);
            int damage = sting.DoDamage();
            Console.WriteLine($"Damage: {damage}");

            Truck ranger = new Truck(10, 300);
        }

        void DoSomething(WinLoss winLoss)
        {
            switch (winLoss)
            {
                case WinLoss.Won:
                    break;
                case WinLoss.Lost:
                    break;
                case WinLoss.Tied:
                    break;
                default:
                    break;
            }
        }
    }
}
