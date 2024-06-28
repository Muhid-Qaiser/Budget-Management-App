using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Expense_Tracker
{
    internal class IncomeData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        // Create variables to store data in of each record and easily access them later for manipulation
        public int ID { set; get; }
        public string Category { set; get; }
        public string Item { set; get; }
        public string Cost { set; get; }
        public string Description { set; get; }
        public string DateIncome { set; get; }

        public List<IncomeData> incomeListData()
        {
            List<IncomeData> listData = new List<IncomeData>();     // create a list of incomeData objects to store as records for a table

            using (SqlConnection connect = new SqlConnection(stringConnection))     // Create connection object
            {
                connect.Open(); // Connect with database

                string selectData = "SELECT * FROM income";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))    // make connection object
                { 
                    SqlDataReader reader = cmd.ExecuteReader();     // create reader object. It contains records of data in table form

                    while (reader.Read())   // read 1 row of the table, if next row exists, then read next and so on. It can only read 1 row at a time
                    {
                        IncomeData iData = new IncomeData();

                        iData.ID = (int)reader["id"];   //      Store ID value of current row as an INT in iData.ID object
                        iData.Category = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Cost = reader["income"].ToString();
                        iData.Description = reader["description"].ToString();
                        iData.DateIncome = ((DateTime)reader["date_income"]).ToString("MM-dd-yyyy");

                        listData.Add(iData);    // Store the iData.ID object in a list
                    }
                }
            }
            return listData;    // Return List. Benefit of storing records of table like this is it allows users to access each col of a record simply by doing row.ID, to get ID of that row. This allows for data updation and manipulation
        }



    }
}
