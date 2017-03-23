using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class StandardPriceList : IPriceList
    {
        public int GetPrice(string item, int quantity)
        {
            return 50 * quantity;
        }
    }
}
