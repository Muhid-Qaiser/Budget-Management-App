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
using System.Drawing.Text;
using System.Xml.Linq;

namespace Expense_Tracker
{
    public partial class IncomeForm : UserControl   // The Design is stored in IncomeForm.design. There it first initializes the components and sets their position. Then it sets every components properties along with EventHandler work
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public IncomeForm()
        {
            InitializeComponent();  // Initializes the pages componenets and GUI

            displayCategyList();    // Display Active Categories for Income
            displayIncomeData();    // Display Income Catalogue
        }


        public void refreshData()   // Each time the page is opened, It's data is refreshed
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategyList();
            displayIncomeData();
        }


        public void displayIncomeData() 
        {
            IncomeData iData = new IncomeData();    // Create IncomeData object.
            List<IncomeData> listData = iData.incomeListData();     // Get a List of IncomeData objects as records for a table

            dataGridView1.DataSource = listData;
        }

        private void Income_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void displayCategyList()
        {
            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status";      // Only get Category column from categories table

                using(SqlCommand cmd = new SqlCommand(selectData, connect)) 
                {
                    // Build Query
                    cmd.Parameters.AddWithValue("@type", "Income");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    // clear any record already present in the income_category. It is created by the drag-and-drop list box in the Design automatically
                    income_category.Items.Clear();  // Clear it's items to avoid duplication 

                    SqlDataReader reader = cmd.ExecuteReader();     // execute query and store all records in reader

                    while (reader.Read())   // read one row at a time from the records in reader
                    {
                        income_category.Items.Add(reader["category"].ToString());   // add name of each category in the rows into the listbox item's list
                    }
                }
                connect.Close();
            }
        }

        private void income_addBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" || income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO income (category, item, income, description, date_income, date_insert)" +
                        "VALUES (@cat, @item, @income, @desc, @date_in, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", income_item.Text);
                        cmd.Parameters.AddWithValue("@income", income_income.Text);
                        cmd.Parameters.AddWithValue("@desc", income_description.Text);
                        cmd.Parameters.AddWithValue("@date_in", income_date.Value);

                        /*
                        if (income_date.Value <= DateTime.Today)
                        { 
                            cmd.Parameters.AddWithValue("@date_in", income_date.Value);
                        }
                        else
                        {
                            MessageBox.Show("You have Entered a Date of the Future. Replacing it with Current Data", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmd.Parameters.AddWithValue("@date_in", DateTime.Today);
                        }
                        */

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Record Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    connect.Close();
                }
            }
            displayIncomeData();
        }

        public void clearFields()
        {
            income_item.Text = "";
            income_category.SelectedIndex = -1;
            income_income.Text = "";
            income_description.Text = "";
        }

        private void income_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void income_updateBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" || income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please select an item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ( MessageBox.Show("Are you sure you want to Update ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ) 
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE income SET category = @cat, item = @item, income = @income, description = @desc, date_income = @date_in WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", income_item.Text);
                            cmd.Parameters.AddWithValue("@income", income_income.Text);
                            cmd.Parameters.AddWithValue("@desc", income_description.Text);
                            cmd.Parameters.AddWithValue("@date_in", income_date.Value);

                            /*
                            if (income_date.Value <= DateTime.Today)
                            {
                                cmd.Parameters.AddWithValue("@date_in", income_date.Value);
                            }
                            else
                            {
                                MessageBox.Show("You have Entered a Date of the Future. Replacing it with Current Data", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cmd.Parameters.AddWithValue("@date_in", DateTime.Today);
                            }
                            */


                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Record Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }
                }

               
            }
            displayIncomeData();
        }

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)    // Used to display data of the clicked record in the input boxes in the design
        {
            if (e.RowIndex != -1)   // e.RowIndex is the Index of the Row selected by the user. RowIndex gets it's value automatically
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];   // get record of the selected row

                getID = (int)row.Cells[0].Value;    // store ID in global var
                income_category.SelectedItem = row.Cells[1].Value.ToString();   // SelectedItems as it contains a list
                income_item.Text = row.Cells[2].Value.ToString();   // Text as it is only a single valueable string
                income_income.Text = row.Cells[3].Value.ToString();
                income_description.Text = row.Cells[4].Value.ToString();
                // income_date.Value = Convert.ToDateTime(row.Cells[5].Value.ToString()); // error with formating dates

                income_date.Value = DateTime.ParseExact(row.Cells[5].Value.ToString(), "MM-dd-yyyy", null);

                /*
                try
                {
                    income_date.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("You have Entered a Date of the Future. Replacing it with Current Data", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */

            }
        }

        private void income_deleteBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" || income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string insertData = "DELETE FROM income WHERE id = @id"; // Change insertData to DeleteDate

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Record Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }
                }
            }
            displayIncomeData();
        }
    }
}
