using PSP_pirma_te.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_te
{
    class EconomyBostonTicket : FlightTicket
    {
        public override double calculatePrice()
        {
            double price;

            price = 1.22 * 230.12;
            price = Math.Round(price, 2);

            return price;
        }

        public override int calculateLuggage()
        {
            return 15;
        }

        public override bool goodDocument(Document doc)
        {
            switch (doc)
            {
                case Document.IDCard:
                    return false;

                case Document.Passport:
                    return true;

                default:
                    throw new NotImplementedException("Unknown document");
            }
        }

        public override string getDestination()
        {
            return "Boston";
        }

        public override string getFlightClass()
        {
            return "Economy";
        }
    }
}
