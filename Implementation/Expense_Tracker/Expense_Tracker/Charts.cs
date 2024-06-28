using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Expense_Tracker
{
    public partial class Charts : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public Charts()
        {
            InitializeComponent();
            incomeChart();
            expensesChart();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            incomeChart();
            expensesChart();
        }

        public void incomeChart()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                DataTable dt = new DataTable();

                string selectData = "SELECT category, SUM(income) as income FROM income group by category;";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                connect.Close();


                string[] x = new string[dt.Rows.Count];
                decimal[] y = new decimal[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    x[i] = dt.Rows[i][0].ToString();
                    y[i] = Convert.ToDecimal(dt.Rows[i][1]);
                }

                
                income_chart.Series[0].Points.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    income_chart.Series[0].Points.AddXY(x[i], y[i]);
                }


            }
        }


        public void expensesChart()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                DataTable dt = new DataTable();

                string selectData = "SELECT category, SUM(cost) as cost FROM expenses group by category;";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                connect.Close();


                string[] x = new string[dt.Rows.Count];
                decimal[] y = new decimal[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    x[i] = dt.Rows[i][0].ToString();
                    y[i] = Convert.ToDecimal(dt.Rows[i][1]);
                }

                expenses_chart.Series[0].Points.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    expenses_chart.Series[0].Points.AddXY(x[i], y[i]);
                }


            }
        }


        private void income_chart_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
