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
    public partial class AuthorizationWindow : Form
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)//При нажатии на кнопку вход
        {
            if ((loginTextBox.Text.Trim().Length==0) || (passwordTextBox.Text.Trim().Length==0))//Если одно или несколько из полей пусто
            {
                MessageBox.Show("Необходимо ввести логин и пароль", "Предупреждение");//Выводим предупреждение
            }
            else//иначе
            {
                User user = new User(loginTextBox.Text, DataService.getHash(passwordTextBox.Text));//Создаем экземпляр класса User, передаем логин и пароль

                DataService.getUserInf(ref user);//Вызываем метод получения информации о пользователе, передаем экземпляр класса User  в качестве параметра по значению

                CurrentUser.SetUserInfo(user);//Вызываем метод для установки информации о данном пользователе

                Passenger passenger = DataService.GetPassengerByEmail(user.email);//Создаем экземпляр класса посредством вызова метода получения пользователя по email'у
                if (passenger != null)//Если нам удалось получить информацию о пассажире по имейлу пользователя
                {
                    CurrentPassenger.SetPassengerInfo(passenger);//Добавляем информацию о текущем пассажире в класс CurrentPassenger
                }
                else
                {
                    CurrentPassenger.UnsetPassengerInfo();//Удаляем информацию о текущем пассажире из класса CurrentPassenger
                }
                switch (user.userType)
                {
                    case null:
                        MessageBox.Show("Неправильный логин/пароль");
                        break;
                    default:
                        StartWindow startWindow = new StartWindow(user);
                        startWindow.Show();
                        this.Hide();
                        break;
                }
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)//При нажатии на кнопку регистрация
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();//
            registrationWindow.Show();
            this.Hide();          
        }
    }
}
