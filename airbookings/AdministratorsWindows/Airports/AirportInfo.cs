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
    public partial class AirportInfo : Form
    {
        public AirportInfo(User user, string use)//Конструктор, вызываемый при нажатии на кнопку  "добавить"
        {
            InitializeComponent();
            this.user = user;
            this.use = use;
            deleteButton.Visible = false;

        }
        public AirportInfo(User user, string IATA, string name,  string city, string country, string ICAO, string coordinates, string use)//Конструктор, вызываемый при нажатии на код авиалинии
        {
            InitializeComponent();
            this.user = user;
            this.IATA = IATA;
            this.name = name;
            this.country = country;
            this.city = city;
            this.ICAO = ICAO;
            this.coordinates = coordinates;
            IATATextBox.ReadOnly = true;
            this.use = use;
        }
        public User user;
        public string use;
        public string IATA;
        public string name;
        public string city;
        public string country;
        public string ICAO;
        public string coordinates;

        private void AirportInfo_Load(object sender, EventArgs e)
        {
            IATATextBox.Text = IATA;
            nameTextBox.Text = name;
            cityTextBox.Text = city;
            ICAOTextBox.Text = ICAO;
            coordinatesTextBox.Text = coordinates;
            countryComboBox.BeginUpdate();//поддерживаем быстродействие при добавлении элементов в comboBox по одному
            for (int i = 0; i < DataService.GetCountry().Count; i++)//для каждой страны в списке
            {
                countryComboBox.Items.Add(DataService.GetCountry()[i].ToString());//добавляем в comboBox
            }
            countryComboBox.EndUpdate();//отображаем все добавленное в comboBox'e
            countryComboBox.SelectedItem = country;//Заполняем информацию о городе
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DataService.addUpdateAirport(use, IATATextBox.Text, nameTextBox.Text,cityTextBox.Text, countryComboBox.SelectedItem.ToString(), ICAOTextBox.Text,coordinatesTextBox.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataService.deleteInfo("airline", "IATA", IATA);
            AirlinesWindow airlinesWindow = new AirlinesWindow(user);
            airlinesWindow.Show();
            this.Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            AirportsWindow airportsWindow = new AirportsWindow(user);
            airportsWindow.Show();
            this.Hide();
        }
    }
}
