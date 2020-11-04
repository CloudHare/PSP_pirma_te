using PSP_pirma_te.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_te
{
    class BostonDelivery : PackageDelivery
    {
        public override double calculatePrice(int weight)
        {
            double price;
            price = 230.12 * 0.02 * weight;

            return price;
        }
    }
}
