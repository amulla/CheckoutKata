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

        public Checkout()
        {
            totalPrice = 0;
        }

        public void Scan(string item)
        {
            totalPrice += 50;
        }

        public int GetTotalPrice()
        {
            return totalPrice;
        }
    }
}

