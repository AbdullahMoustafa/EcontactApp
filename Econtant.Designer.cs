namespace Econtact
{
    partial class Econtant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtant));
            this.pictureBoxlogo = new System.Windows.Forms.PictureBox();
            this.txtboxContactID = new System.Windows.Forms.TextBox();
            this.label1contactID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtboxContactNo = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.LOGOName = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btmUpdate = new System.Windows.Forms.Button();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmClear = new System.Windows.Forms.Button();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxlogo
            // 
            this.pictureBoxlogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxlogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxlogo.Image")));
            this.pictureBoxlogo.Location = new System.Drawing.Point(444, 12);
            this.pictureBoxlogo.Name = "pictureBoxlogo";
            this.pictureBoxlogo.Size = new System.Drawing.Size(224, 73);
            this.pictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxlogo.TabIndex = 1;
            this.pictureBoxlogo.TabStop = false;
            // 
            // txtboxContactID
            // 
            this.txtboxContactID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxContactID.Location = new System.Drawing.Point(186, 117);
            this.txtboxContactID.Name = "txtboxContactID";
            this.txtboxContactID.ReadOnly = true;
            this.txtboxContactID.Size = new System.Drawing.Size(204, 25);
            this.txtboxContactID.TabIndex = 2;
            // 
            // label1contactID
            // 
            this.label1contactID.AutoSize = true;
            this.label1contactID.BackColor = System.Drawing.Color.Transparent;
            this.label1contactID.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1contactID.Location = new System.Drawing.Point(80, 121);
            this.label1contactID.Name = "label1contactID";
            this.label1contactID.Size = new System.Drawing.Size(87, 13);
            this.label1contactID.TabIndex = 3;
            this.label1contactID.Text = "Contact ID";
            this.label1contactID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(80, 175);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(87, 13);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFirstName.Location = new System.Drawing.Point(186, 171);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(204, 25);
            this.txtboxFirstName.TabIndex = 4;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNo.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(80, 280);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(95, 13);
            this.lblContactNo.TabIndex = 7;
            this.lblContactNo.Text = "Contact No.";
            this.lblContactNo.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtboxContactNo
            // 
            this.txtboxContactNo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxContactNo.Location = new System.Drawing.Point(186, 276);
            this.txtboxContactNo.Name = "txtboxContactNo";
            this.txtboxContactNo.Size = new System.Drawing.Size(204, 25);
            this.txtboxContactNo.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(80, 229);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 13);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLastName.Location = new System.Drawing.Point(186, 225);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(204, 25);
            this.txtboxLastName.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(80, 327);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAddress.Location = new System.Drawing.Point(186, 323);
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(204, 66);
            this.txtboxAddress.TabIndex = 12;
            this.txtboxAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LOGOName
            // 
            this.LOGOName.AutoSize = true;
            this.LOGOName.BackColor = System.Drawing.Color.Transparent;
            this.LOGOName.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGOName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LOGOName.Location = new System.Drawing.Point(495, 88);
            this.LOGOName.Name = "LOGOName";
            this.LOGOName.Size = new System.Drawing.Size(112, 25);
            this.LOGOName.TabIndex = 14;
            this.LOGOName.Text = "E-Contact";
            this.LOGOName.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(186, 418);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(204, 26);
            this.cmbGender.TabIndex = 15;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(80, 422);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(55, 13);
            this.lblGender.TabIndex = 16;
            this.lblGender.Text = "Gender";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(187, 486);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 42);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btmAdd_Click);
            // 
            // btmUpdate
            // 
            this.btmUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btmUpdate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmUpdate.ForeColor = System.Drawing.SystemColors.Info;
            this.btmUpdate.Location = new System.Drawing.Point(364, 486);
            this.btmUpdate.Name = "btmUpdate";
            this.btmUpdate.Size = new System.Drawing.Size(151, 42);
            this.btmUpdate.TabIndex = 19;
            this.btmUpdate.Text = "Update";
            this.btmUpdate.UseVisualStyleBackColor = false;
            this.btmUpdate.Click += new System.EventHandler(this.btmUpdate_Click);
            // 
            // btmDelete
            // 
            this.btmDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btmDelete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btmDelete.Location = new System.Drawing.Point(543, 486);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(151, 42);
            this.btmDelete.TabIndex = 20;
            this.btmDelete.Text = "Delete";
            this.btmDelete.UseVisualStyleBackColor = false;
            this.btmDelete.Click += new System.EventHandler(this.btmDelete_Click);
            // 
            // btmClear
            // 
            this.btmClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btmClear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btmClear.Location = new System.Drawing.Point(721, 486);
            this.btmClear.Name = "btmClear";
            this.btmClear.Size = new System.Drawing.Size(151, 42);
            this.btmClear.TabIndex = 21;
            this.btmClear.Text = "Clear";
            this.btmClear.UseVisualStyleBackColor = false;
            this.btmClear.Click += new System.EventHandler(this.btmClear_Click);
            // 
            // dgvContactList
            // 
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(411, 171);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.Size = new System.Drawing.Size(638, 287);
            this.dgvContactList.TabIndex = 22;
            this.dgvContactList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContactList_RowHeaderMouseClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(416, 136);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 22);
            this.lblSearch.TabIndex = 23;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearch.Location = new System.Drawing.Point(489, 136);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(560, 25);
            this.txtboxSearch.TabIndex = 24;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1071, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Econtant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1105, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvContactList);
            this.Controls.Add(this.btmClear);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.btmUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.LOGOName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.txtboxContactNo);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.label1contactID);
            this.Controls.Add(this.txtboxContactID);
            this.Controls.Add(this.pictureBoxlogo);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Econtant";
            this.Text = "EContant";
            this.Load += new System.EventHandler(this.Econtant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxlogo;
        private System.Windows.Forms.TextBox txtboxContactID;
        private System.Windows.Forms.Label label1contactID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtboxContactNo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Label LOGOName;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btmUpdate;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmClear;
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

