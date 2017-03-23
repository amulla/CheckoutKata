using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Basket : IBasket
    {
        private List<BasketItem> basketItems;

        public Basket()
        {
            basketItems = new List<BasketItem>();
        }

        public void AddItem(string item)
        {
            var basketItem = basketItems.FirstOrDefault(b => b.item == item);
            if (basketItem == null)
            {
                basketItems.Add(new BasketItem() { item = item, quantity = 1 });
            }
            else
            {
                basketItem.quantity += 1;
            }
        }

        public int GetQuantity(string item)
        {
            int quantity = 0;

            var basketItem = basketItems.FirstOrDefault(b => b.item == item);
            if (basketItem != null)
            {
                quantity = basketItem.quantity;
            }
            return quantity;
        }
    }
}
