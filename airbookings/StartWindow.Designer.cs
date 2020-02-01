namespace airbookings
{
    partial class StartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.titleLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.myBookingsButton = new System.Windows.Forms.Button();
            this.gotoFlightsButton = new System.Windows.Forms.Button();
            this.MyProfileButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
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
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "airbookings";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(36, 78);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(136, 17);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = " Добро пожаловать";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.returnButton.Location = new System.Drawing.Point(205, 237);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(64, 25);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Назад";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // myBookingsButton
            // 
            this.myBookingsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.myBookingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBookingsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myBookingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.myBookingsButton.Location = new System.Drawing.Point(49, 150);
            this.myBookingsButton.Name = "myBookingsButton";
            this.myBookingsButton.Size = new System.Drawing.Size(183, 27);
            this.myBookingsButton.TabIndex = 3;
            this.myBookingsButton.Text = "Мои бронирования";
            this.myBookingsButton.UseVisualStyleBackColor = false;
            this.myBookingsButton.Click += new System.EventHandler(this.myBookingsButton_Click);
            // 
            // gotoFlightsButton
            // 
            this.gotoFlightsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gotoFlightsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoFlightsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gotoFlightsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.gotoFlightsButton.Location = new System.Drawing.Point(49, 184);
            this.gotoFlightsButton.Name = "gotoFlightsButton";
            this.gotoFlightsButton.Size = new System.Drawing.Size(183, 28);
            this.gotoFlightsButton.TabIndex = 4;
            this.gotoFlightsButton.Text = "Перейти к выбору рейса";
            this.gotoFlightsButton.UseVisualStyleBackColor = false;
            this.gotoFlightsButton.Click += new System.EventHandler(this.gotoFlightsButton_Click);
            // 
            // MyProfileButton
            // 
            this.MyProfileButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MyProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyProfileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyProfileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.MyProfileButton.Location = new System.Drawing.Point(49, 116);
            this.MyProfileButton.Name = "MyProfileButton";
            this.MyProfileButton.Size = new System.Drawing.Size(183, 27);
            this.MyProfileButton.TabIndex = 2;
            this.MyProfileButton.Text = "Мой профиль";
            this.MyProfileButton.UseVisualStyleBackColor = false;
            this.MyProfileButton.Click += new System.EventHandler(this.MyProfileButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::airbookings.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(42, 41);
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(281, 275);
            this.Controls.Add(this.MyProfileButton);
            this.Controls.Add(this.gotoFlightsButton);
            this.Controls.Add(this.myBookingsButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стартовое окно";
            this.Load += new System.EventHandler(this.UserStartWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button myBookingsButton;
        private System.Windows.Forms.Button gotoFlightsButton;
        private System.Windows.Forms.Button MyProfileButton;
    }
}