using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        private int totalPrice;
        private IBasket basket;

        public Checkout(IBasket _basket)
        {
            totalPrice = 0;
            basket = _basket;
        }

        public void Scan(string item)
        {
            basket.AddItem(item);
        }

        public int GetTotalPrice()
        {
            return totalPrice;
        }
    }
}

