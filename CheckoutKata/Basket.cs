using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Basket : IBasket
    {
        private Dictionary<string, int> Items;

        public Basket()
        {
            Items = new Dictionary<string, int>();
        }

        public void AddItem(string item)
        {
            if (Items.ContainsKey(item))
            {
                Items[item] += 1;
            }
            else
            {
                Items.Add(item, 1);
            }
        }

        public int GetQuantity(string item)
        {
            return Items[item];
        }
    }
}
