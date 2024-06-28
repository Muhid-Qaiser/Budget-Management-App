using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Expense_Tracker
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if(register_username.Text == ""  || register_password.Text == "" || register_cPassword.Text == "" )
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(checkConnection())
                {
                    try
                    {
                        connect.Open();

                        // CHECK IF USERNAME TO REGISTER ALREADY EXISTS
                        string selectUsername = "SELECT * FROM users WHERE username = @usern";
                        using(SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", register_username.Text.Trim()); // put the value in @usern of Query

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);    // run dataadapter on the above query and store records in Table

                            if(table.Rows.Count != 0)   // If number of records are more than 0, it means a record of the same username already exists
                            {
                                // Convert First Letter to Capital
                                string tempUsern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                                MessageBox.Show(tempUsern + " is already existing", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password, must be atleast 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length > 20)
                            {
                                MessageBox.Show("Invalid password, must be less than 20 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else if (!Regex.IsMatch(register_password.Text, "[A-Z]"))
                            {
                                MessageBox.Show("Invalid password, must contain at least one uppercase letter", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (!Regex.IsMatch(register_password.Text, "[a-z]"))
                            {
                                MessageBox.Show("Invalid password, must contain at least one lowercase letter", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (!Regex.IsMatch(register_password.Text, @"\d"))
                            {
                                MessageBox.Show("Invalid password, must contain at least one digit", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (!Regex.IsMatch(register_password.Text, @"[^\da-zA-Z]"))
                            {
                                MessageBox.Show("Invalid password, must contain at least one special character", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else if (register_password.Text != register_cPassword.Text)
                            {
                                MessageBox.Show("Password doesn't Match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }    
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, date_create) VALUES(@usern, @pass, @date)";

                                using(SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", register_password.Text.Trim());

                                    DateTime today = DateTime.Today; // Current Date
                                    insertUser.Parameters.AddWithValue("@date", today);     // This line and the lines above load up the query 

                                    insertUser.ExecuteNonQuery();   // Runs the query

                                    MessageBox.Show("Registration Successfull!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                    Form1 loginForm = new Form1();
                                    loginForm.Show();

                                    this.Hide();
                                }
                            }
                        }

                    }catch(Exception ex)
                    {
                        MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally 
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }
    }
}
