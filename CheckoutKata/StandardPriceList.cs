﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class StandardPriceList : IPriceList
    {
        private List<Price> prices;

        public StandardPriceList()
        {
            prices = new List<Price>();

            prices.Add(new Price() { item = "A", quantity = 1, price = 50 });
            prices.Add(new Price() { item = "A", quantity = 3, price = 130 });
            prices.Add(new Price() { item = "B", quantity = 1, price = 30 });
            prices.Add(new Price() { item = "B", quantity = 2, price = 45 });
            prices.Add(new Price() { item = "C", quantity = 1, price = 20 });
            prices.Add(new Price() { item = "D", quantity = 1, price = 15 });

        }

        public int GetPrice(string item, int quantity)
        {
            int priceFor1 = prices.Find(p => p.item == item && p.quantity == 1).price;

            for (int i = quantity; i >=1; i--)
            {
                Price price = prices.Find(p => p.item == item && p.quantity == i);
                if (price != null)
                {
                    return price.price + (priceFor1 * (quantity- i));
                }
            }

            return priceFor1;
        }
    }
}
