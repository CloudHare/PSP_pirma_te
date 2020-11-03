using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_te
{
    class FlightTicket
    {
        FlightTicket ft;

        public virtual double calculatePrice(Destination dest, FlightClass flightClass)
        {
            double price;

            setFlightClassAndDestination(flightClass, dest);
           
            price = ft.calculatePrice(dest, flightClass);
            return price;
        }
        
        public virtual int calculateLuggage(Destination dest, FlightClass flightClass)
        {
            int luggage;

            setFlightClassAndDestination(flightClass, dest);

            luggage = ft.calculateLuggage(dest, flightClass);

            return luggage;
        }

        public virtual bool isCoffeeIncluded(Destination dest, FlightClass flightClass)
        {
            bool coffee;

            setFlightClassAndDestination(flightClass, dest);

            coffee = ft.isCoffeeIncluded(dest, flightClass);

            return coffee;
        }
        
        private void setFlightClassAndDestination(FlightClass flightClass, Destination dest)
        {
            if (dest == Destination.Boston)
            {
                switch (flightClass)
                {
                    case FlightClass.Business:
                        ft = new BusinessBostonTicket();
                        break;

                    case FlightClass.Economy:
                        ft = new EconomyBostonTicket();
                        break;

                    default: throw new NotImplementedException("Unknown flight class");
                }
            }
            else if (dest == Destination.Rome)
            {
                switch (flightClass)
                {
                    case FlightClass.Business:
                        ft = new BusinessRomeTicket();
                        break;

                    case FlightClass.Economy:
                        ft = new EconomyRomeTicket();
                        break;

                    default: throw new NotImplementedException("Unknown flight class");
                }
            }
            else
            {
                throw new NotImplementedException("Unknown destination");
            }
        }
    }
}
