using PSP_pirma_st.Enums;
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
    public partial class Form1 : Form
    {
        double price;

        FlightTicket flightTicket;
        Destination flightDest;
        FlightClass flightClass;
        int luggage;
        bool coffee;

        public Form1()
        {
            InitializeComponent();

            flightTicket = new FlightTicket();

            comboBox1.DataSource = Enum.GetValues(typeof(Destination));
            comboBox3.DataSource = Enum.GetValues(typeof(Destination));
            comboBox2.DataSource = Enum.GetValues(typeof(FlightClass));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flightDest = (Destination)comboBox1.SelectedValue;
            flightClass = (FlightClass)comboBox2.SelectedValue;

            price = flightTicket.calculatePrice(flightDest, flightClass);
            price = Math.Round(price, 2);
            luggage = flightTicket.calculateLuggage(flightDest, flightClass);
            coffee = flightTicket.isCoffeeIncluded(flightDest, flightClass);

            flightDestField.Text = flightDest.ToString();
            flightClassField.Text = flightClass.ToString();
            flightPriceField.Text = price.ToString();
            luggageField.Text = luggage.ToString();
            if (coffee)
            {
                coffeeField.Text = "yes";
            }
            else if (!coffee)
            {
                coffeeField.Text = "no";
            }
            else
            {
                throw new NotImplementedException("coffee value undefined");
            }
            
        }

        private void flightDestField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
