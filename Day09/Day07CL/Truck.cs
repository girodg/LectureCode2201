using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Truck : Car //bringing EVERYTHING from Car into Truck
    {
        public int Towing { get; set; }
        public Truck(int towing, float mpg, int hp) : base(mpg, hp)
        {
            Console.WriteLine("\tTruck Constructor");
            Towing = towing;
        }

        public override void CarDetails()
        {
            base.CarDetails();//extending the base method
            Console.WriteLine($"\tTowing: {Towing}");
        }
    }
}
