using PSP_pirma_te.Enums;
using PSP_pirma_te.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_te
{
    abstract class PackageDelivery
    {

        public abstract double calculatePrice(int weight);
        public abstract Destination getDestination();
    }
}
