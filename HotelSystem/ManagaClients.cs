using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class ManagaClients : Form
    {
        public ManagaClients()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ManagaClients_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "First Name";
            dataGridView1.Columns[2].Name = "Last Name";
            dataGridView1.Columns[3].Name = "Phone No";
            dataGridView1.Columns[4].Name = "Country";
        }


        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox.Text) ||
                string.IsNullOrWhiteSpace(firstnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Add(
                idTextBox.Text,
                firstnameTextBox.Text,
                lastnameTextBox.Text,
                phoneTextBox.Text,
                countryTextBox.Text
            );

            idTextBox.Clear();
            firstnameTextBox.Clear();
            lastnameTextBox.Clear();
            phoneTextBox.Clear();
            countryTextBox.Clear();

            MessageBox.Show("Information added successfully!", "Successful operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ManageRooms manageRooms = new ManageRooms();
            manageRooms.Show();
            this.Hide();
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox.Text))
            {
                MessageBox.Show("Please enter the ID of the customer you want to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idTextBox.Text, out int idToEdit))
            {
                MessageBox.Show("The ID must consist of numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == idToEdit.ToString())
                {
                    row.Cells[1].Value = firstnameTextBox.Text; 
                    row.Cells[2].Value = lastnameTextBox.Text;  
                    row.Cells[3].Value = phoneTextBox.Text;     
                    row.Cells[4].Value = countryTextBox.Text;   

                    found = true;
                    break;
                }
            }

            if (found)
            {
                MessageBox.Show($"Customer information with ID: {idToEdit} has been edited.", "Successful operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show($"Customer with ID: {idToEdit} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFields()
        {
            idTextBox.Clear();
            firstnameTextBox.Clear();
            lastnameTextBox.Clear();
            phoneTextBox.Clear();
            countryTextBox.Clear();
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox.Text))
            {
                MessageBox.Show("Please enter the ID of the customer you want to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idTextBox.Text, out int idToRemove))
            {
                MessageBox.Show("The ID must consist of numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == idToRemove.ToString())
                {
                    dataGridView1.Rows.Remove(row);
                    found = true;
                    break;
                }
            }
            
            if (found)
            {
                MessageBox.Show($"Customer with ID: {idToRemove} has been removed.", "Successful operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idTextBox.Clear(); 
            }
            else
            {
                MessageBox.Show($"Customer with ID: {idToRemove} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            firstnameTextBox.Clear();
            lastnameTextBox.Clear();
            phoneTextBox.Clear();
            countryTextBox.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
