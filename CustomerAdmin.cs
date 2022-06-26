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
    public partial class CustomerAdmin : Form
    {
        private MainForm mainForm;
        private DataManagement dataManagement;
        
        public CustomerAdmin(MainForm mainForm)
        {
            InitializeComponent();
            
            this.dataManagement = new DataManagement();
            this.mainForm = mainForm;
            mainForm.Hide();

            updateDropdown();
        }

        // ??? Can i make this protected and use in the MainForm class ???
        private DataTable getCustomerTable()
        {
            try
            {
                DataTable customerTable = new DataManagement().getDatabaseObjects("customer");
                return customerTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return null;
        }

        private void updateDropdown()
        {
            DataTable customerTable = getCustomerTable();
            if (customerTable != null)
            {
                // Clearing the box in case it is being updated after a new boat was added
                // If the box IS NOT cleared, there will be duplicate boat numbers
                comboBox1.Items.Clear();
                foreach (DataRow dataRow in customerTable.Rows)
                {
                    comboBox1.Items.Add(dataRow["Id"]);
                }
            }
            else
            {
                MessageBox.Show("Try to restart the application.");
            }
        }

        private DataRow getCustomerNrDetails(int customerId)
        {
            DataTable customerTable = getCustomerTable();
            if (customerTable != null)
            {
                foreach (DataRow dataRow in customerTable.Rows)
                {
                    if (dataRow["Id"].Equals(customerId))
                    {
                        return dataRow;
                    }
                }
            }

            return null;
        }

        private void updateTextBoxFields(bool delete)
        {
            if (!delete)
            {
                int cusomterId = (int)comboBox1.SelectedItem;
                DataRow customerDetails = getCustomerNrDetails(cusomterId);
                if (customerDetails != null)
                {
                    textBox_firstName.Text = customerDetails["firstName"].ToString();
                    textBox_lastName.Text = customerDetails["lastName"].ToString();
                    textBox_birthDate.Text = customerDetails["birthDate"].ToString();

                    textBox_firstName.Enabled = true;
                    textBox_lastName.Enabled = true;
                    textBox_birthDate.Enabled = true;

                    update_button.Enabled = true;
                    delete_button.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No customer with id " + cusomterId + " found.");
                }
            }
            else
            {
                textBox_firstName.Text = "";
                textBox_lastName.Text = "";
                textBox_birthDate.Text = "";

                textBox_firstName.Enabled = false;
                textBox_lastName.Enabled = false;
                textBox_birthDate.Enabled = false;

                update_button.Enabled = false;
                delete_button.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTextBoxFields(false);
        }

        private void CustomerAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainForm.Show();
        }

        private void add_new_button_Click(object sender, EventArgs ev)
        {
            try
            {
                string firstName = textBox_create_firstName.Text;
                string lastName = textBox_create_lastName.Text;
                //DateTime birthDate = DateTime.ParseExact(textBox_create_birthDate.Text, "dd.mm.yyyy", null);
                DateTime birthDate = DateTime.ParseExact(textBox_create_birthDate.Text, "dd.MM.yyyy", null).Date;

                Customer customer = new Customer(firstName, lastName, birthDate);

                this.dataManagement.insertObjectDatabase(customer);

                // Updating the dropdown menu with the new boat
                updateDropdown();

                MessageBox.Show("Customer added successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void update_button_Click(object sender, EventArgs ev)
        {
            try
            {
                Customer customer = new Customer(
                    textBox_firstName.Text, 
                    textBox_lastName.Text,
                    DateTime.ParseExact(textBox_birthDate.Text, "dd.MM.yyyy", null).Date
                    );
                
                customer.Id = (int)comboBox1.SelectedItem;
                

                this.dataManagement.updateObjectDatabase(customer);
                updateTextBoxFields(false);
                MessageBox.Show("Customer updated successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int id = (int)comboBox1.SelectedItem;
            this.dataManagement.deleteObjectDatabase("customer", id);
            updateDropdown();
            updateTextBoxFields(true);
        }
    }
}
