using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airbookings
{
    public partial class addFlight : Form
    {
        public addFlight(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        public User user;

        private void addButton_Click(object sender, EventArgs e)
        {
                DataService.addFlight(flightTextBox.Text, airportDepartureTextBox.Text, departureCityTextBox.Text, arrivalAirportTextBox.Text, arrivalCityTextBox.Text, dateTextBox.Text, dateTextBox2.Text, airlineTextBox.Text);
                DataService.addFlightCost(flightTextBox.Text, standartTextBox.Text, extendedTextBox.Text, fullTextBox.Text);
                Flights flights = new Flights(user, "use");
                flights.Show();
                this.Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            AdministrationWindow administrationWindow = new AdministrationWindow(user);
            administrationWindow.Show();
            this.Hide();
        }
    }
}
