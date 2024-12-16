namespace HotelSystem
{
    partial class ManageRooms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.freeLabel = new System.Windows.Forms.Label();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.roomNoLabel = new System.Windows.Forms.Label();
            this.roomNoTextBox = new System.Windows.Forms.TextBox();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yesCheckBox = new System.Windows.Forms.CheckBox();
            this.noCheckBox = new System.Windows.Forms.CheckBox();
            this.dateInMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dateInLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateOutMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOut = new System.Windows.Forms.MaskedTextBox();
            this.dateIn = new System.Windows.Forms.MaskedTextBox();
            this.isNotFree = new System.Windows.Forms.CheckBox();
            this.IsFree = new System.Windows.Forms.CheckBox();
            this.roomType = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.roomNo2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 84);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(409, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Rooms";
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clearFieldsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFieldsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFieldsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearFieldsButton.Location = new System.Drawing.Point(21, 451);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(373, 36);
            this.clearFieldsButton.TabIndex = 29;
            this.clearFieldsButton.Text = "Clear Fields";
            this.clearFieldsButton.UseVisualStyleBackColor = false;
            this.clearFieldsButton.Click += new System.EventHandler(this.clearFieldsButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Crimson;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.removeButton.Location = new System.Drawing.Point(305, 397);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(89, 36);
            this.removeButton.TabIndex = 28;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Goldenrod;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editButton.Location = new System.Drawing.Point(208, 397);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(91, 36);
            this.editButton.TabIndex = 27;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(21, 397);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(180, 36);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Make Reservations";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // freeLabel
            // 
            this.freeLabel.AutoSize = true;
            this.freeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeLabel.Location = new System.Drawing.Point(16, 305);
            this.freeLabel.Name = "freeLabel";
            this.freeLabel.Size = new System.Drawing.Size(58, 25);
            this.freeLabel.TabIndex = 25;
            this.freeLabel.Text = "Free:";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeLabel.Location = new System.Drawing.Point(16, 173);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(119, 25);
            this.roomTypeLabel.TabIndex = 19;
            this.roomTypeLabel.Text = "Room Type:";
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNoLabel.Location = new System.Drawing.Point(16, 121);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(99, 25);
            this.roomNoLabel.TabIndex = 17;
            this.roomNoLabel.Text = "Room No:";
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.roomNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomNoTextBox.Location = new System.Drawing.Point(180, 118);
            this.roomNoTextBox.Multiline = true;
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(214, 37);
            this.roomNoTextBox.TabIndex = 16;
            this.roomNoTextBox.TextChanged += new System.EventHandler(this.roomNoTextBox_TextChanged);
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.roomTypeComboBox.DisplayMember = "single";
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.Items.AddRange(new object[] {
            "single",
            "twice"});
            this.roomTypeComboBox.Location = new System.Drawing.Point(182, 174);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(212, 24);
            this.roomTypeComboBox.TabIndex = 30;
            this.roomTypeComboBox.ValueMember = "single";
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(444, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 376);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Client Id";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Reserv Id";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Room No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Room Type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date In";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Out";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Free";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // yesCheckBox
            // 
            this.yesCheckBox.AutoSize = true;
            this.yesCheckBox.Location = new System.Drawing.Point(182, 314);
            this.yesCheckBox.Name = "yesCheckBox";
            this.yesCheckBox.Size = new System.Drawing.Size(53, 20);
            this.yesCheckBox.TabIndex = 32;
            this.yesCheckBox.Text = "Yes";
            this.yesCheckBox.UseVisualStyleBackColor = true;
            this.yesCheckBox.CheckedChanged += new System.EventHandler(this.yesCheckBox_CheckedChanged);
            // 
            // noCheckBox
            // 
            this.noCheckBox.AutoSize = true;
            this.noCheckBox.Location = new System.Drawing.Point(264, 313);
            this.noCheckBox.Name = "noCheckBox";
            this.noCheckBox.Size = new System.Drawing.Size(47, 20);
            this.noCheckBox.TabIndex = 33;
            this.noCheckBox.Text = "No";
            this.noCheckBox.UseVisualStyleBackColor = true;
            this.noCheckBox.CheckedChanged += new System.EventHandler(this.noCheckBox_CheckedChanged);
            // 
            // dateInMaskedTextBox
            // 
            this.dateInMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dateInMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateInMaskedTextBox.Location = new System.Drawing.Point(180, 229);
            this.dateInMaskedTextBox.Mask = "00/00/0000";
            this.dateInMaskedTextBox.Name = "dateInMaskedTextBox";
            this.dateInMaskedTextBox.Size = new System.Drawing.Size(210, 15);
            this.dateInMaskedTextBox.TabIndex = 34;
            this.dateInMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.dateInMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dateInMaskedTextBox_MaskInputRejected);
            // 
            // dateInLabel
            // 
            this.dateInLabel.AutoSize = true;
            this.dateInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInLabel.Location = new System.Drawing.Point(16, 222);
            this.dateInLabel.Name = "dateInLabel";
            this.dateInLabel.Size = new System.Drawing.Size(80, 25);
            this.dateInLabel.TabIndex = 35;
            this.dateInLabel.Text = "Date In:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Date Out:";
            // 
            // dateOutMaskedTextBox
            // 
            this.dateOutMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dateOutMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateOutMaskedTextBox.Location = new System.Drawing.Point(177, 271);
            this.dateOutMaskedTextBox.Mask = "00/00/0000";
            this.dateOutMaskedTextBox.Name = "dateOutMaskedTextBox";
            this.dateOutMaskedTextBox.Size = new System.Drawing.Size(210, 15);
            this.dateOutMaskedTextBox.TabIndex = 36;
            this.dateOutMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.roomNo2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dateOut);
            this.panel2.Controls.Add(this.dateIn);
            this.panel2.Controls.Add(this.isNotFree);
            this.panel2.Controls.Add(this.IsFree);
            this.panel2.Controls.Add(this.roomType);
            this.panel2.Controls.Add(this.submit);
            this.panel2.Location = new System.Drawing.Point(417, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 361);
            this.panel2.TabIndex = 38;
            this.panel2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Date Out:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Date In:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Free:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Room Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Room No:";
            // 
            // dateOut
            // 
            this.dateOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dateOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateOut.Location = new System.Drawing.Point(151, 186);
            this.dateOut.Mask = "00/00/0000";
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(210, 15);
            this.dateOut.TabIndex = 42;
            this.dateOut.ValidatingType = typeof(System.DateTime);
            // 
            // dateIn
            // 
            this.dateIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dateIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateIn.Location = new System.Drawing.Point(151, 149);
            this.dateIn.Mask = "00/00/0000";
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(210, 15);
            this.dateIn.TabIndex = 41;
            this.dateIn.ValidatingType = typeof(System.DateTime);
            // 
            // isNotFree
            // 
            this.isNotFree.AutoSize = true;
            this.isNotFree.Location = new System.Drawing.Point(243, 214);
            this.isNotFree.Name = "isNotFree";
            this.isNotFree.Size = new System.Drawing.Size(47, 20);
            this.isNotFree.TabIndex = 40;
            this.isNotFree.Text = "No";
            this.isNotFree.UseVisualStyleBackColor = true;
            // 
            // IsFree
            // 
            this.IsFree.AutoSize = true;
            this.IsFree.Location = new System.Drawing.Point(161, 215);
            this.IsFree.Name = "IsFree";
            this.IsFree.Size = new System.Drawing.Size(53, 20);
            this.IsFree.TabIndex = 39;
            this.IsFree.Text = "Yes";
            this.IsFree.UseVisualStyleBackColor = true;
            // 
            // roomType
            // 
            this.roomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.roomType.DisplayMember = "single";
            this.roomType.FormattingEnabled = true;
            this.roomType.Items.AddRange(new object[] {
            "single",
            "twice"});
            this.roomType.Location = new System.Drawing.Point(147, 107);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(212, 24);
            this.roomType.TabIndex = 38;
            this.roomType.ValueMember = "single";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submit.Location = new System.Drawing.Point(92, 310);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(256, 36);
            this.submit.TabIndex = 30;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // roomNo2
            // 
            this.roomNo2.Location = new System.Drawing.Point(161, 53);
            this.roomNo2.Name = "roomNo2";
            this.roomNo2.Size = new System.Drawing.Size(100, 22);
            this.roomNo2.TabIndex = 50;
            // 
            // ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1137, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateOutMaskedTextBox);
            this.Controls.Add(this.dateInLabel);
            this.Controls.Add(this.dateInMaskedTextBox);
            this.Controls.Add(this.noCheckBox);
            this.Controls.Add(this.yesCheckBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.roomTypeComboBox);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.freeLabel);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.roomNoLabel);
            this.Controls.Add(this.roomNoTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRooms";
            this.Text = "ManageRooms";
            this.Load += new System.EventHandler(this.ManageRooms_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearFieldsButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label freeLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Label roomNoLabel;
        private System.Windows.Forms.TextBox roomNoTextBox;
        private System.Windows.Forms.ComboBox roomTypeComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox yesCheckBox;
        private System.Windows.Forms.CheckBox noCheckBox;
        private System.Windows.Forms.MaskedTextBox dateInMaskedTextBox;
        private System.Windows.Forms.Label dateInLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox dateOutMaskedTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox dateOut;
        private System.Windows.Forms.MaskedTextBox dateIn;
        private System.Windows.Forms.CheckBox isNotFree;
        private System.Windows.Forms.CheckBox IsFree;
        private System.Windows.Forms.ComboBox roomType;
        private System.Windows.Forms.TextBox roomNo;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox roomNo2;
    }
}