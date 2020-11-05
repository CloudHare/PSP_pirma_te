using PSP_pirma_te.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_te
{
    class RygaDelivery : PackageDelivery
    {
        public override double calculatePrice(int weight)
        {
            double price;
            price = 20.01 * 0.02 * weight;

            return price;
        }

        public override Destination getDestination()
        {
            return Destination.Ryga;
        }
    }
}
