using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Car
    {
        //access modifiers:
        // who can see it
        // public: anyone can see it
        // private: ONLY this class can see it
        // protected: this class and derived classes can see

        #region Fields

        // m_fMilesPerGallon or m_milesPerGallon mMilesPerGallon 
        private float _milesPerGallon;
        private static int _numberOfCarsBuilt = 0;
        #endregion

        #region Properties

        //a FULL property (has a backing field)
        public float MilesPerGallon
        {
            //get - accessor (get the data)
            //same as public float GetMilesPerGallon() { return _milesPerGallon;}
            get
            {
                return _milesPerGallon;
            }

            //set - mutator (set the data)
            //same as public void SetMilesPerGallon(float value) { _milesPerGallon = value;}
            set
            {
                if (value > 1 && value < 40)
                    _milesPerGallon = value;//value is a hidden parameter to set
            }
        }

        //an AUTO property (compiler manages the field for you)
        public int HorsePower { get; private set; }//the compiler will give you the field and code for the get;set;

        #endregion

        #region Constructors
        public Car(float mpg, int hp)
        {
            Console.WriteLine("Car Constructor");
            MilesPerGallon = mpg;
            HorsePower = hp;
            _numberOfCarsBuilt++;
        }
        #endregion

        public static void ModelDetails() //there is NO this parameter
        {
            Console.WriteLine($"Number of cars: {_numberOfCarsBuilt}");
        }

        //instance method
        //hidden parameter: this. the instance the method is called on
        //batmobile.CarDetails() this = batmobile
        public virtual void CarDetails() 
        {
            Console.WriteLine("-----------CAR DETAILS--------------");
            Console.WriteLine($"MPG: {this.MilesPerGallon}\tHorse Power: {HorsePower}");
        }
        void DoIt(int number)
        {
            float milesPerGallon = 12F;
            _milesPerGallon = milesPerGallon;
        }
    }
}
