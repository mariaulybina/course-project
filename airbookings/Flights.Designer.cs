namespace airbookings
{
    partial class Flights
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flights));
            this.titleLabel = new System.Windows.Forms.Label();
            this.flightDataGridView = new System.Windows.Forms.DataGridView();
            this.availableFlightsWindow = new System.Windows.Forms.Label();
            this.departureDateBetweenLabel = new System.Windows.Forms.Label();
            this.DepartureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.secondDepartureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departureCityLabel = new System.Windows.Forms.Label();
            this.departureComboBox = new System.Windows.Forms.ComboBox();
            this.arrivalComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.pressFlightIdLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).BeginInit();
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
            // flightDataGridView
            // 
            this.flightDataGridView.AllowUserToAddRows = false;
            this.flightDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.flightDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.flightDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.flightDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flightDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.flightDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.flightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.flightDataGridView.Location = new System.Drawing.Point(12, 128);
            this.flightDataGridView.MultiSelect = false;
            this.flightDataGridView.Name = "flightDataGridView";
            this.flightDataGridView.ReadOnly = true;
            this.flightDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.flightDataGridView.Size = new System.Drawing.Size(990, 185);
            this.flightDataGridView.TabIndex = 6;
            this.flightDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightDataGridView_CellClick);
            // 
            // availableFlightsWindow
            // 
            this.availableFlightsWindow.AutoSize = true;
            this.availableFlightsWindow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.availableFlightsWindow.ForeColor = System.Drawing.Color.Black;
            this.availableFlightsWindow.Location = new System.Drawing.Point(15, 69);
            this.availableFlightsWindow.Name = "availableFlightsWindow";
            this.availableFlightsWindow.Size = new System.Drawing.Size(149, 20);
            this.availableFlightsWindow.TabIndex = 7;
            this.availableFlightsWindow.Text = "Доступные рейсы";
            // 
            // departureDateBetweenLabel
            // 
            this.departureDateBetweenLabel.AutoSize = true;
            this.departureDateBetweenLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departureDateBetweenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.departureDateBetweenLabel.Location = new System.Drawing.Point(360, 101);
            this.departureDateBetweenLabel.Name = "departureDateBetweenLabel";
            this.departureDateBetweenLabel.Size = new System.Drawing.Size(112, 14);
            this.departureDateBetweenLabel.TabIndex = 8;
            this.departureDateBetweenLabel.Text = "Дата вылета между";
            // 
            // DepartureDateTimePicker
            // 
            this.DepartureDateTimePicker.Location = new System.Drawing.Point(476, 99);
            this.DepartureDateTimePicker.Name = "DepartureDateTimePicker";
            this.DepartureDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.DepartureDateTimePicker.TabIndex = 10;
            // 
            // secondDepartureDateTimePicker
            // 
            this.secondDepartureDateTimePicker.Location = new System.Drawing.Point(601, 99);
            this.secondDepartureDateTimePicker.Name = "secondDepartureDateTimePicker";
            this.secondDepartureDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.secondDepartureDateTimePicker.TabIndex = 12;
            this.secondDepartureDateTimePicker.Value = new System.DateTime(2020, 1, 26, 0, 0, 0, 0);
            // 
            // departureCityLabel
            // 
            this.departureCityLabel.AutoSize = true;
            this.departureCityLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departureCityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.departureCityLabel.Location = new System.Drawing.Point(16, 102);
            this.departureCityLabel.Name = "departureCityLabel";
            this.departureCityLabel.Size = new System.Drawing.Size(46, 14);
            this.departureCityLabel.TabIndex = 14;
            this.departureCityLabel.Text = "Откуда";
            // 
            // departureComboBox
            // 
            this.departureComboBox.FormattingEnabled = true;
            this.departureComboBox.Location = new System.Drawing.Point(68, 99);
            this.departureComboBox.Name = "departureComboBox";
            this.departureComboBox.Size = new System.Drawing.Size(121, 21);
            this.departureComboBox.TabIndex = 15;
            // 
            // arrivalComboBox
            // 
            this.arrivalComboBox.FormattingEnabled = true;
            this.arrivalComboBox.Location = new System.Drawing.Point(233, 99);
            this.arrivalComboBox.Name = "arrivalComboBox";
            this.arrivalComboBox.Size = new System.Drawing.Size(121, 21);
            this.arrivalComboBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(194, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Куда";
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applyButton.ForeColor = System.Drawing.Color.White;
            this.applyButton.Location = new System.Drawing.Point(728, 96);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(135, 24);
            this.applyButton.TabIndex = 47;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.showAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAllButton.ForeColor = System.Drawing.Color.White;
            this.showAllButton.Location = new System.Drawing.Point(867, 96);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(135, 24);
            this.showAllButton.TabIndex = 48;
            this.showAllButton.Text = "Показать все";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.returnButton.Location = new System.Drawing.Point(938, 328);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(64, 25);
            this.returnButton.TabIndex = 49;
            this.returnButton.Text = "Назад";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // pressFlightIdLabel
            // 
            this.pressFlightIdLabel.AutoSize = true;
            this.pressFlightIdLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressFlightIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.pressFlightIdLabel.Location = new System.Drawing.Point(170, 72);
            this.pressFlightIdLabel.Name = "pressFlightIdLabel";
            this.pressFlightIdLabel.Size = new System.Drawing.Size(425, 17);
            this.pressFlightIdLabel.TabIndex = 50;
            this.pressFlightIdLabel.Text = "Нажмите на номер рейса, чтобы перейти к оформлению билета";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(844, 327);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 25);
            this.addButton.TabIndex = 51;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1014, 364);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pressFlightIdLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrivalComboBox);
            this.Controls.Add(this.departureComboBox);
            this.Controls.Add(this.departureCityLabel);
            this.Controls.Add(this.secondDepartureDateTimePicker);
            this.Controls.Add(this.DepartureDateTimePicker);
            this.Controls.Add(this.departureDateBetweenLabel);
            this.Controls.Add(this.availableFlightsWindow);
            this.Controls.Add(this.flightDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Flights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рейсы";
            this.Load += new System.EventHandler(this.Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.DataGridView flightDataGridView;
        private System.Windows.Forms.Label availableFlightsWindow;
        private System.Windows.Forms.Label departureDateBetweenLabel;
        private System.Windows.Forms.DateTimePicker DepartureDateTimePicker;
        private System.Windows.Forms.DateTimePicker secondDepartureDateTimePicker;
        private System.Windows.Forms.Label departureCityLabel;
        private System.Windows.Forms.ComboBox departureComboBox;
        private System.Windows.Forms.ComboBox arrivalComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label pressFlightIdLabel;
        private System.Windows.Forms.Button addButton;
    }
}