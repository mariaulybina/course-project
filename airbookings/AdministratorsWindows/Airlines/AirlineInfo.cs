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
    public partial class AirlineInfo : Form
    {
        public AirlineInfo(User user, string use)//Конструктор, вызываемый при нажатии на кнопку  "добавить"
        {
            InitializeComponent();
            this.user = user;
            this.use = use;
            deleteButton.Visible = false;

        }
        public AirlineInfo(User user, string IATA, string name, string ICAO, string image, string use)//Конструктор, вызываемый при нажатии на код авиалинии
        {
            InitializeComponent();
            this.user = user;
            this.IATA = IATA;
            this.name = name;
            this.ICAO = ICAO;
            this.image = image;
            this.use = use;
            IATATextBox.ReadOnly = true;
        }
        public User user;
        public string IATA = "";
        public string name = "";
        public string ICAO = "";
        public string image = "";
        public string use = "";

        private void AirlineInfo_Load(object sender, EventArgs e)
        {
            IATATextBox.Text = IATA;
            nameTextBox.Text = name;
            ICAOTextBox.Text = ICAO;
            imageTextBox.Text = image;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DataService.addUpdateAirline(use, IATATextBox.Text, nameTextBox.Text, ICAOTextBox.Text, imageTextBox.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataService.deleteInfo("airline","IATA", IATA);
            AirlinesWindow airlinesWindow = new AirlinesWindow(user);
            airlinesWindow.Show();
            this.Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            AirlinesWindow airlinesWindow = new AirlinesWindow(user);
            airlinesWindow.Show();
            this.Hide();
        }
    }
}
