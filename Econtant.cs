using Econtact.EcontactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econtact
{
    public partial class Econtant : Form
    {
        public Econtant()
        {
            InitializeComponent();
        }
        ContactClass c = new ContactClass();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void btmAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields 
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtboxContactNo.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbGender.Text;

            //Inserting data into database using the method created 
            bool success = c.Insert(c);
            if (success == true)
            {
                //succussfully inserted
                MessageBox.Show("New Contact Successfully Inserted");
                //Call the Clear Method here
                Clear();
            }
            else
            {
                //Failed to add contact
                MessageBox.Show("Failed to add New Contact. Try Again");

            }
            //Load data in the grid view 
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

        }

        private void Econtant_Load(object sender, EventArgs e)
        {
            //Load data in the grid view 
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Method to clear all the field 
        public void Clear()
        {
            txtboxFirstName.Text = "";
            txtboxLastName.Text = "";
            txtboxContactNo.Text = "";
            txtboxAddress.Text = "";
            cmbGender.Text = "";

        }

        private void btmUpdate_Click(object sender, EventArgs e)
        {
            //get the data from the text box and update it in the field
            c.ContactID = int.Parse(txtboxContactID.Text);
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtboxContactNo.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbGender.Text;
            //update data in the database

            bool success = c.Update(c);
            if(success==true)
            {
                //succussfully updated
                MessageBox.Show("Contact Successfully Updated");                
            }
            else
            {
                //Failed to update contact
                MessageBox.Show("Failed to update the Contact. Try Again");
            }

            //Load data in the grid view 
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

            //Call the clear method
            Clear();

        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from the data grid to the boxes to upgrade
            int rowIndex = e.RowIndex;
            txtboxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxContactNo.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();


        }

        private void btmClear_Click(object sender, EventArgs e)
        {
            //Call Clear method here
            Clear();

        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            //Get data from text boxes
            c.ContactID = Convert.ToInt32(txtboxContactID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                //Succussfully deleted
                MessageBox.Show("Succussfully Deleted");

                //Load data in the grid view 
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete it, Try Again");
            }
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from the text box
            string keyword = txtboxSearch.Text;
            
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;


        }
    }
}
