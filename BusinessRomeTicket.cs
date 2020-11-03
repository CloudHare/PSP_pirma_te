using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_te
{
    class BusinessRomeTicket : FlightTicket
    {
        public override double calculatePrice(Destination dest, FlightClass flightClass)
        {
            return (2.11 * 40.44);
        }

        public override int calculateLuggage(Destination dest, FlightClass flightClass)
        {
            return 25;
        }

        public override bool isCoffeeIncluded(Destination dest, FlightClass flightClass)
        {
            return true;
        }
    }
}
