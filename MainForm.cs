using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boat_rental
{
    public partial class MainForm : Form
    {
        DataManagement dataManagement;
        public MainForm()
        {
            InitializeComponent();

            StartForm startForm = new StartForm();
            startForm.Show();
            startForm.progress();

            Thread.Sleep(3000);
            startForm.Close();

            monthCalendar1.MinDate = DateTime.Now;
            monthCalendar1.MaxDate = DateTime.Now.AddMonths(2);
            
            this.dataManagement = new DataManagement();
            updateDropdown();
        }

        // ??? PROTECTED ???
        public void updateDropdown()
        {
            try
            {
                comboBox1.SelectedItem = null;

                textBox_customer_firstName.Text = "";
                textBox_customer_lastName.Text = "";
                maskedTextBox_customer_birthDate.Text = "";

                comboBox2.SelectedItem = null;

                // Getting the selected day
                string date = monthCalendar1.SelectionStart.ToString("dd.MM.yyyy");
                // List with booked boats
                List<int> bookedBoats = new List<int>();

                // Getting all the time slots from the db
                DataTable dayTimeSlotTable = this.dataManagement.getDatabaseObjects("TimeSlot");

                // Adding to the List boat nr ALREADY booked for that day
                foreach (DataRow dataRow in dayTimeSlotTable.Rows)
                {
                    if (dataRow["day"].ToString().Remove(10).Trim() == date)
                    {
                        bookedBoats.Add((int)dataRow["boatNr"]);
                    }
                }

                // Getting all the boats from the db
                DataTable boatTable = new DataManagement().getDatabaseObjects("boat");
                if (boatTable != null)
                {
                    // Clearing the box in case it is being updated after a new boat was added
                    // If the box IS NOT cleared, there will be duplicate boat numbers
                    comboBox1.Items.Clear();
                    foreach (DataRow dataRow in boatTable.Rows)
                    {
                        // Checking for the boat TO NOT BE in the List with BOOKED boats
                        if (!bookedBoats.Contains((int)dataRow["boatNr"]))
                        {
                            comboBox1.Items.Add((int)dataRow["boatNr"]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Try to restart the application.");
                }

                // Getting all the customers from the db
                DataTable customerTable = new DataManagement().getDatabaseObjects("customer");
                if (customerTable != null)
                {
                    // Clearing the box in case it is being updated after a new boat was added
                    // If the box IS NOT cleared, there will be duplicate boat numbers
                    comboBox2.Items.Clear();
                    foreach (DataRow dataRow in customerTable.Rows)
                    {
                        comboBox2.Items.Add((int)dataRow["Id"]);
                    }
                }
                else
                {
                    MessageBox.Show("Try to restart the application.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void manageBoatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoatAdmin boatAdmin = new BoatAdmin(this);
            boatAdmin.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void checkStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerAdmin customer = new CustomerAdmin(this);
            customer.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DayStatistics statistics = new DayStatistics(this);
            statistics.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            updateDropdown();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Preventing an error when the box is cleared (occurs when a day is picked)
            if (comboBox2.SelectedItem == null)
            {
                return;
            }
            int customerId = (int)comboBox2.SelectedItem;
            DataTable customerTable = new DataManagement().getDatabaseObjects("customer");

            foreach (DataRow dataRow in customerTable.Rows)
            {
                if ((int)dataRow["Id"] == customerId)
                {
                    textBox_customer_firstName.Text = dataRow["firstName"].ToString();
                    textBox_customer_lastName.Text = dataRow["lastName"].ToString();
                    maskedTextBox_customer_birthDate.Text = dataRow["birthDate"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime day = monthCalendar1.SelectionStart;
                int startTimeHour = int.Parse(maskedTextBox_startTime.Text.Split(':')[0]);
                int startTimeMin = int.Parse(maskedTextBox_startTime.Text.Split(':')[1]);

                int endTimeHour = int.Parse(maskedTextBox_endTime.Text.Split(':')[0]);
                int endTimeMin = int.Parse(maskedTextBox_endTime.Text.Split(':')[1]);

                DateTime startTime = new DateTime(day.Year, day.Month, day.Day, startTimeHour, startTimeMin, 0);
                DateTime endTime = new DateTime(day.Year, day.Month, day.Day, endTimeHour, endTimeMin, 0);

                int boatNr = (int)comboBox1.SelectedItem;
                int customerId = (int)comboBox2.SelectedItem;
                
                double boatDamage = double.Parse(textBox_boat_damage.Text);
                double boatFuelConsumption = double.Parse(textBox_boat_fuel_consumption.Text);

                TimeSlot timeSlot = new TimeSlot(day, startTime, endTime, boatNr, customerId);
                timeSlot.FuelConsumption = boatFuelConsumption;

                Boat insertedBoat = timeSlot.Boat;
                insertedBoat.Damage = boatDamage;

                timeSlot.Boat = insertedBoat;
                this.dataManagement.insertObjectDatabase(timeSlot);

                MessageBox.Show("Time slot added!");
                updateDropdown();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
