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

        // For the sake of a nicer interface, has nothing to do with logic
        // Should I delete this and not display Destination and FlightClass in the interface?
        public Destination getDestination()
        {
            if (this.GetType() == typeof(BusinessRomeTicket) || this.GetType() == typeof(EconomyRomeTicket))
            {
                return Destination.Rome;
            }
            else if (this.GetType() == typeof(BusinessBostonTicket) || this.GetType() == typeof(EconomyBostonTicket))
            {
                return Destination.Boston;
            }
            else
            {
                throw new NotImplementedException("Unknown destination");
            }
        }

        public FlightClass getFlightClass()
        {
            if (this.GetType() == typeof(BusinessRomeTicket) || this.GetType() == typeof(BusinessBostonTicket))
            {
                return FlightClass.Business;
            }
            else if (this.GetType() == typeof(EconomyRomeTicket) || this.GetType() == typeof(EconomyBostonTicket))
            {
                return FlightClass.Economy;
            }
            else
            {
                throw new NotImplementedException("Unknown flight class");
            }
        }
    }
}
