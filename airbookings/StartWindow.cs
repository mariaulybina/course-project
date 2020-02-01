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
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }
        
        public StartWindow(User user)//передаем в конструктор формы объект пользователя
        {
            InitializeComponent();
            this.user = user;//присваиваем "местному" пользователю ранее указанные характеристики
            if (CurrentUser.UserType.Equals("кассир"))
            {
                myBookingsButton.Text = "Все бронирования";
            }
            if (CurrentUser.UserType.Equals("администратор"))
            {
                myBookingsButton.Text = "Все бронирования";
                MyProfileButton.Text = "Панель администрирования";
            }
        }
        User user;//создаем объект пользователь
        private void UserStartWindow_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text += ", " + user.name.Substring(0,user.name.IndexOf(' ') + 1);//При загрузке формы выводим приветствие с именем пользователя
        }

        private void MyProfileButton_Click(object sender, EventArgs e)
        {
            if (CurrentUser.UserType.Equals("администратор"))
            {

                AdministrationWindow administrationWindow = new AdministrationWindow(user);//Переходим на форму МойПрофиль
                administrationWindow.Show();
                this.Hide();
            }
            else 
            {
                MyProfile myProfile = new MyProfile(user);//Переходим на форму МойПрофиль
                myProfile.Show();
                this.Hide();
            }  
        }

        private void gotoFlightsButton_Click(object sender, EventArgs e)
        {
            Flights flights = new Flights(user);
            flights.Show();
            this.Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();//Открываем форму Авторизация
            this.Hide();//Закрываем данную форму
        }

        private void myBookingsButton_Click(object sender, EventArgs e)
        {
            MyBookings myBookings = new MyBookings(user);
            myBookings.Show();
            this.Hide();
        }
    }
}
