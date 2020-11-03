using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_te
{
    class BostonDelivery : PackageDelivery
    {
        public override double calculateDeliveryPrice(Destination dest, int weight)
        {
            return 230.12;
        }
    }
}
