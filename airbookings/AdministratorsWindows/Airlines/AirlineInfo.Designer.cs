namespace airbookings
{
    partial class AirlineInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirlineInfo));
            this.deleteButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.airlineDataLabel = new System.Windows.Forms.Label();
            this.IATALabel = new System.Windows.Forms.Label();
            this.ICAOLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.IATATextBox = new System.Windows.Forms.TextBox();
            this.ICAOTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.imageLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(181, 234);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 26);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Удалить авиакомпанию";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.returnButton.Location = new System.Drawing.Point(279, 266);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(64, 25);
            this.returnButton.TabIndex = 12;
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
            this.saveButton.Location = new System.Drawing.Point(68, 234);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 27);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            // airlineDataLabel
            // 
            this.airlineDataLabel.AutoSize = true;
            this.airlineDataLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airlineDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.airlineDataLabel.Location = new System.Drawing.Point(61, 71);
            this.airlineDataLabel.Name = "airlineDataLabel";
            this.airlineDataLabel.Size = new System.Drawing.Size(174, 19);
            this.airlineDataLabel.TabIndex = 1;
            this.airlineDataLabel.Text = "Данные авикомпании";
            // 
            // IATALabel
            // 
            this.IATALabel.AutoSize = true;
            this.IATALabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IATALabel.Location = new System.Drawing.Point(65, 114);
            this.IATALabel.Name = "IATALabel";
            this.IATALabel.Size = new System.Drawing.Size(40, 15);
            this.IATALabel.TabIndex = 2;
            this.IATALabel.Text = "ИАТА";
            // 
            // ICAOLabel
            // 
            this.ICAOLabel.AutoSize = true;
            this.ICAOLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ICAOLabel.Location = new System.Drawing.Point(65, 170);
            this.ICAOLabel.Name = "ICAOLabel";
            this.ICAOLabel.Size = new System.Drawing.Size(43, 15);
            this.ICAOLabel.TabIndex = 6;
            this.ICAOLabel.Text = "ИКАО";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(65, 141);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(66, 15);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Название";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nameTextBox.Location = new System.Drawing.Point(165, 139);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(119, 21);
            this.nameTextBox.TabIndex = 5;
            // 
            // IATATextBox
            // 
            this.IATATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.IATATextBox.Location = new System.Drawing.Point(165, 110);
            this.IATATextBox.Name = "IATATextBox";
            this.IATATextBox.Size = new System.Drawing.Size(119, 21);
            this.IATATextBox.TabIndex = 3;
            // 
            // ICAOTextBox
            // 
            this.ICAOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ICAOTextBox.Location = new System.Drawing.Point(165, 164);
            this.ICAOTextBox.Name = "ICAOTextBox";
            this.ICAOTextBox.Size = new System.Drawing.Size(119, 21);
            this.ICAOTextBox.TabIndex = 7;
            // 
            // imageTextBox
            // 
            this.imageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.imageTextBox.Location = new System.Drawing.Point(165, 191);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(119, 21);
            this.imageTextBox.TabIndex = 9;
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imageLabel.Location = new System.Drawing.Point(65, 197);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(94, 15);
            this.imageLabel.TabIndex = 8;
            this.imageLabel.Text = "Изображение";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::airbookings.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(42, 41);
            this.logoPictureBox.TabIndex = 49;
            this.logoPictureBox.TabStop = false;
            // 
            // AirlineInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(355, 302);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.ICAOTextBox);
            this.Controls.Add(this.IATATextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.ICAOLabel);
            this.Controls.Add(this.IATALabel);
            this.Controls.Add(this.airlineDataLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AirlineInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о авиалиниях";
            this.Load += new System.EventHandler(this.AirlineInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label airlineDataLabel;
        private System.Windows.Forms.Label IATALabel;
        private System.Windows.Forms.Label ICAOLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox IATATextBox;
        private System.Windows.Forms.TextBox ICAOTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.Label imageLabel;
    }
}