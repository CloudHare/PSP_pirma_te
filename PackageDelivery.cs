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


        // For the sake of a nicer interface, has nothing to do with logic
        // Should I delete this and not display Destination in the interface?
        public Destination getDestination()
        {
            if (this.GetType() == typeof(RomeDelivery))
            {
                return Destination.Rome;
            }
            else if (this.GetType() == typeof(BostonDelivery))
            {
                return Destination.Boston;
            }
            else
            {
                throw new NotImplementedException("Unknown destination");
            }
        }
    }
}
