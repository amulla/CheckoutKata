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
        private IPriceList standardPriceList;

        public Checkout(IBasket _basket, IPriceList _standardPriceList)
        {
            totalPrice = 0;
            basket = _basket;
            standardPriceList = _standardPriceList;
        }

        public void Scan(string item)
        {
            basket.AddItem(item);
        }

        public int GetTotalPrice()
        {
            totalPrice = 0;

            foreach (var basketItem in basket.GetBasketItems())
            {
                totalPrice += standardPriceList.GetPrice(basketItem.item, basketItem.quantity);
            }

            return totalPrice;
        }
    }
}

