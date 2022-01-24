using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Extensions
    {
        public static int Value(this WeaponRarity rarity)
        {
            return (int)rarity;
        }
    }
}
