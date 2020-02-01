using System;
using System.Windows.Forms;

namespace airbookings
{
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        public MyProfile(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        public User user;
        string sex = "";

        private void maleButton_CheckedChanged(object sender, EventArgs e)
        {
            sex = "муж";
        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {
            sex = "жен";
        }
        private void MyProfile_Load(object sender, EventArgs e)
        {
            sex = user.sex;
            if (user.sex == "муж") maleButton.Checked = true;//Заполняем информацию о поле
            else femaleButton.Checked = true;
            loginContainerLabel.Text = user.login;//Заполняем информацию о логине
            emailContainerLabel.Text = user.email;//Заполняем информацию о почте
            nameTextBox.Text = user.name;//Заполняем информацию об имени
            citizenshipComboBox.BeginUpdate();//поддерживаем быстродействие при добавлении элементов в comboBox по одному
            for (int i = 0; i < DataService.GetCountry().Count; i++)//для каждой страны в списке
            {
                citizenshipComboBox.Items.Add(DataService.GetCountry()[i].ToString());//добавляем в comboBox
            }
            citizenshipComboBox.EndUpdate();//отображаем все добавленное в comboBox'e
            citizenshipComboBox.SelectedItem = user.citizenship;//Заполняем информацию о гражданстве
            cityTextBox.Text = user.city;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (DataService.CheckUpdateData(nameLabel.Text, citizenshipComboBox.SelectedItem.ToString(), cityTextBox.Text))
            {
                DataService.UpdateMyProfile(user.login, sex, nameTextBox.Text, citizenshipComboBox.SelectedItem.ToString(), cityTextBox.Text);
                user.sex = sex;
                user.name = nameTextBox.Text;
                user.citizenship = citizenshipComboBox.SelectedItem.ToString();
                user.city = cityTextBox.Text;
                MessageBox.Show("Изменения успешно сохранены");
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            PasswordChange password = new PasswordChange(user);
            password.Show();
            this.Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            StartWindow userStartWindow = new StartWindow(user);
            userStartWindow.Show();
            this.Hide();//Закрываем данную форму
        }

        private void deleteMyProfileButton_Click(object sender, EventArgs e)
        {
            DataService.DeleteMyprofile(user.login);//удаляем профиль с данным логином
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();//Открываем форму Авторизация
            this.Hide();//Закрываем данную форму
        }
    }
}
