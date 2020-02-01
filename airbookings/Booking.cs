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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        public Booking(User user,Flight flight)
        {
            InitializeComponent();
            this.user = user;
            this.flight = flight;
            if (CurrentUser.UserType.Equals("пользователь") && CurrentPassenger.Id!=0)
            {
                addMyDataCheckBox.Visible = true;
            }
        }
        public Booking(User user,Flight flight, BookingPassenger bookingPassenger, string service_class, string rate, string seat, string bookingCode)
        {
            InitializeComponent();
            this.user = user;
            this.flight = flight;
            this.bookingPassenger = bookingPassenger;
            this.service_class = service_class;
            this.rate = rate;
            this.seat = seat;
            this.bookingCode = bookingCode;
            addMyDataCheckBox.Visible = false;
            use = "see booking info";
        }
        public string use = "buy a ticket";
        public User user;
        public Flight flight;
        public BookingPassenger bookingPassenger;
        public string service_class = "";//строковая переменная для хранения класса обслуживания
        public string rate = "";//строковая переменная для хранения тарифа
        public string seat = "";//строковая переменная для хранения места
        public string sex = "";//строковая переменная для хранения пола пассажира
        public string bookingCode = GenRandomString("QWERTYUIOPASDFGHJKLZXCVBNM",5);
        public int price;

        private static string GenRandomString(string Alphabet, int Length)
        {
            //создаем объект Random, генерирующий случайные числа
            Random rnd = new Random();
            //объект StringBuilder с заранее заданным размером буфера под результирующую строку
            StringBuilder sb = new StringBuilder(Length - 1);
            //переменную для хранения случайной позиции символа из строки Alphabet
            int Position = 0;
            for (int i = 0; i < Length; i++)
            {
                //получаем случайное число от 0 до последнего
                //символа в строке Alphabet
                Position = rnd.Next(0, Alphabet.Length - 1);
                //добавляем выбранный символ в объект
                //StringBuilder
                sb.Append(Alphabet[Position]);
            }
            return sb.ToString();
        }
        private void updateSeatComboBox()//метод для обновления seatCombobox'а
        {
            seatComboBox.Items.Clear();//очищаем список мест
            seatComboBox.BeginUpdate();//поддерживаем быстродействие при добавлении элементов в comboBox по одному
            for (int i = 0; i < DataService.getSeats(flight.flight,service_class).Count; i++)//для каждого места
            {
                seatComboBox.Items.Add(DataService.getSeats(flight.flight, service_class)[i].ToString());//добавляем в comboBox
            }
            seatComboBox.EndUpdate();//отображаем все добавленное в comboBox'e
        }

        private void BuyATicket_Load(object sender, EventArgs e)//при загрузке формы добавляем в соответсвующие элементы управления
        {

            flightContainerLabel.Text = flight.flight;//номер рейса
            airlinePictureBox.Image = Image.FromFile(DataService.getAirlineIcon(flight.airline));//лого авиакомпании
            departureContainerLabel.Text = flight.departureCity +" "+ flight.departureAirport;//город и аэропорт отправления
            arrivalContainerLabel.Text = flight.arrivalCity + " " + flight.arrivalAirport;//город и аэропорт прибытия
            departureDateContainerLabel.Text = flight.departureDate.ToString();//дату и время отправления
            arrivalDateContainerLabel.Text = flight.arrivalDate.ToString();//дату и время  прибытия
            citizenshipComboBox.BeginUpdate();//поддерживаем быстродействие при добавлении элементов в comboBox по одному
            for (int i = 0; i < DataService.GetCountry().Count; i++)//для каждой страны в списке
            {
                citizenshipComboBox.Items.Add(DataService.GetCountry()[i].ToString());//добавляем в comboBox
            }
            citizenshipComboBox.EndUpdate();//отображаем все добавленное в comboBox'e
            if (use=="see booking info")//
            {
                if (economyRadioButton.Text == service_class) economyRadioButton.Checked=true;
                if (comfortRadioButton.Text == service_class) comfortRadioButton.Checked = true;
                if (businessRadioButton.Text == service_class) businessRadioButton.Checked = true;
                seatTextBox.Text = seat;
                if (standartRadioButton.Text == rate) standartRadioButton.Checked = true;
                if (extendedRadioButton.Text == rate) extendedRadioButton.Checked = true;
                if (fullRadioButton.Text == rate) fullRadioButton.Checked = true;
                if (rate=="полный") returnTicketButton.Visible = true;
                acceptButton.Visible = false;
                seatComboBox.Visible = false;
                seatTextBox.Visible = true;

                if (bookingPassenger.sex == "муж") maleButton.Checked = true;
                if (bookingPassenger.sex == "жен") femaleButton.Checked = true;
                firstNameTextBox.Text = bookingPassenger.firstname;
                middleNameTextBox.Text = bookingPassenger.midname;
                firstNameTextBox.Text = bookingPassenger.firstname;
                lastNameTextBox.Text = bookingPassenger.lastname;
                dateOfBirthDateTimePicker.Value = bookingPassenger.birthday;
                citizenshipComboBox.SelectedItem = bookingPassenger.citizen;
                string[] passport = bookingPassenger.passport.Split(' ');
                seriesTextBox.Text = passport[0];
                numberTextBox.Text = passport[1];
                emailTextBox.Text = bookingPassenger.email;

            }
        }

        private void economyRadioButton_CheckedChanged(object sender, EventArgs e)//при выборе эконом класса
        {
            service_class = economyRadioButton.Text;//заносим это в специальную переменную
            updateSeatComboBox();
        }

        private void comfortRadioButton_CheckedChanged(object sender, EventArgs e)//при выборе комфорт класса
        {
            service_class = comfortRadioButton.Text;//заносим в специальную переменную
            updateSeatComboBox();//обновляем список мест
        }

        private void businessRadioButton_CheckedChanged(object sender, EventArgs e)//при выборе бизнес класса
        {
            service_class = businessRadioButton.Text;//заносим в специальную переменную
            updateSeatComboBox();//обновляем список мест
        }

        private void seatComboBox_Click(object sender, EventArgs e)
        {
            if ((!economyRadioButton.Checked) && (!comfortRadioButton.Checked) && (!businessRadioButton.Checked))
            { MessageBox.Show("Для выбора места необходимо указать класс обслуживания"); }//если не выбран класс обслуживания вывлдим сообщение
        }

        private void standartRadioButton_CheckedChanged(object sender, EventArgs e)//при выборе стандартного тарифа
        {
            rate = standartRadioButton.Text;//заносим в специальную переменную
            price = flight.standart;
            priceTextBox.Text = price.ToString() + " р.";
        }

        private void extendedRadioButton_CheckedChanged(object sender, EventArgs e)//при выборе расширенного тарифа
        {
            rate = extendedRadioButton.Text;//заносим в специальную переменную
            price = flight.extended;
            priceTextBox.Text = price.ToString() + " р.";
        }

        private void fullRadioButton_CheckedChanged(object sender, EventArgs e)//при выборе полного тарифа
        {
            rate = fullRadioButton.Text;//заносим в специальную переменную
            price = flight.full;
            priceTextBox.Text = price.ToString() + " р.";
        }


        private void maleButton_CheckedChanged(object sender, EventArgs e)
        {
            sex = "муж";
        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {
            sex = "жен";
        }

        private void acceptButton_Click(object sender, EventArgs e)//При нажатии на кнопку Подтвердить бронирование
        {
            if (
                 ((economyRadioButton.Checked) || (comfortRadioButton.Checked) || (businessRadioButton.Checked)) &&//если выбран класс обслуживания И
                 ((standartRadioButton.Checked) || (extendedRadioButton.Checked) || (fullRadioButton.Checked)) &&//выбран тариф И
                 (seatComboBox.SelectedItem != null)//выбрано место
            )
            {
                if (DataService.CheckPassengerData(firstNameTextBox.Text, middleNameTextBox.Text, lastNameTextBox.Text, dateOfBirthDateTimePicker.Value, citizenshipComboBox, numberTextBox.Text, emailTextBox.Text) && (((maleButton.Checked) || (femaleButton.Checked))))//если выбран пол пассажира и данные пассажира введены верно
                {
                    int idPassenger = DataService.FindPassengerId(sex, firstNameTextBox.Text, middleNameTextBox.Text, lastNameTextBox.Text, dateOfBirthDateTimePicker.Value, citizenshipComboBox.SelectedItem.ToString(), seriesTextBox.Text + " " + numberTextBox.Text, emailTextBox.Text);//вызываем метод для нахождения id пассажира в системе
                    if (idPassenger == 0)//если мы не нашли id пассажира в системе
                    {
                        DataService.addNewPassenger(sex, firstNameTextBox.Text, middleNameTextBox.Text, lastNameTextBox.Text, dateOfBirthDateTimePicker.Value, citizenshipComboBox.SelectedItem.ToString(), seriesTextBox.Text + " " + numberTextBox.Text, emailTextBox.Text);//регистрируем нового пассажира
                        idPassenger = DataService.FindPassengerId(sex, firstNameTextBox.Text, middleNameTextBox.Text, lastNameTextBox.Text, dateOfBirthDateTimePicker.Value, citizenshipComboBox.SelectedItem.ToString(), seriesTextBox.Text + " " + numberTextBox.Text, emailTextBox.Text);//и повторяем поиск
                    }
                    if (idPassenger != 0)//если мы нашли id пассажира в системе
                    {
                        DataService.addNewTicket(bookingCode, flight.flight, service_class, idPassenger, user.login, rate, seatComboBox.SelectedItem.ToString(), price);
                        DataService.addNewTakenSeat(bookingCode, seatComboBox.SelectedItem.ToString(), flight.flight);
                    }
                    else
                    { MessageBox.Show("Ошибка регистрации пассажира");}//иначе выводим сообщение об ошибке
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать класс обслуживания, тариф и место");
            }
        }
        private void addMyDataCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addMyDataCheckBox.Checked == true)
            {
                if (CurrentPassenger.Sex == "муж") maleButton.Checked = true;
                if (CurrentPassenger.Sex == "жен") femaleButton.Checked = true;
                firstNameTextBox.Text = CurrentPassenger.Firstname;
                middleNameTextBox.Text = CurrentPassenger.Midname;
                firstNameTextBox.Text = CurrentPassenger.Firstname;
                lastNameTextBox.Text = CurrentPassenger.Lastname;
                dateOfBirthDateTimePicker.Value = CurrentPassenger.Birthday;
                citizenshipComboBox.SelectedItem = CurrentPassenger.Citizen;
                string[] passport = CurrentPassenger.Passport.Split(' ');
                seriesTextBox.Text = passport[0];
                numberTextBox.Text = passport[1];
                emailTextBox.Text = CurrentPassenger.Email;
            }
            if (addMyDataCheckBox.Checked == false)
            {
                maleButton.Checked = false;
                femaleButton.Checked = false;
                firstNameTextBox.Text = "";
                middleNameTextBox.Text ="";
                firstNameTextBox.Text = "";
                lastNameTextBox.Text ="";
                dateOfBirthDateTimePicker.Value = DateTime.Now;
                citizenshipComboBox.SelectedItem =null;
                seriesTextBox.Text = "";
                numberTextBox.Text = "";
                emailTextBox.Text = "";
            }
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            if (use=="see booking info")//
            {
                MyBookings myBookings = new MyBookings(user);
                myBookings.Show();
                this.Hide();
            }
            else
            {
                Flights flights = new Flights(user);
                flights.Show();
                this.Hide();
            }
        }

        private void returnTicketButton_Click(object sender, EventArgs e)
        {
            DataService.DeleteTakenSeat(bookingCode);
            DataService.DeleteMyBooking(bookingCode);
            MyBookings myBookings = new MyBookings(user);
            myBookings.Show();
            this.Hide();
        }
    }
}
