using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class FeedbackForm : UserControl
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\angry.png";
            angry.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\sad2.png";
            sad.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\neutral2.png";
            neutral.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\happy2.png";
            happy.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\surprised2.png";
            surprised.Image = Image.FromFile(imagePath);



        }

        private void surprised_Click(object sender, EventArgs e)
        {
            string imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\angry3.png";
            angry.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\sad2.png";
            sad.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\neutral2.png";
            neutral.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\happy2.png";
            happy.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\surprised.png";
            surprised.Image = Image.FromFile(imagePath);
        }

        private void neutral_Click(object sender, EventArgs e)
        {
            string imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\angry3.png";
            angry.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\sad2.png";
            sad.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\neutral.png";
            neutral.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\happy2.png";
            happy.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\surprised2.png";
            surprised.Image = Image.FromFile(imagePath);
        }

        private void sad_Click(object sender, EventArgs e)
        {
            string imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\angry3.png";
            angry.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\sad.png";
            sad.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\neutral2.png";
            neutral.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\happy2.png";
            happy.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\surprised2.png";
            surprised.Image = Image.FromFile(imagePath);
        }

        private void happy_Click(object sender, EventArgs e)
        {
            string imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\angry3.png";
            angry.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\sad2.png";
            sad.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\neutral2.png";
            neutral.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\happy.png";
            happy.Image = Image.FromFile(imagePath);

            imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\surprised2.png";
            surprised.Image = Image.FromFile(imagePath);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clearFields()
        {
            feedback_box.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( feedback_box.Text == "" )
            {
                MessageBox.Show("Please fill the blank field first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {
                MessageBox.Show("Your Feedback has been Submit. Thank you!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\angry3.png";
                angry.Image = Image.FromFile(imagePath);

                imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\sad2.png";
                sad.Image = Image.FromFile(imagePath);

                imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\neutral2.png";
                neutral.Image = Image.FromFile(imagePath);

                imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\happy2.png";
                happy.Image = Image.FromFile(imagePath);

                imagePath = "D:\\Documents-D\\University\\Semester 4\\FSE\\my own ting - Modified\\Expense_Tracker\\Expense_Tracker\\Assets\\surprised2.png";
                surprised.Image = Image.FromFile(imagePath);
            }
            clearFields();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
