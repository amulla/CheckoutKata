using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Basket : IBasket
    {

        public Basket()
        {
        }

        public void AddItem(string item)
        {
            // Not sure how to implement this yet
        }

        public int GetQuantity(string item)
        {
            return 1;
        }
    }
}
