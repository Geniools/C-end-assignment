using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boat_rental
{
    public partial class BoatAdmin : Form
    {
        private MainForm mainForm;
        private DataManagement dataManagement;
        
        public BoatAdmin(MainForm mainForm)
        {
            InitializeComponent();
            this.dataManagement = new DataManagement();
            this.mainForm = mainForm;

            updateDropdown();
        }

        // ??? Can i make this protected and use in the MainForm class ???
        private DataTable getBoatTable()
        {
            try
            {
                DataTable boatTable = new DataManagement().getDatabaseObjects("boat");
                return boatTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return null;
        }
        
        private void updateDropdown()
        {
            DataTable boatTable = getBoatTable();
            if (boatTable != null)
            {
                // Clearing the box in case it is being updated after a new boat was added
                // If the box IS NOT cleared, there will be duplicate boat numbers
                comboBox1.Items.Clear();
                foreach (DataRow dataRow in boatTable.Rows)
                {
                    comboBox1.Items.Add(dataRow["boatNr"]);
                }
            }
            else
            {
                MessageBox.Show("Try to restart the application.");
            }
        }

        private DataRow getBoatNrDetails(int boatNr)
        {
            DataTable boatTable = getBoatTable();
            if (boatTable != null)
            {
                foreach (DataRow dataRow in boatTable.Rows)
                {
                    if (dataRow["boatNr"].Equals(boatNr))
                    {
                        return dataRow;
                    }
                }
            }

            return null;
        }

        private void updateTextBoxFields(bool delete)
        {
            if(!delete)
            {
                int boatNr = (int)comboBox1.SelectedItem;
                DataRow boatDetails = getBoatNrDetails(boatNr);
                if (boatDetails != null)
                {
                    // Updating the fields with the specific characteristics for the specific boat
                    weight_input_textbox.Text = boatDetails["weight"].ToString();
                    boat_lenght.Text = boatDetails["lenght"].ToString();
                    boat_engine_power.Text = boatDetails["enginePower"].ToString();
                    boat_rental_price.Text = boatDetails["hourlyRentalPrice"].ToString();
                    boat_damage.Text = boatDetails["damage"].ToString();
                    // By default "masked boxes" are disabled
                    weight_input_textbox.Enabled = true;
                    boat_lenght.Enabled = true;
                    boat_engine_power.Enabled = true;
                    boat_rental_price.Enabled = true;
                    boat_damage.Enabled = true;

                    delete_boat_button.Enabled = true;
                    update_boat_button.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No boat with boatNr " + boatNr + " found.");
                }
            }
            else
            {
                weight_input_textbox.Text = "";
                boat_lenght.Text = "";
                boat_engine_power.Text = "";
                boat_rental_price.Text = "";
                boat_damage.Text = "";
                
                weight_input_textbox.Enabled = false;
                boat_lenght.Enabled = false;
                boat_engine_power.Enabled = false;
                boat_rental_price.Enabled = false;
                boat_damage.Enabled = false;
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTextBoxFields(false);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Invalid input.");
        }

        private void BoatAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Updating the main form dropdown with "new boats"
            this.mainForm.updateDropdown();
            this.mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs ev)
        {
            try
            {
                float weight = float.Parse(weight_masked_box.Text);
                float lenght = float.Parse(lenght_masked_box.Text);
                int enginePower = int.Parse(engine_power_masked_box.Text);
                float hourlyRentalPrice = float.Parse(rental_price_masked_box.Text);
                float damage = float.Parse(damage_masked_box.Text);

                Boat boat = new Boat(weight, lenght, enginePower, hourlyRentalPrice);

                if (damage > 0)
                {
                    boat.Damage = damage;
                }
                
                this.dataManagement.insertObjectDatabase(boat);
                
                // Updating the dropdown menu with the new boat
                updateDropdown();

                // Clearing the textboxes for a new boat to be added
                // weight_masked_box.Text = "";
                // lenght_masked_box.Text = "";
                // engine_power_masked_box.Text = "";
                // rental_price_masked_box.Text = "";
                // damage_masked_box.Text = "";

                MessageBox.Show("Boat added successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void update_boat_button_Click(object sender, EventArgs ev)
        {
            try
            {
                Boat boat = new Boat(float.Parse(weight_input_textbox.Text),
                    float.Parse(boat_lenght.Text),
                    int.Parse(boat_engine_power.Text),
                    float.Parse(boat_rental_price.Text)
                );
                boat.BoatNr = (int)comboBox1.SelectedItem;

                if (boat.Damage > 0)
                {
                    boat.Damage = float.Parse(boat_damage.Text);
                }

                this.dataManagement.updateObjectDatabase(boat);
                updateTextBoxFields(false);
                MessageBox.Show("Boat updated successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void delete_boat_button_Click(object sender, EventArgs e)
        {
            int id = (int)comboBox1.SelectedItem;
            this.dataManagement.deleteObjectDatabase("boat", id);
            updateDropdown();
            updateTextBoxFields(true);
        }
    }
}
