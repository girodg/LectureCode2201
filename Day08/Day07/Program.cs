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

            List<FantasyWeapon> items = new List<FantasyWeapon>()
            {
                new FantasyWeapon(WeaponRarity.Common, 100, 1, 10),
                new FantasyWeapon(WeaponRarity.Legendary, 1000, 100, 100000)
            };

            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 200, 50, 100000);
            int damage = sting.DoDamage();
            Console.WriteLine($"Damage: {damage}");
            items.Add(sting);
            items.Add(new BowWeapon(10, 5, WeaponRarity.Rare, 50, 5, 1000));
            Inventory backpack = new Inventory(15, items);

            Truck ranger = new Truck(7000, 10, 300);
            Car myRide = ranger;
            myRide = batmobile;
            try
            {
                Truck otherRide = (Truck)myRide;//will cause an exception if myRide is NOT a Truck

            }
            catch (Exception)
            {
            }

            //if myRide is NOT a truck, it will assign NULL to truck
            //will not throw exception
            Truck truck = myRide as Truck;
            if(truck != null)
                Console.WriteLine(truck.Towing);

            //pattern matching
            if(myRide is Truck trucky)
            {
                Console.WriteLine(trucky.Towing);
            }
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
