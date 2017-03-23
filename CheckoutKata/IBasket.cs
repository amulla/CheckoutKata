using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public interface IBasket
    {
        void AddItem(string item);
        int GetQuantity(string item);
    }
}
