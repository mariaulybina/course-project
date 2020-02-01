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
    public partial class PasswordChange : Form
    {
        public PasswordChange(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        public User user;

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (DataService.checkPasswordChangeData(currentPasswordTextBox.Text, newPasswordTextBox.Text, repeatNewPasswordTextBox.Text))
            {
                if (currentPasswordTextBox.Text != user.password)
                {
                    DataService.updatePassword(user.login, newPasswordTextBox.Text);
                    user.login = newPasswordTextBox.Text;
                    MessageBox.Show("Изменения сохранены", "Уведомление");
                    DataService.CleanAllTextBoxesIn(this);
                }
                else
                {
                    MessageBox.Show("Вы ввели некорректный текущий пароль", "Ошибка");
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            MyProfile myProfile = new MyProfile(user);
            myProfile.Show();
            this.Hide();
        }
    }
}
