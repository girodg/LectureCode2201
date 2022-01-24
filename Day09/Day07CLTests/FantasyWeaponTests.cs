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
    public class FantasyWeaponTests
    {
        [TestMethod()]
        public void FantasyWeaponTest()
        {
            FantasyWeapon fw = new FantasyWeapon(WeaponRarity.Legendary, 100, 10, 1000);
            Assert.AreEqual(WeaponRarity.Legendary, fw.Rarity);
            Assert.AreEqual(100, fw.MaxDamage);
            Assert.AreEqual(10, fw.Level);
            Assert.AreEqual(1000, fw.Cost);
        }

        [TestMethod()]
        public void DoDamageTest()
        {
            FantasyWeapon fw = new FantasyWeapon(WeaponRarity.Legendary, 100, 10, 1000);

            int damage = fw.DoDamage();
            Assert.IsTrue(damage > 0 && damage < 100);
        }
    }
}