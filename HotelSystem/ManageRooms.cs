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
    public partial class ManageRooms : Form
    {
        public ManageRooms()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yesCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void noCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(roomNoTextBox.Text) &&
                roomTypeComboBox.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(dateInMaskedTextBox.Text) &&
                !string.IsNullOrWhiteSpace(dateOutMaskedTextBox.Text))
            {
                string roomNo = roomNoTextBox.Text;
                string roomType = roomTypeComboBox.SelectedItem.ToString();
                string freeStatus = yesCheckBox.Checked ? "Yes" : "No";
                string dateIn = dateInMaskedTextBox.Text;
                string dateOut = dateOutMaskedTextBox.Text;

                string reserveId = Guid.NewGuid().ToString(); 
                string clientId = Guid.NewGuid().ToString(); 

                
                dataGridView1.Rows.Add(clientId, reserveId, roomNo, roomType, dateIn, dateOut, freeStatus);

                
                ClearFields();
            }
            else
            {
                MessageBox.Show("Bütün məlumatları doldurun.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(roomNoTextBox.Text))
            {
                string roomNo = roomNoTextBox.Text;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[2].Value?.ToString() == roomNo) 
                    {
                        row.Cells[3].Value = yesCheckBox.Checked ? "Yes" : "No"; 
                        row.Cells[4].Value = roomTypeComboBox.SelectedItem?.ToString(); 
                        row.Cells[5].Value = dateInMaskedTextBox.Text; 
                        row.Cells[6].Value = dateOutMaskedTextBox.Text;

                        MessageBox.Show("Information updated successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        return;
                    }
                }

                MessageBox.Show("This room number was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Enter the room number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Paneli açırıq
            panel2.Visible = true;
        }


        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageRooms_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            roomTypeComboBox.Items.Add("Single");
            roomTypeComboBox.Items.Add("Double");

            dateInMaskedTextBox.Mask = "00/00/0000";
            dateOutMaskedTextBox.Mask = "00/00/0000";
        }



        private void ClearFields()
        {
            roomNoTextBox.Clear();
            roomTypeComboBox.SelectedIndex = -1;
            yesCheckBox.Checked = false;
            noCheckBox.Checked = false;
            dateInMaskedTextBox.Clear();
            dateOutMaskedTextBox.Clear();
        }


        private void dateInMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateOutMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reservIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Burada "submit" düyməsinə basıldıqda rezerv ID ilə silmə əməliyyatı baş verir
            string reserveIdToDelete = reservIdTextBox.Text;

            if (!string.IsNullOrWhiteSpace(reserveIdToDelete))
            {
                bool found = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value?.ToString() == reserveIdToDelete)  // reserveId yoxlayırıq
                    {
                        dataGridView1.Rows.Remove(row);
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    MessageBox.Show("Data was successfully deleted.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel2.Visible = false;  // Paneli bağlayırıq
                    ClearFields();  // TextBox-ları təmizləyirik
                }
                else
                {
                    MessageBox.Show("This reserve ID was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter the reserve ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
