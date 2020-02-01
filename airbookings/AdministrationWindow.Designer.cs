namespace airbookings
{
    partial class AdministrationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationWindow));
            this.titleLabel = new System.Windows.Forms.Label();
            this.airlinesButton = new System.Windows.Forms.Button();
            this.airportsButton = new System.Windows.Forms.Button();
            this.flightsButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
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
            // airlinesButton
            // 
            this.airlinesButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.airlinesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.airlinesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.airlinesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.airlinesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.airlinesButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airlinesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.airlinesButton.Location = new System.Drawing.Point(35, 80);
            this.airlinesButton.Name = "airlinesButton";
            this.airlinesButton.Size = new System.Drawing.Size(161, 27);
            this.airlinesButton.TabIndex = 1;
            this.airlinesButton.TabStop = false;
            this.airlinesButton.Text = "Авиалинии";
            this.airlinesButton.UseVisualStyleBackColor = false;
            this.airlinesButton.Click += new System.EventHandler(this.airlinesButton_Click);
            // 
            // airportsButton
            // 
            this.airportsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.airportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.airportsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airportsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.airportsButton.Location = new System.Drawing.Point(35, 114);
            this.airportsButton.Name = "airportsButton";
            this.airportsButton.Size = new System.Drawing.Size(161, 27);
            this.airportsButton.TabIndex = 2;
            this.airportsButton.Text = "Аэропорты";
            this.airportsButton.UseVisualStyleBackColor = false;
            this.airportsButton.Click += new System.EventHandler(this.airportsButton_Click);
            // 
            // flightsButton
            // 
            this.flightsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flightsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flightsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flightsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.flightsButton.Location = new System.Drawing.Point(35, 147);
            this.flightsButton.Name = "flightsButton";
            this.flightsButton.Size = new System.Drawing.Size(161, 27);
            this.flightsButton.TabIndex = 3;
            this.flightsButton.Text = "Рейсы";
            this.flightsButton.UseVisualStyleBackColor = false;
            this.flightsButton.Click += new System.EventHandler(this.flightsButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(199)))));
            this.returnButton.Location = new System.Drawing.Point(157, 197);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(64, 25);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Назад";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
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
            // AdministrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(232, 234);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.flightsButton);
            this.Controls.Add(this.airlinesButton);
            this.Controls.Add(this.airportsButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdministrationWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администрирования";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button airlinesButton;
        private System.Windows.Forms.Button airportsButton;
        private System.Windows.Forms.Button flightsButton;
        private System.Windows.Forms.Button returnButton;
    }
}