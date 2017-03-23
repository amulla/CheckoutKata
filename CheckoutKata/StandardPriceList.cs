using System;
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
        }

        public int GetPrice(string item, int quantity)
        {
            Price price = prices.Find(p => p.item == item && p.quantity == quantity);

            if (price != null)
            {
                return price.price;
            }
            else
            {
                return prices.Find(p => p.item == item && p.quantity == 1).price * quantity;
            }
        }
    }
}
