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
    public partial class AirportsWindow : Form
    {
        public AirportsWindow()
        {
            InitializeComponent();
        }

        public AirportsWindow(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        public User user;

        private void AirportsWindow_Load(object sender, EventArgs e)
        {
            DataService.GetInfo(airportsDataGridView, "airports");
        }

        private void airportsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (airportsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Length == 3)//если выбранная ячейка - код авиалинии
            {
                AirportInfo airportInfo = new AirportInfo(user, airportsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), airportsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), airportsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(), airportsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString(), airportsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString(), airportsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString(),"update");
                airportInfo.Show();
                this.Hide();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AirportInfo airportInfo = new AirportInfo(user, "add");
            airportInfo.Show();
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
