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
    public partial class MyBookings : Form
    {
        public MyBookings()
        {
            InitializeComponent();
        }
        public MyBookings(User user)
        {
            InitializeComponent();
            this.user = user;//присваиваем "местному" пользователю ранее указанные характеристики

        }
        User user;//создаем объект пользователь
        private void MyBookings_Load(object sender, EventArgs e)
        {
            if (CurrentUser.UserType.Equals("пользователь"))
            {
                DataService.GetMyBookingsInfo(bookingsDataGridView, user.login);//показать все бронирования
                if (bookingsDataGridView.Rows.Count == 0)
                {
                    this.Close();
                    StartWindow userStartWindow = new StartWindow(user);
                    userStartWindow.Show();
                }
            }
            if (CurrentUser.UserType.Equals("кассир"))
            {
                bookingsLabel.Text = "Все бронирования";
                DataService.GetAllBookingsInfo(bookingsDataGridView);//показать все бронирования
            }
            if (CurrentUser.UserType.Equals("администратор"))
            {
                bookingsLabel.Text = "Все бронирования";
                DataService.GetAllBookingsInfo(bookingsDataGridView);//показать все бронирования
            }
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            StartWindow userStartWindow = new StartWindow(user);
            userStartWindow.Show();
            this.Hide();
        }

        private void bookingsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataService.CheckBooking(bookingsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))//если выбранная ячейка - код бронирования
            {
                Flight flight = new Flight(bookingsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());//создаем экземпляр  класса Flight
                DataService.getFlightInf(ref flight);
                BookingPassenger bookingsPassenger = DataService.GetPassengerByFullname(bookingsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());//Создаем экземпляр класса посредством вызова метода получения пользователя по email'у
                string bookingCode = bookingsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string service_class = bookingsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                string rate = bookingsDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                string seat = bookingsDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                Booking booking = new Booking(user, flight, bookingsPassenger, service_class, rate, seat, bookingCode);
                booking.Show();
                this.Hide();
            }
        }
    }
}
