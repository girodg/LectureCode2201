using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Factory
    {
        public static Car CreateCar(float mpg, int hp)
        {
            Car newCar = new Car(mpg, hp);
            return newCar;
        }

        public static FantasyWeapon FantasyWeapon(WeaponRarity rarity, int maxDamage, int level, int cost)
        {
            return new FantasyWeapon(rarity, maxDamage, level, cost);
        }
    }
}
