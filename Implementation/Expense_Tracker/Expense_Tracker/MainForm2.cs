using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Expense_Tracker
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
            displayUsername();
        }

        public void displayUsername()
        {
            string getUsername = Form1.username;

            greetUser.Text = "Welcome, " + getUsername.Substring(0, 1).ToUpper() + getUsername.Substring(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;
            feedbackForm1.Visible = false;
            cryptoForm1.Visible = false;
            charts1.Visible = false;

            DashboardForm dForm = dashboardForm1 as DashboardForm;

            if (dForm != null)
            {
                dForm.refreshData();
            }
        }

        private void addCategory_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = true;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;
            feedbackForm1.Visible = false;
            cryptoForm1.Visible = false;
            charts1.Visible = false;

            CategoryForm cForm = categoryForm1 as CategoryForm;

            if (cForm != null)
            {
                cForm.refreshData();
            }
        }

        private void income_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = true;
            expensesForm1.Visible = false;
            feedbackForm1.Visible = false;
            cryptoForm1.Visible = false;
            charts1.Visible = false;

            IncomeForm iForm = incomeForm1 as IncomeForm;

            if (iForm != null)
            {
                iForm.refreshData();
            }
        }

        private void expenses_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = true;
            feedbackForm1.Visible = false;
            cryptoForm1.Visible = false;
            charts1.Visible = false;

            ExpensesForm eForm = expensesForm1 as ExpensesForm;

            if (eForm != null)
            {
                eForm.refreshData();
            }
        }

        private void feedback_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;
            feedbackForm1.Visible = true;
            cryptoForm1.Visible = false;
            charts1.Visible = false;

            FeedbackForm fForm = feedbackForm1 as FeedbackForm;

            if (fForm != null)
            {
                fForm.refreshData();
            }
        }

        private void crypto_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;
            feedbackForm1.Visible = false;
            cryptoForm1.Visible = true;
            charts1.Visible = false;

            CryptoForm cryForm = cryptoForm1 as CryptoForm;

            if (cryForm != null)
            {
                cryForm.refreshData();
            }
        }

        private void chart_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;
            feedbackForm1.Visible = false;
            cryptoForm1.Visible = false;
            charts1.Visible = true;

            Charts chForm = charts1 as Charts;

            if (chForm != null)
            {
                chForm.refreshData();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
