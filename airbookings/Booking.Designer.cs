namespace airbookings
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.titleLabel = new System.Windows.Forms.Label();
            this.flightContainerLabel = new System.Windows.Forms.Label();
            this.flightLabel = new System.Windows.Forms.Label();
            this.contactInfoLabel = new System.Windows.Forms.Label();
            this.departureContainerLabel = new System.Windows.Forms.Label();
            this.mainInfoLabel = new System.Windows.Forms.Label();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.sexLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.departureLabel = new System.Windows.Forms.Label();
            this.airlineLabel = new System.Windows.Forms.Label();
            this.arrivalContainerLabel = new System.Windows.Forms.Label();
            this.arrivalLabel = new System.Windows.Forms.Label();
            this.arrivalDateContainerLabel = new System.Windows.Forms.Label();
            this.arrivalDateLabel = new System.Windows.Forms.Label();
            this.departureDateContainerLabel = new System.Windows.Forms.Label();
            this.departureDateLabel = new System.Windows.Forms.Label();
            this.comfortRadioButton = new System.Windows.Forms.RadioButton();
            this.economyRadioButton = new System.Windows.Forms.RadioButton();
            this.businessRadioButton = new System.Windows.Forms.RadioButton();
            this.seatLabel = new System.Windows.Forms.Label();
            this.seatComboBox = new System.Windows.Forms.ComboBox();
            this.classGroupBox = new System.Windows.Forms.GroupBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ofBirthLabel = new System.Windows.Forms.Label();
            this.citizenshipComboBox = new System.Windows.Forms.ComboBox();
            this.citiznshipLabel = new System.Windows.Forms.Label();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.rateGroupBox = new System.Windows.Forms.GroupBox();
            this.extendedRadioButton = new System.Windows.Forms.RadioButton();
            this.standartRadioButton = new System.Windows.Forms.RadioButton();
            this.fullRadioButton = new System.Windows.Forms.RadioButton();
            this.serviceClassAndRateLabel = new System.Windows.Forms.Label();
            this.firstCatchLabel = new System.Windows.Forms.Label();
            this.secondCatchLabel = new System.Windows.Forms.Label();
            this.fourthCatchLabel = new System.Windows.Forms.Label();
            this.thirdCatchLabel = new System.Windows.Forms.Label();
            this.fifthCatchLabel = new System.Windows.Forms.Label();
            this.sixthCatchLabel = new System.Windows.Forms.Label();
            this.sevethCatchLabel = new System.Windows.Forms.Label();
            this.eighthCatchLabel = new System.Windows.Forms.Label();
            this.requiredLabel = new System.Windows.Forms.Label();
            this.addMyDataCheckBox = new System.Windows.Forms.CheckBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.airlinePictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.returnTicketButton = new System.Windows.Forms.Button();
            this.seatTextBox = new System.Windows.Forms.TextBox();
            this.classGroupBox.SuspendLayout();
            this.rateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airlinePictureBox)).BeginInit();
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
            // flightContainerLabel
            // 
            this.flightContainerLabel.AutoSize = true;
            this.flightContainerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flightContainerLabel.Location = new System.Drawing.Point(155, 110);
            this.flightContainerLabel.Name = "flightContainerLabel";
            this.flightContainerLabel.Size = new System.Drawing.Size(68, 15);
            this.flightContainerLabel.TabIndex = 64;
            this.flightContainerLabel.Text = "someflight";
            // 
            // flightLabel
            // 
            this.flightLabel.AutoSize = true;
            this.flightLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flightLabel.Location = new System.Drawing.Point(32, 110);
            this.flightLabel.Name = "flightLabel";
            this.flightLabel.Size = new System.Drawing.Size(88, 15);
            this.flightLabel.TabIndex = 63;
            this.flightLabel.Text = "Номер рейса";
            // 
            // contactInfoLabel
            // 
            this.contactInfoLabel.AutoSize = true;
            this.contactInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.contactInfoLabel.Location = new System.Drawing.Point(359, 81);
            this.contactInfoLabel.Name = "contactInfoLabel";
            this.contactInfoLabel.Size = new System.Drawing.Size(152, 19);
            this.contactInfoLabel.TabIndex = 62;
            this.contactInfoLabel.Text = "Данные пассажира";
            // 
            // departureContainerLabel
            // 
            this.departureContainerLabel.AutoSize = true;
            this.departureContainerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departureContainerLabel.Location = new System.Drawing.Point(152, 166);
            this.departureContainerLabel.Name = "departureContainerLabel";
            this.departureContainerLabel.Size = new System.Drawing.Size(97, 15);
            this.departureContainerLabel.TabIndex = 61;
            this.departureContainerLabel.Text = "somedeparture";
            // 
            // mainInfoLabel
            // 
            this.mainInfoLabel.AutoSize = true;
            this.mainInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.mainInfoLabel.Location = new System.Drawing.Point(28, 81);
            this.mainInfoLabel.Name = "mainInfoLabel";
            this.mainInfoLabel.Size = new System.Drawing.Size(131, 19);
            this.mainInfoLabel.TabIndex = 60;
            this.mainInfoLabel.Text = "Данные о рейсе";
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.femaleButton.Location = new System.Drawing.Point(509, 116);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(79, 19);
            this.femaleButton.TabIndex = 59;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "женский";
            this.femaleButton.UseVisualStyleBackColor = true;
            this.femaleButton.CheckedChanged += new System.EventHandler(this.femaleButton_CheckedChanged);
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleButton.Location = new System.Drawing.Point(427, 115);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(79, 19);
            this.maleButton.TabIndex = 58;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "мужской";
            this.maleButton.UseVisualStyleBackColor = true;
            this.maleButton.CheckedChanged += new System.EventHandler(this.maleButton_CheckedChanged);
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.Location = new System.Drawing.Point(360, 120);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(31, 15);
            this.sexLabel.TabIndex = 57;
            this.sexLabel.Text = "Пол";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.returnButton.Location = new System.Drawing.Point(592, 439);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(58, 25);
            this.returnButton.TabIndex = 54;
            this.returnButton.Text = "Назад";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.acceptButton.Location = new System.Drawing.Point(361, 438);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(225, 27);
            this.acceptButton.TabIndex = 53;
            this.acceptButton.Text = "Подтвердить бронирование";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departureLabel.Location = new System.Drawing.Point(32, 166);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(89, 15);
            this.departureLabel.TabIndex = 49;
            this.departureLabel.Text = "Отправление";
            // 
            // airlineLabel
            // 
            this.airlineLabel.AutoSize = true;
            this.airlineLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airlineLabel.Location = new System.Drawing.Point(32, 137);
            this.airlineLabel.Name = "airlineLabel";
            this.airlineLabel.Size = new System.Drawing.Size(99, 15);
            this.airlineLabel.TabIndex = 74;
            this.airlineLabel.Text = "Авиакомпания";
            // 
            // arrivalContainerLabel
            // 
            this.arrivalContainerLabel.AutoSize = true;
            this.arrivalContainerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrivalContainerLabel.Location = new System.Drawing.Point(152, 193);
            this.arrivalContainerLabel.Name = "arrivalContainerLabel";
            this.arrivalContainerLabel.Size = new System.Drawing.Size(75, 15);
            this.arrivalContainerLabel.TabIndex = 79;
            this.arrivalContainerLabel.Text = "somearrival";
            // 
            // arrivalLabel
            // 
            this.arrivalLabel.AutoSize = true;
            this.arrivalLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrivalLabel.Location = new System.Drawing.Point(32, 193);
            this.arrivalLabel.Name = "arrivalLabel";
            this.arrivalLabel.Size = new System.Drawing.Size(69, 15);
            this.arrivalLabel.TabIndex = 78;
            this.arrivalLabel.Text = "Прибытие";
            // 
            // arrivalDateContainerLabel
            // 
            this.arrivalDateContainerLabel.AutoSize = true;
            this.arrivalDateContainerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrivalDateContainerLabel.Location = new System.Drawing.Point(152, 251);
            this.arrivalDateContainerLabel.Name = "arrivalDateContainerLabel";
            this.arrivalDateContainerLabel.Size = new System.Drawing.Size(101, 15);
            this.arrivalDateContainerLabel.TabIndex = 83;
            this.arrivalDateContainerLabel.Text = "somearrivaldate";
            // 
            // arrivalDateLabel
            // 
            this.arrivalDateLabel.AutoSize = true;
            this.arrivalDateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrivalDateLabel.Location = new System.Drawing.Point(32, 251);
            this.arrivalDateLabel.Name = "arrivalDateLabel";
            this.arrivalDateLabel.Size = new System.Drawing.Size(100, 15);
            this.arrivalDateLabel.TabIndex = 82;
            this.arrivalDateLabel.Text = "Дата прибытия";
            // 
            // departureDateContainerLabel
            // 
            this.departureDateContainerLabel.AutoSize = true;
            this.departureDateContainerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departureDateContainerLabel.Location = new System.Drawing.Point(152, 222);
            this.departureDateContainerLabel.Name = "departureDateContainerLabel";
            this.departureDateContainerLabel.Size = new System.Drawing.Size(123, 15);
            this.departureDateContainerLabel.TabIndex = 81;
            this.departureDateContainerLabel.Text = "somedeparturedate";
            // 
            // departureDateLabel
            // 
            this.departureDateLabel.AutoSize = true;
            this.departureDateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departureDateLabel.Location = new System.Drawing.Point(32, 222);
            this.departureDateLabel.Name = "departureDateLabel";
            this.departureDateLabel.Size = new System.Drawing.Size(119, 15);
            this.departureDateLabel.TabIndex = 80;
            this.departureDateLabel.Text = "Дата отправления";
            // 
            // comfortRadioButton
            // 
            this.comfortRadioButton.AutoSize = true;
            this.comfortRadioButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comfortRadioButton.Location = new System.Drawing.Point(12, 41);
            this.comfortRadioButton.Name = "comfortRadioButton";
            this.comfortRadioButton.Size = new System.Drawing.Size(79, 19);
            this.comfortRadioButton.TabIndex = 86;
            this.comfortRadioButton.TabStop = true;
            this.comfortRadioButton.Text = "комфорт";
            this.comfortRadioButton.UseVisualStyleBackColor = true;
            this.comfortRadioButton.CheckedChanged += new System.EventHandler(this.comfortRadioButton_CheckedChanged);
            // 
            // economyRadioButton
            // 
            this.economyRadioButton.AutoSize = true;
            this.economyRadioButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.economyRadioButton.Location = new System.Drawing.Point(12, 18);
            this.economyRadioButton.Name = "economyRadioButton";
            this.economyRadioButton.Size = new System.Drawing.Size(71, 19);
            this.economyRadioButton.TabIndex = 85;
            this.economyRadioButton.TabStop = true;
            this.economyRadioButton.Text = "эконом";
            this.economyRadioButton.UseVisualStyleBackColor = true;
            this.economyRadioButton.CheckedChanged += new System.EventHandler(this.economyRadioButton_CheckedChanged);
            // 
            // businessRadioButton
            // 
            this.businessRadioButton.AutoSize = true;
            this.businessRadioButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.businessRadioButton.Location = new System.Drawing.Point(12, 65);
            this.businessRadioButton.Name = "businessRadioButton";
            this.businessRadioButton.Size = new System.Drawing.Size(68, 19);
            this.businessRadioButton.TabIndex = 88;
            this.businessRadioButton.TabStop = true;
            this.businessRadioButton.Text = "бизнес";
            this.businessRadioButton.UseVisualStyleBackColor = true;
            this.businessRadioButton.CheckedChanged += new System.EventHandler(this.businessRadioButton_CheckedChanged);
            // 
            // seatLabel
            // 
            this.seatLabel.AutoSize = true;
            this.seatLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatLabel.Location = new System.Drawing.Point(31, 427);
            this.seatLabel.Name = "seatLabel";
            this.seatLabel.Size = new System.Drawing.Size(45, 15);
            this.seatLabel.TabIndex = 89;
            this.seatLabel.Text = "Место";
            // 
            // seatComboBox
            // 
            this.seatComboBox.FormattingEnabled = true;
            this.seatComboBox.Location = new System.Drawing.Point(87, 425);
            this.seatComboBox.Name = "seatComboBox";
            this.seatComboBox.Size = new System.Drawing.Size(64, 21);
            this.seatComboBox.TabIndex = 90;
            this.seatComboBox.Click += new System.EventHandler(this.seatComboBox_Click);
            // 
            // classGroupBox
            // 
            this.classGroupBox.Controls.Add(this.comfortRadioButton);
            this.classGroupBox.Controls.Add(this.economyRadioButton);
            this.classGroupBox.Controls.Add(this.businessRadioButton);
            this.classGroupBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classGroupBox.Location = new System.Drawing.Point(32, 318);
            this.classGroupBox.Name = "classGroupBox";
            this.classGroupBox.Size = new System.Drawing.Size(154, 94);
            this.classGroupBox.TabIndex = 91;
            this.classGroupBox.TabStop = false;
            this.classGroupBox.Text = "Класс обслуживания";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.firstNameLabel.Location = new System.Drawing.Point(360, 146);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(33, 15);
            this.firstNameLabel.TabIndex = 92;
            this.firstNameLabel.Text = "Имя";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.middleNameLabel.Location = new System.Drawing.Point(360, 175);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(62, 15);
            this.middleNameLabel.TabIndex = 93;
            this.middleNameLabel.Text = "Отчество";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.lastNameLabel.Location = new System.Drawing.Point(360, 204);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameLabel.TabIndex = 94;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.firstNameTextBox.Location = new System.Drawing.Point(455, 142);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(133, 21);
            this.firstNameTextBox.TabIndex = 95;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.middleNameTextBox.Location = new System.Drawing.Point(455, 171);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(133, 21);
            this.middleNameTextBox.TabIndex = 96;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lastNameTextBox.Location = new System.Drawing.Point(455, 200);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(133, 21);
            this.lastNameTextBox.TabIndex = 97;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.dateLabel.Location = new System.Drawing.Point(360, 224);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 15);
            this.dateLabel.TabIndex = 98;
            this.dateLabel.Text = "Дата";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(455, 230);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 99;
            // 
            // ofBirthLabel
            // 
            this.ofBirthLabel.AutoSize = true;
            this.ofBirthLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.ofBirthLabel.Location = new System.Drawing.Point(360, 239);
            this.ofBirthLabel.Name = "ofBirthLabel";
            this.ofBirthLabel.Size = new System.Drawing.Size(70, 15);
            this.ofBirthLabel.TabIndex = 100;
            this.ofBirthLabel.Text = "рождения";
            // 
            // citizenshipComboBox
            // 
            this.citizenshipComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.citizenshipComboBox.FormattingEnabled = true;
            this.citizenshipComboBox.Location = new System.Drawing.Point(455, 262);
            this.citizenshipComboBox.Name = "citizenshipComboBox";
            this.citizenshipComboBox.Size = new System.Drawing.Size(133, 23);
            this.citizenshipComboBox.TabIndex = 102;
            // 
            // citiznshipLabel
            // 
            this.citiznshipLabel.AutoSize = true;
            this.citiznshipLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.citiznshipLabel.Location = new System.Drawing.Point(360, 267);
            this.citiznshipLabel.Name = "citiznshipLabel";
            this.citiznshipLabel.Size = new System.Drawing.Size(86, 15);
            this.citiznshipLabel.TabIndex = 101;
            this.citiznshipLabel.Text = "Гражданство";
            // 
            // seriesLabel
            // 
            this.seriesLabel.AutoSize = true;
            this.seriesLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.seriesLabel.Location = new System.Drawing.Point(360, 299);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Size = new System.Drawing.Size(45, 15);
            this.seriesLabel.TabIndex = 103;
            this.seriesLabel.Text = "Серия";
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.seriesTextBox.Location = new System.Drawing.Point(455, 295);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.Size = new System.Drawing.Size(133, 21);
            this.seriesTextBox.TabIndex = 104;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numberTextBox.Location = new System.Drawing.Point(455, 325);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(133, 21);
            this.numberTextBox.TabIndex = 106;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.numberLabel.Location = new System.Drawing.Point(360, 329);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(48, 15);
            this.numberLabel.TabIndex = 105;
            this.numberLabel.Text = "Номер";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.emailTextBox.Location = new System.Drawing.Point(455, 352);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(133, 21);
            this.emailTextBox.TabIndex = 108;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.emailLabel.Location = new System.Drawing.Point(360, 356);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 15);
            this.emailLabel.TabIndex = 107;
            this.emailLabel.Text = "Email";
            // 
            // rateGroupBox
            // 
            this.rateGroupBox.Controls.Add(this.extendedRadioButton);
            this.rateGroupBox.Controls.Add(this.standartRadioButton);
            this.rateGroupBox.Controls.Add(this.fullRadioButton);
            this.rateGroupBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateGroupBox.Location = new System.Drawing.Point(192, 318);
            this.rateGroupBox.Name = "rateGroupBox";
            this.rateGroupBox.Size = new System.Drawing.Size(126, 94);
            this.rateGroupBox.TabIndex = 92;
            this.rateGroupBox.TabStop = false;
            this.rateGroupBox.Text = "Тариф";
            // 
            // extendedRadioButton
            // 
            this.extendedRadioButton.AutoSize = true;
            this.extendedRadioButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extendedRadioButton.Location = new System.Drawing.Point(12, 41);
            this.extendedRadioButton.Name = "extendedRadioButton";
            this.extendedRadioButton.Size = new System.Drawing.Size(112, 19);
            this.extendedRadioButton.TabIndex = 86;
            this.extendedRadioButton.TabStop = true;
            this.extendedRadioButton.Text = "расширенный";
            this.extendedRadioButton.UseVisualStyleBackColor = true;
            this.extendedRadioButton.CheckedChanged += new System.EventHandler(this.extendedRadioButton_CheckedChanged);
            // 
            // standartRadioButton
            // 
            this.standartRadioButton.AutoSize = true;
            this.standartRadioButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.standartRadioButton.Location = new System.Drawing.Point(12, 18);
            this.standartRadioButton.Name = "standartRadioButton";
            this.standartRadioButton.Size = new System.Drawing.Size(103, 19);
            this.standartRadioButton.TabIndex = 85;
            this.standartRadioButton.TabStop = true;
            this.standartRadioButton.Text = "стандартный";
            this.standartRadioButton.UseVisualStyleBackColor = true;
            this.standartRadioButton.CheckedChanged += new System.EventHandler(this.standartRadioButton_CheckedChanged);
            // 
            // fullRadioButton
            // 
            this.fullRadioButton.AutoSize = true;
            this.fullRadioButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullRadioButton.Location = new System.Drawing.Point(12, 65);
            this.fullRadioButton.Name = "fullRadioButton";
            this.fullRadioButton.Size = new System.Drawing.Size(73, 19);
            this.fullRadioButton.TabIndex = 88;
            this.fullRadioButton.TabStop = true;
            this.fullRadioButton.Text = "полный";
            this.fullRadioButton.UseVisualStyleBackColor = true;
            this.fullRadioButton.CheckedChanged += new System.EventHandler(this.fullRadioButton_CheckedChanged);
            // 
            // serviceClassAndRateLabel
            // 
            this.serviceClassAndRateLabel.AutoSize = true;
            this.serviceClassAndRateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceClassAndRateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.serviceClassAndRateLabel.Location = new System.Drawing.Point(28, 285);
            this.serviceClassAndRateLabel.Name = "serviceClassAndRateLabel";
            this.serviceClassAndRateLabel.Size = new System.Drawing.Size(230, 19);
            this.serviceClassAndRateLabel.TabIndex = 109;
            this.serviceClassAndRateLabel.Text = "Класс обслуживания и тариф";
            // 
            // firstCatchLabel
            // 
            this.firstCatchLabel.AutoSize = true;
            this.firstCatchLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstCatchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.firstCatchLabel.Location = new System.Drawing.Point(386, 119);
            this.firstCatchLabel.Name = "firstCatchLabel";
            this.firstCatchLabel.Size = new System.Drawing.Size(12, 15);
            this.firstCatchLabel.TabIndex = 110;
            this.firstCatchLabel.Text = "*";
            // 
            // secondCatchLabel
            // 
            this.secondCatchLabel.AutoSize = true;
            this.secondCatchLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondCatchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.secondCatchLabel.Location = new System.Drawing.Point(388, 145);
            this.secondCatchLabel.Name = "secondCatchLabel";
            this.secondCatchLabel.Size = new System.Drawing.Size(12, 15);
            this.secondCatchLabel.TabIndex = 111;
            this.secondCatchLabel.Text = "*";
            // 
            // fourthCatchLabel
            // 
            this.fourthCatchLabel.AutoSize = true;
            this.fourthCatchLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthCatchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.fourthCatchLabel.Location = new System.Drawing.Point(425, 237);
            this.fourthCatchLabel.Name = "fourthCatchLabel";
            this.fourthCatchLabel.Size = new System.Drawing.Size(12, 15);
            this.fourthCatchLabel.TabIndex = 112;
            this.fourthCatchLabel.Text = "*";
            // 
            // thirdCatchLabel
            // 
            this.thirdCatchLabel.AutoSize = true;
            this.thirdCatchLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdCatchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.thirdCatchLabel.Location = new System.Drawing.Point(418, 202);
            this.thirdCatchLabel.Name = "thirdCatchLabel";
            this.thirdCatchLabel.Size = new System.Drawing.Size(12, 15);
            this.thirdCatchLabel.TabIndex = 113;
            this.thirdCatchLabel.Text = "*";
            // 
            // fifthCatchLabel
            // 
            this.fifthCatchLabel.AutoSize = true;
            this.fifthCatchLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fifthCatchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.fifthCatchLabel.Location = new System.Drawing.Point(441, 265);
            this.fifthCatchLabel.Name = "fifthCatchLabel";
            this.fifthCatchLabel.Size = new System.Drawing.Size(12, 15);
            this.fifthCatchLabel.TabIndex = 114;
            this.fifthCatchLabel.Text = "*";
            // 
            // sixthCatchLabel
            // 
            this.sixthCatchLabel.AutoSize = true;
            this.sixthCatchLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixthCatchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.sixthCatchLabel.Location = new System.Drawing.Point(400, 298);
            this.sixthCatchLabel.Name = "sixthCatchLabel";
            this.sixthCatchLabel.Size = new System.Drawing.Size(12, 15);
            this.sixthCatchLabel.TabIndex = 115;
            this.sixthCatchLabel.Text = "*";
            // 
            // sevethCatchLabel
            // 
            this.sevethCatchLabel.AutoSize = true;
            this.sevethCatchLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevethCatchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.sevethCatchLabel.Location = new System.Drawing.Point(403, 328);
            this.sevethCatchLabel.Name = "sevethCatchLabel";
            this.sevethCatchLabel.Size = new System.Drawing.Size(12, 15);
            this.sevethCatchLabel.TabIndex = 116;
            this.sevethCatchLabel.Text = "*";
            // 
            // eighthCatchLabel
            // 
            this.eighthCatchLabel.AutoSize = true;
            this.eighthCatchLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eighthCatchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.eighthCatchLabel.Location = new System.Drawing.Point(394, 354);
            this.eighthCatchLabel.Name = "eighthCatchLabel";
            this.eighthCatchLabel.Size = new System.Drawing.Size(12, 15);
            this.eighthCatchLabel.TabIndex = 117;
            this.eighthCatchLabel.Text = "*";
            // 
            // requiredLabel
            // 
            this.requiredLabel.AutoSize = true;
            this.requiredLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requiredLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.requiredLabel.Location = new System.Drawing.Point(360, 410);
            this.requiredLabel.Name = "requiredLabel";
            this.requiredLabel.Size = new System.Drawing.Size(211, 14);
            this.requiredLabel.TabIndex = 118;
            this.requiredLabel.Text = "* Поля обязательные для заполнения";
            // 
            // addMyDataCheckBox
            // 
            this.addMyDataCheckBox.AutoSize = true;
            this.addMyDataCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMyDataCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMyDataCheckBox.Location = new System.Drawing.Point(361, 385);
            this.addMyDataCheckBox.Name = "addMyDataCheckBox";
            this.addMyDataCheckBox.Size = new System.Drawing.Size(155, 19);
            this.addMyDataCheckBox.TabIndex = 119;
            this.addMyDataCheckBox.Text = "Вставить мои данные";
            this.addMyDataCheckBox.UseVisualStyleBackColor = true;
            this.addMyDataCheckBox.Visible = false;
            this.addMyDataCheckBox.CheckedChanged += new System.EventHandler(this.addMyDataCheckBox_CheckedChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.priceLabel.Location = new System.Drawing.Point(184, 427);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(39, 15);
            this.priceLabel.TabIndex = 120;
            this.priceLabel.Text = "Цена";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.priceTextBox.Location = new System.Drawing.Point(235, 425);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(76, 21);
            this.priceTextBox.TabIndex = 121;
            // 
            // airlinePictureBox
            // 
            this.airlinePictureBox.Location = new System.Drawing.Point(156, 134);
            this.airlinePictureBox.Name = "airlinePictureBox";
            this.airlinePictureBox.Size = new System.Drawing.Size(75, 21);
            this.airlinePictureBox.TabIndex = 75;
            this.airlinePictureBox.TabStop = false;
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
            // returnTicketButton
            // 
            this.returnTicketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.returnTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnTicketButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnTicketButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnTicketButton.Location = new System.Drawing.Point(361, 439);
            this.returnTicketButton.Name = "returnTicketButton";
            this.returnTicketButton.Size = new System.Drawing.Size(225, 27);
            this.returnTicketButton.TabIndex = 122;
            this.returnTicketButton.Text = "Отменить бронирование";
            this.returnTicketButton.UseVisualStyleBackColor = false;
            this.returnTicketButton.Visible = false;
            this.returnTicketButton.Click += new System.EventHandler(this.returnTicketButton_Click);
            // 
            // seatTextBox
            // 
            this.seatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.seatTextBox.Location = new System.Drawing.Point(87, 425);
            this.seatTextBox.Name = "seatTextBox";
            this.seatTextBox.Size = new System.Drawing.Size(64, 21);
            this.seatTextBox.TabIndex = 123;
            this.seatTextBox.Visible = false;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(664, 478);
            this.Controls.Add(this.seatTextBox);
            this.Controls.Add(this.returnTicketButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.addMyDataCheckBox);
            this.Controls.Add(this.requiredLabel);
            this.Controls.Add(this.eighthCatchLabel);
            this.Controls.Add(this.sevethCatchLabel);
            this.Controls.Add(this.sixthCatchLabel);
            this.Controls.Add(this.fifthCatchLabel);
            this.Controls.Add(this.thirdCatchLabel);
            this.Controls.Add(this.fourthCatchLabel);
            this.Controls.Add(this.secondCatchLabel);
            this.Controls.Add(this.firstCatchLabel);
            this.Controls.Add(this.serviceClassAndRateLabel);
            this.Controls.Add(this.rateGroupBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.seriesTextBox);
            this.Controls.Add(this.seriesLabel);
            this.Controls.Add(this.citizenshipComboBox);
            this.Controls.Add(this.citiznshipLabel);
            this.Controls.Add(this.ofBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.classGroupBox);
            this.Controls.Add(this.seatComboBox);
            this.Controls.Add(this.seatLabel);
            this.Controls.Add(this.airlineLabel);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.departureContainerLabel);
            this.Controls.Add(this.flightLabel);
            this.Controls.Add(this.flightContainerLabel);
            this.Controls.Add(this.arrivalDateContainerLabel);
            this.Controls.Add(this.airlinePictureBox);
            this.Controls.Add(this.arrivalDateLabel);
            this.Controls.Add(this.arrivalLabel);
            this.Controls.Add(this.mainInfoLabel);
            this.Controls.Add(this.contactInfoLabel);
            this.Controls.Add(this.departureDateContainerLabel);
            this.Controls.Add(this.arrivalContainerLabel);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.departureDateLabel);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logoPictureBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бронирование";
            this.Load += new System.EventHandler(this.BuyATicket_Load);
            this.classGroupBox.ResumeLayout(false);
            this.classGroupBox.PerformLayout();
            this.rateGroupBox.ResumeLayout(false);
            this.rateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airlinePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label flightContainerLabel;
        private System.Windows.Forms.Label flightLabel;
        private System.Windows.Forms.Label contactInfoLabel;
        private System.Windows.Forms.Label departureContainerLabel;
        private System.Windows.Forms.Label mainInfoLabel;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.Label airlineLabel;
        private System.Windows.Forms.PictureBox airlinePictureBox;
        private System.Windows.Forms.Label arrivalContainerLabel;
        private System.Windows.Forms.Label arrivalLabel;
        private System.Windows.Forms.Label arrivalDateContainerLabel;
        private System.Windows.Forms.Label arrivalDateLabel;
        private System.Windows.Forms.Label departureDateContainerLabel;
        private System.Windows.Forms.Label departureDateLabel;
        private System.Windows.Forms.RadioButton comfortRadioButton;
        private System.Windows.Forms.RadioButton economyRadioButton;
        private System.Windows.Forms.RadioButton businessRadioButton;
        private System.Windows.Forms.Label seatLabel;
        private System.Windows.Forms.ComboBox seatComboBox;
        private System.Windows.Forms.GroupBox classGroupBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Label ofBirthLabel;
        private System.Windows.Forms.ComboBox citizenshipComboBox;
        private System.Windows.Forms.Label citiznshipLabel;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.GroupBox rateGroupBox;
        private System.Windows.Forms.RadioButton extendedRadioButton;
        private System.Windows.Forms.RadioButton standartRadioButton;
        private System.Windows.Forms.RadioButton fullRadioButton;
        private System.Windows.Forms.Label serviceClassAndRateLabel;
        private System.Windows.Forms.Label firstCatchLabel;
        private System.Windows.Forms.Label secondCatchLabel;
        private System.Windows.Forms.Label fourthCatchLabel;
        private System.Windows.Forms.Label thirdCatchLabel;
        private System.Windows.Forms.Label fifthCatchLabel;
        private System.Windows.Forms.Label sixthCatchLabel;
        private System.Windows.Forms.Label sevethCatchLabel;
        private System.Windows.Forms.Label eighthCatchLabel;
        private System.Windows.Forms.Label requiredLabel;
        private System.Windows.Forms.CheckBox addMyDataCheckBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button returnTicketButton;
        private System.Windows.Forms.TextBox seatTextBox;
    }
}