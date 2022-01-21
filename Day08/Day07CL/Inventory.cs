using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Inventory
    {
        private int _capacity;
        private List<FantasyWeapon> _items;

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value >= 0) _capacity = value;
            }
        }
        public int Count
        {
            get { return _items.Count; }
        }

        public List<FantasyWeapon> Items
        {
            get { return _items; }
            private set { _items = value; }
        }

        public Inventory(int capacity, List<FantasyWeapon> items)
        {
            Capacity = capacity;
            Items = items.ToList();//clone the list
        }

        public void AddItem(FantasyWeapon itemToAdd)
        {
            if (Count == Capacity)
                throw new Exception("Your backpack is full!");

            _items.Add(itemToAdd);
        }
    }
}
