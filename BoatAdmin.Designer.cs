namespace boat_rental
{
    partial class BoatAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoatAdmin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.delete_boat_button = new System.Windows.Forms.Button();
            this.update_boat_button = new System.Windows.Forms.Button();
            this.boat_damage = new System.Windows.Forms.MaskedTextBox();
            this.boat_rental_price = new System.Windows.Forms.MaskedTextBox();
            this.boat_engine_power = new System.Windows.Forms.MaskedTextBox();
            this.boat_lenght = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weight_input_textbox = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.damage_label = new System.Windows.Forms.Label();
            this.rental_price_label = new System.Windows.Forms.Label();
            this.engine_power_label = new System.Windows.Forms.Label();
            this.lenght_label = new System.Windows.Forms.Label();
            this.weight_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.damage_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.rental_price_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.engine_power_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.lenght_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.weight_masked_box = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1472, 922);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.delete_boat_button);
            this.tabPage1.Controls.Add(this.update_boat_button);
            this.tabPage1.Controls.Add(this.boat_damage);
            this.tabPage1.Controls.Add(this.boat_rental_price);
            this.tabPage1.Controls.Add(this.boat_engine_power);
            this.tabPage1.Controls.Add(this.boat_lenght);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.weight_input_textbox);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.damage_label);
            this.tabPage1.Controls.Add(this.rental_price_label);
            this.tabPage1.Controls.Add(this.engine_power_label);
            this.tabPage1.Controls.Add(this.lenght_label);
            this.tabPage1.Controls.Add(this.weight_label);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1452, 865);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Update boats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // delete_boat_button
            // 
            this.delete_boat_button.Enabled = false;
            this.delete_boat_button.Location = new System.Drawing.Point(875, 655);
            this.delete_boat_button.Name = "delete_boat_button";
            this.delete_boat_button.Size = new System.Drawing.Size(252, 85);
            this.delete_boat_button.TabIndex = 36;
            this.delete_boat_button.Text = "Delete";
            this.delete_boat_button.UseVisualStyleBackColor = true;
            this.delete_boat_button.Click += new System.EventHandler(this.delete_boat_button_Click);
            // 
            // update_boat_button
            // 
            this.update_boat_button.Enabled = false;
            this.update_boat_button.Location = new System.Drawing.Point(596, 655);
            this.update_boat_button.Name = "update_boat_button";
            this.update_boat_button.Size = new System.Drawing.Size(252, 85);
            this.update_boat_button.TabIndex = 35;
            this.update_boat_button.Text = "Update";
            this.update_boat_button.UseVisualStyleBackColor = true;
            this.update_boat_button.Click += new System.EventHandler(this.update_boat_button_Click);
            // 
            // boat_damage
            // 
            this.boat_damage.Enabled = false;
            this.boat_damage.Location = new System.Drawing.Point(713, 539);
            this.boat_damage.Name = "boat_damage";
            this.boat_damage.Size = new System.Drawing.Size(177, 35);
            this.boat_damage.TabIndex = 34;
            // 
            // boat_rental_price
            // 
            this.boat_rental_price.Enabled = false;
            this.boat_rental_price.Location = new System.Drawing.Point(713, 447);
            this.boat_rental_price.Name = "boat_rental_price";
            this.boat_rental_price.Size = new System.Drawing.Size(177, 35);
            this.boat_rental_price.TabIndex = 33;
            // 
            // boat_engine_power
            // 
            this.boat_engine_power.Enabled = false;
            this.boat_engine_power.Location = new System.Drawing.Point(713, 353);
            this.boat_engine_power.Name = "boat_engine_power";
            this.boat_engine_power.Size = new System.Drawing.Size(177, 35);
            this.boat_engine_power.TabIndex = 32;
            // 
            // boat_lenght
            // 
            this.boat_lenght.Enabled = false;
            this.boat_lenght.Location = new System.Drawing.Point(713, 261);
            this.boat_lenght.Name = "boat_lenght";
            this.boat_lenght.Size = new System.Drawing.Size(177, 35);
            this.boat_lenght.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1092, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(953, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "euro (per hour)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1081, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1077, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "CM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1080, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "KG";
            // 
            // weight_input_textbox
            // 
            this.weight_input_textbox.Enabled = false;
            this.weight_input_textbox.Location = new System.Drawing.Point(713, 169);
            this.weight_input_textbox.Name = "weight_input_textbox";
            this.weight_input_textbox.Size = new System.Drawing.Size(177, 35);
            this.weight_input_textbox.TabIndex = 25;
            this.weight_input_textbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(926, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 37);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Select the boat nr you want to edit:";
            // 
            // damage_label
            // 
            this.damage_label.AutoSize = true;
            this.damage_label.Location = new System.Drawing.Point(259, 539);
            this.damage_label.Name = "damage_label";
            this.damage_label.Size = new System.Drawing.Size(104, 29);
            this.damage_label.TabIndex = 22;
            this.damage_label.Text = "Damage";
            // 
            // rental_price_label
            // 
            this.rental_price_label.AutoSize = true;
            this.rental_price_label.Location = new System.Drawing.Point(259, 450);
            this.rental_price_label.Name = "rental_price_label";
            this.rental_price_label.Size = new System.Drawing.Size(142, 29);
            this.rental_price_label.TabIndex = 21;
            this.rental_price_label.Text = "Rental price";
            // 
            // engine_power_label
            // 
            this.engine_power_label.AutoSize = true;
            this.engine_power_label.Location = new System.Drawing.Point(259, 353);
            this.engine_power_label.Name = "engine_power_label";
            this.engine_power_label.Size = new System.Drawing.Size(165, 29);
            this.engine_power_label.TabIndex = 20;
            this.engine_power_label.Text = "Engine Power";
            // 
            // lenght_label
            // 
            this.lenght_label.AutoSize = true;
            this.lenght_label.Location = new System.Drawing.Point(259, 261);
            this.lenght_label.Name = "lenght_label";
            this.lenght_label.Size = new System.Drawing.Size(86, 29);
            this.lenght_label.TabIndex = 19;
            this.lenght_label.Text = "Lenght";
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Location = new System.Drawing.Point(259, 172);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(88, 29);
            this.weight_label.TabIndex = 18;
            this.weight_label.Text = "Weight";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.damage_masked_box);
            this.tabPage2.Controls.Add(this.rental_price_masked_box);
            this.tabPage2.Controls.Add(this.engine_power_masked_box);
            this.tabPage2.Controls.Add(this.lenght_masked_box);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.weight_masked_box);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1452, 865);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add new boat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(878, 626);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 85);
            this.button2.TabIndex = 51;
            this.button2.Text = "Add new boat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // damage_masked_box
            // 
            this.damage_masked_box.Location = new System.Drawing.Point(716, 501);
            this.damage_masked_box.Name = "damage_masked_box";
            this.damage_masked_box.Size = new System.Drawing.Size(177, 35);
            this.damage_masked_box.TabIndex = 50;
            // 
            // rental_price_masked_box
            // 
            this.rental_price_masked_box.Location = new System.Drawing.Point(716, 409);
            this.rental_price_masked_box.Name = "rental_price_masked_box";
            this.rental_price_masked_box.Size = new System.Drawing.Size(177, 35);
            this.rental_price_masked_box.TabIndex = 49;
            // 
            // engine_power_masked_box
            // 
            this.engine_power_masked_box.Location = new System.Drawing.Point(716, 315);
            this.engine_power_masked_box.Name = "engine_power_masked_box";
            this.engine_power_masked_box.Size = new System.Drawing.Size(177, 35);
            this.engine_power_masked_box.TabIndex = 48;
            // 
            // lenght_masked_box
            // 
            this.lenght_masked_box.Location = new System.Drawing.Point(716, 223);
            this.lenght_masked_box.Name = "lenght_masked_box";
            this.lenght_masked_box.Size = new System.Drawing.Size(177, 35);
            this.lenght_masked_box.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1095, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 29);
            this.label7.TabIndex = 46;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(956, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 29);
            this.label8.TabIndex = 45;
            this.label8.Text = "euro (per hour)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1084, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 29);
            this.label9.TabIndex = 44;
            this.label9.Text = "HP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1080, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 29);
            this.label10.TabIndex = 43;
            this.label10.Text = "CM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1083, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 29);
            this.label11.TabIndex = 42;
            this.label11.Text = "KG";
            // 
            // weight_masked_box
            // 
            this.weight_masked_box.Location = new System.Drawing.Point(716, 131);
            this.weight_masked_box.Name = "weight_masked_box";
            this.weight_masked_box.Size = new System.Drawing.Size(177, 35);
            this.weight_masked_box.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 501);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 29);
            this.label12.TabIndex = 40;
            this.label12.Text = "Damage";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 29);
            this.label13.TabIndex = 39;
            this.label13.Text = "Rental price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 29);
            this.label14.TabIndex = 38;
            this.label14.Text = "Engine Power";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(262, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 29);
            this.label15.TabIndex = 37;
            this.label15.Text = "Lenght";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(262, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 29);
            this.label16.TabIndex = 36;
            this.label16.Text = "Weight";
            // 
            // BoatAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 921);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MinimumSize = new System.Drawing.Size(1500, 1000);
            this.Name = "BoatAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoatAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoatAdmin_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button update_boat_button;
        private System.Windows.Forms.MaskedTextBox boat_damage;
        private System.Windows.Forms.MaskedTextBox boat_rental_price;
        private System.Windows.Forms.MaskedTextBox boat_engine_power;
        private System.Windows.Forms.MaskedTextBox boat_lenght;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox weight_input_textbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label damage_label;
        private System.Windows.Forms.Label rental_price_label;
        private System.Windows.Forms.Label engine_power_label;
        private System.Windows.Forms.Label lenght_label;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button delete_boat_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox damage_masked_box;
        private System.Windows.Forms.MaskedTextBox rental_price_masked_box;
        private System.Windows.Forms.MaskedTextBox engine_power_masked_box;
        private System.Windows.Forms.MaskedTextBox lenght_masked_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox weight_masked_box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}