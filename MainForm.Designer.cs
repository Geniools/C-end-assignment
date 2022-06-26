namespace boat_rental
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageBoatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_customer_firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_customer_lastName = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox_customer_birthDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_endTime = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox_startTime = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_boat_damage = new System.Windows.Forms.TextBox();
            this.textBox_boat_fuel_consumption = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageBoatsToolStripMenuItem,
            this.checkStatisticsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1472, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageBoatsToolStripMenuItem
            // 
            this.manageBoatsToolStripMenuItem.Name = "manageBoatsToolStripMenuItem";
            this.manageBoatsToolStripMenuItem.Size = new System.Drawing.Size(208, 50);
            this.manageBoatsToolStripMenuItem.Text = "Manage Boats";
            this.manageBoatsToolStripMenuItem.Click += new System.EventHandler(this.manageBoatsToolStripMenuItem_Click);
            // 
            // checkStatisticsToolStripMenuItem
            // 
            this.checkStatisticsToolStripMenuItem.Name = "checkStatisticsToolStripMenuItem";
            this.checkStatisticsToolStripMenuItem.Size = new System.Drawing.Size(263, 50);
            this.checkStatisticsToolStripMenuItem.Text = "Manage customers";
            this.checkStatisticsToolStripMenuItem.Click += new System.EventHandler(this.checkStatisticsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(217, 50);
            this.aboutToolStripMenuItem.Text = "Check statistics";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(112, 50);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register a boat for a day:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(540, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 37);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox_customer_firstName
            // 
            this.textBox_customer_firstName.Enabled = false;
            this.textBox_customer_firstName.Location = new System.Drawing.Point(540, 356);
            this.textBox_customer_firstName.Name = "textBox_customer_firstName";
            this.textBox_customer_firstName.Size = new System.Drawing.Size(242, 35);
            this.textBox_customer_firstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Boat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer first name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Customer last name";
            // 
            // textBox_customer_lastName
            // 
            this.textBox_customer_lastName.Enabled = false;
            this.textBox_customer_lastName.Location = new System.Drawing.Point(540, 421);
            this.textBox_customer_lastName.Name = "textBox_customer_lastName";
            this.textBox_customer_lastName.Size = new System.Drawing.Size(242, 35);
            this.textBox_customer_lastName.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(896, 290);
            this.monthCalendar1.MaxDate = new System.DateTime(2022, 8, 5, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1028, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select renting DAY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Customer birth date";
            // 
            // maskedTextBox_customer_birthDate
            // 
            this.maskedTextBox_customer_birthDate.Enabled = false;
            this.maskedTextBox_customer_birthDate.Location = new System.Drawing.Point(541, 490);
            this.maskedTextBox_customer_birthDate.Mask = "00/00/0000";
            this.maskedTextBox_customer_birthDate.Name = "maskedTextBox_customer_birthDate";
            this.maskedTextBox_customer_birthDate.Size = new System.Drawing.Size(241, 35);
            this.maskedTextBox_customer_birthDate.TabIndex = 11;
            this.maskedTextBox_customer_birthDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_endTime
            // 
            this.maskedTextBox_endTime.Location = new System.Drawing.Point(544, 617);
            this.maskedTextBox_endTime.Mask = "00:00";
            this.maskedTextBox_endTime.Name = "maskedTextBox_endTime";
            this.maskedTextBox_endTime.Size = new System.Drawing.Size(241, 35);
            this.maskedTextBox_endTime.TabIndex = 13;
            this.maskedTextBox_endTime.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 617);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ending time";
            // 
            // maskedTextBox_startTime
            // 
            this.maskedTextBox_startTime.Location = new System.Drawing.Point(544, 555);
            this.maskedTextBox_startTime.Mask = "00:00";
            this.maskedTextBox_startTime.Name = "maskedTextBox_startTime";
            this.maskedTextBox_startTime.Size = new System.Drawing.Size(241, 35);
            this.maskedTextBox_startTime.TabIndex = 15;
            this.maskedTextBox_startTime.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 555);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Starting time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1017, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 81);
            this.button1.TabIndex = 16;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Customer";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(540, 282);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(242, 37);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem2,
            this.hideToolStripMenuItem,
            this.showToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 136);
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(167, 44);
            this.aboutToolStripMenuItem2.Text = "About";
            this.aboutToolStripMenuItem2.Click += new System.EventHandler(this.aboutToolStripMenuItem2_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(167, 44);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(167, 44);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 682);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Damage";
            // 
            // textBox_boat_damage
            // 
            this.textBox_boat_damage.Location = new System.Drawing.Point(544, 682);
            this.textBox_boat_damage.Name = "textBox_boat_damage";
            this.textBox_boat_damage.Size = new System.Drawing.Size(242, 35);
            this.textBox_boat_damage.TabIndex = 20;
            // 
            // textBox_boat_fuel_consumption
            // 
            this.textBox_boat_fuel_consumption.Location = new System.Drawing.Point(544, 752);
            this.textBox_boat_fuel_consumption.Name = "textBox_boat_fuel_consumption";
            this.textBox_boat_fuel_consumption.Size = new System.Drawing.Size(242, 35);
            this.textBox_boat_fuel_consumption.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 752);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 29);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fuel Consumption";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 921);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_boat_fuel_consumption);
            this.Controls.Add(this.textBox_boat_damage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox_startTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBox_endTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBox_customer_birthDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox_customer_lastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_customer_firstName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MinimumSize = new System.Drawing.Size(1500, 1000);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageBoatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_customer_firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_customer_lastName;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_customer_birthDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_endTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_startTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_boat_damage;
        private System.Windows.Forms.TextBox textBox_boat_fuel_consumption;
        private System.Windows.Forms.Label label11;
    }
}