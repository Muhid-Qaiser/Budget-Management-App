using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Expense_Tracker
{
    public partial class Form1 : Form
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";


        public Form1()
        {
            InitializeComponent();
        }


        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();

            this.Hide();
        }


        public static string username;


        private void login_btn_Click(object sender, EventArgs e)
        {
            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectDate = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using(SqlCommand cmd = new SqlCommand(selectDate, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Acts as a connection between SQL database and Code. 
                    DataTable table = new DataTable();  // Create table to store records in 

                    adapter.Fill(table); // Runs the above query and retreives records from the database. Then fills them in table

                    if (table.Rows.Count > 0)   // If table has more than 0 records, means it has found a record with the given username and password
                    {
                        username = login_username.Text;

                        MessageBox.Show("Login Succesfull!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // MainForm mForm = new MainForm();
                        // mForm.Show();
                        MainForm2 mForm = new MainForm2();  // Go to mainForm
                        mForm.Show();

                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username/Password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = (login_showPass.Checked) ? '\0' : '*';
        }
    }
}
