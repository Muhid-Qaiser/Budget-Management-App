using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Expense_Tracker
{
    internal class CategoryData
    // class CategoryData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; } // index 0
        public string Category {  set; get; } // index 1
        public string Type { set; get; } // index 2
        public string Status { set; get; } // index 3
        public string Date { set; get; } // index 4

        public List<CategoryData> categoryListData()
        {
            List<CategoryData> listData = new List<CategoryData>();

            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoryData cData = new CategoryData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Type = reader["type"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");
                        //cData.Date = ((DateTime)reader["date_insert"]).ToString("dd-MM-yyyy");

                        listData.Add(cData);
                    }
                }
            }
            return listData;
        }

    }
}
