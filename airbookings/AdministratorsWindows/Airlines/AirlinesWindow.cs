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
    public partial class AirlinesWindow : Form
    {
        public AirlinesWindow()
        {
            InitializeComponent();
        }
        public AirlinesWindow(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        public User user;

        private void AirlinesWindow_Load(object sender, EventArgs e)
        {
            
            DataService.GetInfo(airlinesDataGridView,"airlines");
        }

        private void airlineDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (airlinesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Length == 2)//если выбранная ячейка - код авиалинии
            {
                AirlineInfo airlineInfo = new AirlineInfo(user, airlinesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), airlinesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), airlinesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(), airlinesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString(), "update");
                airlineInfo.Show();
                this.Hide();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AirlineInfo airlineInfo = new AirlineInfo(user,"add");
            airlineInfo.Show();
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
