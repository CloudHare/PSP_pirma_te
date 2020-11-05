using PSP_pirma_te.Enums;
using PSP_pirma_te.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_te
{
    abstract class FlightTicket
    {
        public FlightTicketData getTicket(Document doc)
        {
            FlightTicketData ftd = new FlightTicketData();
            ftd.Price = calculatePrice();
            ftd.Luggage = calculateLuggage();
            ftd.GoodDoc = goodDocument(doc);

            return ftd;
        }

        public abstract double calculatePrice();

        public abstract int calculateLuggage();

        public abstract bool goodDocument(Document doc);

        public abstract string getDestination();

        public abstract string getFlightClass();
    }
}
