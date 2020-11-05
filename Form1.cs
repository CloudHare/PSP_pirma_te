using PSP_pirma_te.Enums;
using PSP_pirma_te.Structs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSP_pirma_te
{
    public partial class Client : Form
    {
        FlightTicket flightTicket;
        Document doc;
        FlightTicketData ftd;

        PackageDelivery packageDelivery;
        int weight;
        double deliveryPrice;

        public Client()
        {
            InitializeComponent();

            flightTicket = new EconomyRygaTicket();

            packageDelivery = new RygaDelivery();

            comboBox1.DataSource = Enum.GetValues(typeof(Document));

            flightDestField.Text = flightTicket.getDestination().ToString();
            flightClassField.Text = flightTicket.getFlightClass().ToString();
            deliveryDestField.Text = packageDelivery.getDestination().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doc = (Document)comboBox1.SelectedValue;

            ftd = flightTicket.getTicket(doc);

            flightPriceField.Text = ftd.Price.ToString();
            luggageField.Text = ftd.Luggage.ToString();
            if (ftd.GoodDoc)
            {
                goodDocumentField.Text = "yes";
            }
            else if (!ftd.GoodDoc)
            {
                goodDocumentField.Text = "no";
            }
            else
            {
                throw new NotImplementedException("document value undefined");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            weight = Convert.ToInt32(weightInput.Value);
            if (weight > 0)
            {
                weightWarningField.Visible = false;
            }
            else
            {
                weightWarningField.Visible = true;
                return;
            }

            deliveryPrice = packageDelivery.calculatePrice(weight);

            weightField.Text = weight.ToString();
            deliveryPriceField.Text = deliveryPrice.ToString();
        }


        private void flightDestField_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
