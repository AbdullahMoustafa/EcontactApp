﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.EcontactClasses
{
    class ContactClass
    {
        //Getter Setter Properties 
        //Acts as Data Carrier in Our Application
        public int ContactID { get; set;  }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }


        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting data from database
        public DataTable Select()
        {
            //Step1: Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                //Step2: Writing SQL Query
                string sql = "SELECT * from tbl_contact";
                //Creating and using sql and conn 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt; 
        }
        //Inserting data into Database
        public bool Insert (ContactClass c)
        {
            //Creating a defult return type and setting its value to false 
            bool isSuccess = false;

            //Step1: Connect database 
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2: Create a SQL Query to Insert Data 
                string sql = "INSERT INTO tbl_contact(FirstName, LastName, ContactNo, Address, Gender)VALUES(@FirstName, @LastName, @ContactNo, @Address, @Gender)";
                //Creating SQL command using SQL and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                //Connection open here 
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the quary runs successfully then the value of the rows will be greater than zero else the value will be 0

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //Method to update database from our application 
        public bool Update(ContactClass c)
        {
            //Create a defualt return type and sets its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL  to update data into database
                string sql = "UPDATE tbl_contact SET FirstName= @FirstName , LastName=@LastName , ContactNo=@ContactNo , Address=@Address, Gender=@Gender WHERE ContactID=@ContactID";

                //Creating SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating Parameters to add value 
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of the rows will be greater than zero else its value will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        // Method to delete data from database
        public bool Delete(ContactClass c)
        {
            //Create a defulat return value and set to false 
            bool isSuccess = false;
            //Create SQL connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {   //SQL to delete data 
                string sql = "DELETE FROM tbl_contact WHERE ContactID=@ContactID";

                //Creating SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
            }
            finally
            {
                //Close connection
                conn.Close();
            }
            
            return isSuccess;
        }
    }

}
