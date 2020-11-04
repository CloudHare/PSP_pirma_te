using PSP_pirma_te.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_te
{
    class BusinessRomeTicket : FlightTicket
    {
        public override double calculatePrice()
        {
            double price;

            price = 2.11 * 40.44;
            price = Math.Round(price, 2);

            return price;
        }

        public override int calculateLuggage()
        {
            return 25;
        }

        public override bool goodDocument(Document doc)
        {
            switch (doc)
            {
                case Document.IDCard:
                    return true;

                case Document.Passport:
                    return true;

                default:
                    throw new NotImplementedException("Unknown document");
            }
        }
    }
}
