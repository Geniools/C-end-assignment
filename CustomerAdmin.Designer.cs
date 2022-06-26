namespace boat_rental
{
    partial class CustomerAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_new_button = new System.Windows.Forms.Button();
            this.textBox_create_lastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_create_firstName = new System.Windows.Forms.TextBox();
            this.textBox_birthDate = new System.Windows.Forms.MaskedTextBox();
            this.textBox_create_birthDate = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1472, 915);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_birthDate);
            this.tabPage1.Controls.Add(this.delete_button);
            this.tabPage1.Controls.Add(this.update_button);
            this.tabPage1.Controls.Add(this.textBox_lastName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_firstName);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1452, 858);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage costumers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Enabled = false;
            this.delete_button.Location = new System.Drawing.Point(997, 606);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(252, 85);
            this.delete_button.TabIndex = 38;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Enabled = false;
            this.update_button.Location = new System.Drawing.Point(718, 606);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(252, 85);
            this.update_button.TabIndex = 37;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Enabled = false;
            this.textBox_lastName.Location = new System.Drawing.Point(822, 321);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(394, 35);
            this.textBox_lastName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Birth date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "First name";
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Enabled = false;
            this.textBox_firstName.Location = new System.Drawing.Point(822, 215);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(394, 35);
            this.textBox_firstName.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(822, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(456, 37);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select a costumer you want to edit";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_create_birthDate);
            this.tabPage2.Controls.Add(this.add_new_button);
            this.tabPage2.Controls.Add(this.textBox_create_lastName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox_create_firstName);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1452, 858);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add new costumer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_new_button
            // 
            this.add_new_button.Location = new System.Drawing.Point(946, 544);
            this.add_new_button.Name = "add_new_button";
            this.add_new_button.Size = new System.Drawing.Size(252, 85);
            this.add_new_button.TabIndex = 38;
            this.add_new_button.Text = "Add new customer";
            this.add_new_button.UseVisualStyleBackColor = true;
            this.add_new_button.Click += new System.EventHandler(this.add_new_button_Click);
            // 
            // textBox_create_lastName
            // 
            this.textBox_create_lastName.Location = new System.Drawing.Point(804, 248);
            this.textBox_create_lastName.Name = "textBox_create_lastName";
            this.textBox_create_lastName.Size = new System.Drawing.Size(394, 35);
            this.textBox_create_lastName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Birth date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Last name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "First name";
            // 
            // textBox_create_firstName
            // 
            this.textBox_create_firstName.Location = new System.Drawing.Point(804, 142);
            this.textBox_create_firstName.Name = "textBox_create_firstName";
            this.textBox_create_firstName.Size = new System.Drawing.Size(394, 35);
            this.textBox_create_firstName.TabIndex = 10;
            // 
            // textBox_birthDate
            // 
            this.textBox_birthDate.Enabled = false;
            this.textBox_birthDate.Location = new System.Drawing.Point(822, 435);
            this.textBox_birthDate.Mask = "00/00/0000";
            this.textBox_birthDate.Name = "textBox_birthDate";
            this.textBox_birthDate.Size = new System.Drawing.Size(394, 35);
            this.textBox_birthDate.TabIndex = 39;
            this.textBox_birthDate.ValidatingType = typeof(System.DateTime);
            // 
            // textBox_create_birthDate
            // 
            this.textBox_create_birthDate.Location = new System.Drawing.Point(804, 362);
            this.textBox_create_birthDate.Mask = "00/00/0000";
            this.textBox_create_birthDate.Name = "textBox_create_birthDate";
            this.textBox_create_birthDate.Size = new System.Drawing.Size(394, 35);
            this.textBox_create_birthDate.TabIndex = 40;
            this.textBox_create_birthDate.ValidatingType = typeof(System.DateTime);
            // 
            // CustomerAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 921);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MinimumSize = new System.Drawing.Size(1500, 1000);
            this.Name = "CustomerAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerAdmin_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button add_new_button;
        private System.Windows.Forms.TextBox textBox_create_lastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_create_firstName;
        private System.Windows.Forms.MaskedTextBox textBox_birthDate;
        private System.Windows.Forms.MaskedTextBox textBox_create_birthDate;
    }
}