using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boat_rental
{
    public partial class DayStatistics : Form
    {
        private DataManagement dataManagement;
        private DataTable dayTimeSlots;
        private MainForm mainForm;
        
        public DayStatistics(MainForm mainForm)
        {
            InitializeComponent();
            
            this.mainForm = mainForm;
            mainForm.Hide();
            
            this.dataManagement = new DataManagement();
            fillDayTimeSlots();

            try
            {
                DataTable allTimeSlots = this.dataManagement.runCustomerQuery("SELECT * FROM TimeSlot ORDER BY day");
                
                string firstDayString = allTimeSlots.Rows[0]["day"].ToString();
                string lastDayString = allTimeSlots.Rows[allTimeSlots.Rows.Count - 1]["day"].ToString();
                
                DateTime firstDay = DateTime.Parse(firstDayString);
                DateTime lastTime = DateTime.Parse(lastDayString);
                
                dateTimePicker1.MinDate = firstDay;
                dateTimePicker1.MaxDate = lastTime;
            }
            catch (Exception e)
            {
                MessageBox.Show("No time slots found in the database. Please add some time slots first.");
                this.Close();
            }
        }

        private void fillDayTimeSlots()
        {
            string day = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            this.dayTimeSlots = this.dataManagement.runCustomerQuery("SELECT * FROM TimeSlot WHERE day = '" + day + "' ORDER BY startTime");
        }

        private void DayStatistics_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainForm.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            updateFields(date);
        }

        private void updateFields(DateTime date)
        {
            try
            {
                // DataTable timeSlotDate = this.dataManagement.runCustomerQuery("SELECT * FROM TimeSlot WHERE day = '" + date.ToString("d") + "'");
               
                // DateTime startTime = DateTime.Parse(timeSlotDate.Rows[0]["startTime"].ToString());
                // DateTime endTime = DateTime.Parse(timeSlotDate.Rows[0]["endTime"].ToString());
                // int boatNr = int.Parse(timeSlotDate.Rows[0]["boatNr"].ToString());
                // int customerId = int.Parse(timeSlotDate.Rows[0]["customerId"].ToString());
                //
                // TimeSlot timeSlot = new TimeSlot(date, startTime, endTime, boatNr, customerId);
                
                textBox1.Text = this.dataManagement.getTotalTurnover(date.Date).ToString();
                textBox2.Text = this.dataManagement.getTotalRentalTime(date).ToString();
                textBox3.Text = this.dataManagement.getBoatNrHighestFuelConsumption(date)[0].ToString() + ": " + this.dataManagement.getBoatNrHighestFuelConsumption(date)[1].ToString();
                textBox4.Text = this.dataManagement.getBoatDamage(date).ToString();
                textBox5.Text = this.dataManagement.getRentedShortestTimeBoat(date).ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
