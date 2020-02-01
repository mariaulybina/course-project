namespace airbookings
{
    partial class MyProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
            this.titleLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.sexLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cityLabel = new System.Windows.Forms.Label();
            this.citizenshipLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.mainInfoLabel = new System.Windows.Forms.Label();
            this.contactInfoLabel = new System.Windows.Forms.Label();
            this.loginContainerLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.emailContainerLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.deleteMyProfileButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.citizenshipComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.titleLabel.Location = new System.Drawing.Point(60, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(146, 30);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "airbookings";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::airbookings.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(42, 41);
            this.logoPictureBox.TabIndex = 4;
            this.logoPictureBox.TabStop = false;
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.femaleButton.Location = new System.Drawing.Point(206, 120);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(79, 19);
            this.femaleButton.TabIndex = 40;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "женский";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleButton.Location = new System.Drawing.Point(124, 119);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(79, 19);
            this.maleButton.TabIndex = 39;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "мужской";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.Location = new System.Drawing.Point(70, 124);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(31, 15);
            this.sexLabel.TabIndex = 38;
            this.sexLabel.Text = "Пол";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cityTextBox.Location = new System.Drawing.Point(169, 313);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(148, 21);
            this.cityTextBox.TabIndex = 37;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.returnButton.Location = new System.Drawing.Point(311, 463);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(64, 25);
            this.returnButton.TabIndex = 35;
            this.returnButton.Text = "Назад";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveButton.Location = new System.Drawing.Point(73, 361);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(244, 27);
            this.saveButton.TabIndex = 34;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.cityLabel.Location = new System.Drawing.Point(71, 315);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(44, 15);
            this.cityLabel.TabIndex = 33;
            this.cityLabel.Text = "Город";
            // 
            // citizenshipLabel
            // 
            this.citizenshipLabel.AutoSize = true;
            this.citizenshipLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.citizenshipLabel.Location = new System.Drawing.Point(71, 284);
            this.citizenshipLabel.Name = "citizenshipLabel";
            this.citizenshipLabel.Size = new System.Drawing.Size(86, 15);
            this.citizenshipLabel.TabIndex = 32;
            this.citizenshipLabel.Text = "Гражданство";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.nameLabel.Location = new System.Drawing.Point(70, 199);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 15);
            this.nameLabel.TabIndex = 30;
            this.nameLabel.Text = "ФИО";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(70, 173);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 15);
            this.emailLabel.TabIndex = 28;
            this.emailLabel.Text = "Email";
            // 
            // mainInfoLabel
            // 
            this.mainInfoLabel.AutoSize = true;
            this.mainInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainInfoLabel.Location = new System.Drawing.Point(69, 82);
            this.mainInfoLabel.Name = "mainInfoLabel";
            this.mainInfoLabel.Size = new System.Drawing.Size(161, 19);
            this.mainInfoLabel.TabIndex = 41;
            this.mainInfoLabel.Text = "Общая информация";
            // 
            // contactInfoLabel
            // 
            this.contactInfoLabel.AutoSize = true;
            this.contactInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactInfoLabel.Location = new System.Drawing.Point(69, 244);
            this.contactInfoLabel.Name = "contactInfoLabel";
            this.contactInfoLabel.Size = new System.Drawing.Size(195, 19);
            this.contactInfoLabel.TabIndex = 43;
            this.contactInfoLabel.Text = "Контактная информация";
            // 
            // loginContainerLabel
            // 
            this.loginContainerLabel.AutoSize = true;
            this.loginContainerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginContainerLabel.Location = new System.Drawing.Point(129, 149);
            this.loginContainerLabel.Name = "loginContainerLabel";
            this.loginContainerLabel.Size = new System.Drawing.Size(68, 15);
            this.loginContainerLabel.TabIndex = 45;
            this.loginContainerLabel.Text = "somelogin";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(70, 149);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(45, 15);
            this.loginLabel.TabIndex = 44;
            this.loginLabel.Text = "Логин";
            // 
            // emailContainerLabel
            // 
            this.emailContainerLabel.AutoSize = true;
            this.emailContainerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailContainerLabel.Location = new System.Drawing.Point(129, 173);
            this.emailContainerLabel.Name = "emailContainerLabel";
            this.emailContainerLabel.Size = new System.Drawing.Size(135, 15);
            this.emailContainerLabel.TabIndex = 42;
            this.emailContainerLabel.Text = "somemail@gmail.com";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.changePasswordButton.Location = new System.Drawing.Point(74, 394);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(243, 25);
            this.changePasswordButton.TabIndex = 46;
            this.changePasswordButton.Text = "Изменить пароль";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // deleteMyProfileButton
            // 
            this.deleteMyProfileButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteMyProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMyProfileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteMyProfileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.deleteMyProfileButton.Location = new System.Drawing.Point(74, 425);
            this.deleteMyProfileButton.Name = "deleteMyProfileButton";
            this.deleteMyProfileButton.Size = new System.Drawing.Size(243, 25);
            this.deleteMyProfileButton.TabIndex = 47;
            this.deleteMyProfileButton.Text = "Удалить учетную запись";
            this.deleteMyProfileButton.UseVisualStyleBackColor = false;
            this.deleteMyProfileButton.Click += new System.EventHandler(this.deleteMyProfileButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nameTextBox.Location = new System.Drawing.Point(124, 199);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(193, 21);
            this.nameTextBox.TabIndex = 48;
            // 
            // citizenshipComboBox
            // 
            this.citizenshipComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.citizenshipComboBox.FormattingEnabled = true;
            this.citizenshipComboBox.Location = new System.Drawing.Point(169, 281);
            this.citizenshipComboBox.Name = "citizenshipComboBox";
            this.citizenshipComboBox.Size = new System.Drawing.Size(148, 23);
            this.citizenshipComboBox.TabIndex = 36;
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(387, 500);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.deleteMyProfileButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.loginContainerLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.contactInfoLabel);
            this.Controls.Add(this.emailContainerLabel);
            this.Controls.Add(this.mainInfoLabel);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.citizenshipComboBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.citizenshipLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мой профиль";
            this.Load += new System.EventHandler(this.MyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label citizenshipLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label mainInfoLabel;
        private System.Windows.Forms.Label contactInfoLabel;
        private System.Windows.Forms.Label loginContainerLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label emailContainerLabel;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button deleteMyProfileButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox citizenshipComboBox;
    }
}