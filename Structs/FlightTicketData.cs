using PSP_pirma_te.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_te.Structs
{
    public struct FlightTicketData
    {
        public bool GoodDoc { get; set; }
        public double Price { get; set; }
        public int Luggage { get; set; }
    }
}
