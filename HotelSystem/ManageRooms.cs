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

        bool editIsVisible = false;

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
            panel2.Visible = true;
           
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            MessageBox.Show("Data was successfully deleted.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        

        private void ManageRooms_Load_1(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            if (
                String.IsNullOrEmpty(roomType.Text) ||
                String.IsNullOrEmpty(dateIn.Text) ||
                String.IsNullOrEmpty(dateOut.Text)||
                String.IsNullOrEmpty(roomNo2.Text))
            {
                MessageBox.Show("Tam doldurun");
            }
            else
            {
                    if (row != null)
                    {
                        row.Cells[2].Value = roomNo2.Text;
                        row.Cells[3].Value = roomType.Text;
                        row.Cells[4].Value = dateIn.Text;
                        row.Cells[5].Value = dateOut.Text;
                        row.Cells[6].Value = IsFree.Checked? IsFree.Text:isNotFree.Text;

                        MessageBox.Show("Information updated successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    panel2.Visible = false;
                        return;
                    }
                

                MessageBox.Show("This room number was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            //{
            //    string roomNo2 = roomNoTextBox.Text;

              
            //else
            //{
            //    MessageBox.Show("Enter the room number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }

