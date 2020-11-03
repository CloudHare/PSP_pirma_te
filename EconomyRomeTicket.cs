using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_te
{
    class EconomyRomeTicket : FlightTicket
    {
        public override double calculatePrice(Destination dest, FlightClass flightClass)
        {
            return (1.22 * 40.44);
        }

        public override int calculateLuggage(Destination dest, FlightClass flightClass)
        {
            return 15;
        }

        public override bool isCoffeeIncluded(Destination dest, FlightClass flightClass)
        {
            return false;
        }
    }
}
