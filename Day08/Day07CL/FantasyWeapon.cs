using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class FantasyWeapon
    {
        public WeaponRarity Rarity { get; set; }
        public int Level { get; set; }
        public int MaxDamage { get; set; }
        public int Cost { get; set; }

        public int DoDamage()
        {
            Random rando = new Random();
            return (int)(MaxDamage * rando.NextDouble());
        }

        public FantasyWeapon(WeaponRarity rarity, int maxDamage, int level, int cost)
        {
            Rarity = rarity;
            MaxDamage = maxDamage;
            Level = level;
            Cost = cost;
        }

        public virtual void Display()
        {
            Console.Write("-----------Fantasy Weapon: ");
            Console.WriteLine($"Rarity: {Rarity} Max Damage: {MaxDamage} Level: {Level} Cost: {Cost}");

        }
    }
}
