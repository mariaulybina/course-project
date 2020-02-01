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
    public partial class Flights : Form
    {
        public Flights()
        {
            InitializeComponent();
        }

        public Flights(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        public Flights(User user, string use)
        {
            InitializeComponent();
            this.user = user;
            addButton.Visible = true;
        }
        public User user;

        private void Flights_Load(object sender, EventArgs e)
        {
            secondDepartureDateTimePicker.Value = DateTime.Now.Date.AddYears(1);
            arrivalComboBox.BeginUpdate();//поддерживаем быстродействие при добавлении элементов в comboBox по одному
            departureComboBox.BeginUpdate();//поддерживаем быстродействие при добавлении элементов в comboBox по одному
            for (int i = 0; i < DataService.GetCity().Count; i++)//для каждой страны в списке
            {
                arrivalComboBox.Items.Add(DataService.GetCity()[i].ToString());//добавляем в comboBox
                departureComboBox.Items.Add(DataService.GetCity()[i].ToString());//добавляем в comboBox
            }
            arrivalComboBox.EndUpdate();//отображаем все добавленное в comboBox'e
            departureComboBox.EndUpdate();//отображаем все добавленное в comboBox'e
            DataService.GetFlightsInfo(flightDataGridView);//показать все рейсы
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
             DataService.GetFilteredFlights(flightDataGridView, departureComboBox.SelectedItem, arrivalComboBox.SelectedItem, DepartureDateTimePicker.Value, secondDepartureDateTimePicker.Value);//вызываем метод фильтрации рейсов
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            DataService.GetFlightsInfo(flightDataGridView);//показать все рейсы
        }

        private void flightDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DataService.CheckFlight(flightDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))//если выбранная ячейка - код рейса
            { Flight flight = new Flight(flightDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());//создаем экземпляр  класса Flight
                DataService.getFlightInf(ref flight);
                Booking buyATicket = new Booking(user,flight);
                buyATicket.Show();
                this.Hide();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            StartWindow userStartWindow = new StartWindow(user);
            userStartWindow.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addFlight add = new addFlight(user);
            add.Show();
            this.Hide();
        }
    }
}
