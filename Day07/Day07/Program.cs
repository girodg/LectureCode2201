using Day07CL;
using System;

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
        }
    }
}
