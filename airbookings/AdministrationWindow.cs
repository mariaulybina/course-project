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
    public partial class AdministrationWindow : Form
    {
        public AdministrationWindow()
        {
            InitializeComponent();
        }

        public AdministrationWindow(User user)//передаем в конструктор формы объект пользователя
        {
            InitializeComponent();
            this.user = user;//присваиваем "местному" пользователю ранее указанные характеристики
        }
        User user;//создаем объект пользователь

        private void airlinesButton_Click(object sender, EventArgs e)
        {
            AirlinesWindow airlinesWindow = new AirlinesWindow(user);
            airlinesWindow.Show();
            this.Hide();
        }

        private void airportsButton_Click(object sender, EventArgs e)
        {
            AirportsWindow airportsWindow = new AirportsWindow(user);
            airportsWindow.Show();
            this.Hide();
        }
        private void flightsButton_Click(object sender, EventArgs e)
        {
            Flights flights = new Flights(user, "use");
            flights.Show();
            this.Hide();
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            StartWindow startWindow = new StartWindow(user);
            startWindow.Show();
            this.Hide();
        }


    }
}
