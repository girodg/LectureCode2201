using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarTest()
        {
            int mpg = 15, hp = 200;
            Car testCar = new Car(mpg, hp);

            Assert.AreEqual(mpg, testCar.MilesPerGallon);
            Assert.AreEqual(hp, testCar.HorsePower);
        }
    }
}