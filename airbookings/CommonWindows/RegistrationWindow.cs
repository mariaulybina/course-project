using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace airbookings
{
    public partial class RegistrationWindow : Form
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegistrationWindow_Load(object sender, EventArgs e)//обработчик события загрузки формы
        {
            citizenshipComboBox.BeginUpdate();//поддерживаем быстродействие при добавлении элементов в comboBox по одному
            for (int i = 0; i < DataService.GetCountry().Count; i++)//для каждой страны в списке
            {
                citizenshipComboBox.Items.Add(DataService.GetCountry()[i].ToString());//добавляем в comboBox
            }
            citizenshipComboBox.EndUpdate();//отображаем все добавленное в comboBox'e
        }
        string sex = "";
        private void registrationButton_Click(object sender, EventArgs e)//обработчик события нажатия на кнопку Регистрация
        {
           if ( DataService.CheckRegistrationData(loginTextBox.Text, passwordTextBox.Text, emailTextBox.Text, nameTextBox.Text, citizenshipComboBox.SelectedItem, cityTextBox.Text))//Проверка данных для регистрации в системе
            {
                DataService.RegistrationUser(loginTextBox.Text, passwordTextBox.Text, emailTextBox.Text, nameTextBox.Text, citizenshipComboBox.SelectedItem.ToString(), cityTextBox.Text, sex);//Регистрация в системе 
                if (DataService.IsUserRegistered(loginTextBox.Text))
                {
                    MessageBox.Show("Вы успешно зарегистрировались");//Выводим сообщение
                    DataService.CleanAllTextBoxesIn(this);//Очищаем все текстовые поляна форме
                    citizenshipComboBox.SelectedItem = null;
                    maleButton.Checked=true;
                }
            }         
        }

        private void returnButton_Click(object sender, EventArgs e)//обработчик события нажатия на кнопку  Назад
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();//Открываем форму Авторизация
            this.Hide();//Закрываем данную форму
        }

        private void maleButton_CheckedChanged(object sender, EventArgs e)
        {
            sex = "муж";
        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {
            sex = "жен";
        }
    }
}
