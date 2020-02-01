namespace airbookings
{
    partial class PasswordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChange));
            this.titleLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.giveNewPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.repeatNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.repeatNewPasswordLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
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
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "airbookings";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::airbookings.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(42, 41);
            this.logoPictureBox.TabIndex = 6;
            this.logoPictureBox.TabStop = false;
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.ChangePasswordLabel.Location = new System.Drawing.Point(51, 84);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(141, 19);
            this.ChangePasswordLabel.TabIndex = 42;
            this.ChangePasswordLabel.Text = "Изменить пароль";
            // 
            // giveNewPasswordLabel
            // 
            this.giveNewPasswordLabel.AutoSize = true;
            this.giveNewPasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.giveNewPasswordLabel.Location = new System.Drawing.Point(52, 117);
            this.giveNewPasswordLabel.Name = "giveNewPasswordLabel";
            this.giveNewPasswordLabel.Size = new System.Drawing.Size(289, 15);
            this.giveNewPasswordLabel.TabIndex = 43;
            this.giveNewPasswordLabel.Text = "Задайте новый пароль для личного кабинета";
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.AutoSize = true;
            this.passwordLengthLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLengthLabel.Location = new System.Drawing.Point(52, 134);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Size = new System.Drawing.Size(266, 15);
            this.passwordLengthLabel.TabIndex = 44;
            this.passwordLengthLabel.Text = "Длина должна быть не менее 6 символов";
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.5F);
            this.currentPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.currentPasswordLabel.Location = new System.Drawing.Point(54, 172);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(93, 12);
            this.currentPasswordLabel.TabIndex = 45;
            this.currentPasswordLabel.Text = "ТЕКУЩИЙ ПАРОЛЬ";
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.currentPasswordTextBox.Location = new System.Drawing.Point(55, 189);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.PasswordChar = '*';
            this.currentPasswordTextBox.Size = new System.Drawing.Size(230, 21);
            this.currentPasswordTextBox.TabIndex = 46;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.newPasswordTextBox.Location = new System.Drawing.Point(56, 239);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.Size = new System.Drawing.Size(230, 21);
            this.newPasswordTextBox.TabIndex = 48;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.5F);
            this.newPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.newPasswordLabel.Location = new System.Drawing.Point(55, 222);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(82, 12);
            this.newPasswordLabel.TabIndex = 47;
            this.newPasswordLabel.Text = "НОВЫЙ ПАРОЛЬ";
            // 
            // repeatNewPasswordTextBox
            // 
            this.repeatNewPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.repeatNewPasswordTextBox.Location = new System.Drawing.Point(56, 290);
            this.repeatNewPasswordTextBox.Name = "repeatNewPasswordTextBox";
            this.repeatNewPasswordTextBox.PasswordChar = '*';
            this.repeatNewPasswordTextBox.Size = new System.Drawing.Size(230, 21);
            this.repeatNewPasswordTextBox.TabIndex = 50;
            // 
            // repeatNewPasswordLabel
            // 
            this.repeatNewPasswordLabel.AutoSize = true;
            this.repeatNewPasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.5F);
            this.repeatNewPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.repeatNewPasswordLabel.Location = new System.Drawing.Point(55, 273);
            this.repeatNewPasswordLabel.Name = "repeatNewPasswordLabel";
            this.repeatNewPasswordLabel.Size = new System.Drawing.Size(140, 12);
            this.repeatNewPasswordLabel.TabIndex = 49;
            this.repeatNewPasswordLabel.Text = "ПОВТОРИТЕ НОВЫЙ ПАРОЛЬ";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveButton.Location = new System.Drawing.Point(57, 336);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(228, 27);
            this.saveButton.TabIndex = 51;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.returnButton.Location = new System.Drawing.Point(298, 370);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(64, 25);
            this.returnButton.TabIndex = 52;
            this.returnButton.Text = "Назад";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(374, 407);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.repeatNewPasswordTextBox);
            this.Controls.Add(this.repeatNewPasswordLabel);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.currentPasswordLabel);
            this.Controls.Add(this.passwordLengthLabel);
            this.Controls.Add(this.giveNewPasswordLabel);
            this.Controls.Add(this.ChangePasswordLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить пароль";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label ChangePasswordLabel;
        private System.Windows.Forms.Label giveNewPasswordLabel;
        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.Label currentPasswordLabel;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox repeatNewPasswordTextBox;
        private System.Windows.Forms.Label repeatNewPasswordLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button returnButton;
    }
}