using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public interface IPriceList
    {
        int GetPrice(string item, int quantity);
    }
}
