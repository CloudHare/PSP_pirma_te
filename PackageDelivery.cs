using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_te
{
    class PackageDelivery
    {
        PackageDelivery pd;
        int weight;

        public virtual double calculateDeliveryPrice(Destination dest, int weight)
        {
            double price;

            setDestination(dest);

            price = pd.calculateDeliveryPrice(dest, weight);
            price = price * 0.02 * weight;

            return price;
        }

        private void setDestination(Destination dest)
        {
            switch (dest)
            {
                case Destination.Boston:
                    pd = new BostonDelivery();
                    break;

                case Destination.Rome:
                    pd = new RomeDelivery();
                    break;

                default:
                    throw new NotImplementedException("Unknown destination");
            }
        }
    }
}
