namespace Expense_Tracker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crypto_btn = new System.Windows.Forms.Button();
            this.feedback_btn = new System.Windows.Forms.Button();
            this.expenses_btn = new System.Windows.Forms.Button();
            this.addCategory_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.income_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greetUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart_btn = new System.Windows.Forms.Button();
            this.charts1 = new Expense_Tracker.Charts();
            this.dashboardForm1 = new Expense_Tracker.DashboardForm();
            this.expensesForm1 = new Expense_Tracker.ExpensesForm();
            this.incomeForm1 = new Expense_Tracker.IncomeForm();
            this.categoryForm2 = new Expense_Tracker.CategoryForm();
            this.categoryForm1 = new Expense_Tracker.CategoryForm();
            this.feedbackForm1 = new Expense_Tracker.FeedbackForm();
            this.cryptoForm1 = new Expense_Tracker.CryptoForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 45);
            this.panel1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1257, 14);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 20);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Income and Expense Tracker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.chart_btn);
            this.panel2.Controls.Add(this.crypto_btn);
            this.panel2.Controls.Add(this.feedback_btn);
            this.panel2.Controls.Add(this.expenses_btn);
            this.panel2.Controls.Add(this.addCategory_btn);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.income_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greetUser);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 666);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // crypto_btn
            // 
            this.crypto_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.crypto_btn.FlatAppearance.BorderSize = 0;
            this.crypto_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crypto_btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crypto_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.crypto_btn.Location = new System.Drawing.Point(19, 502);
            this.crypto_btn.Name = "crypto_btn";
            this.crypto_btn.Size = new System.Drawing.Size(122, 40);
            this.crypto_btn.TabIndex = 11;
            this.crypto_btn.Text = "Crypto";
            this.crypto_btn.UseVisualStyleBackColor = false;
            this.crypto_btn.Click += new System.EventHandler(this.crypto_btn_Click);
            // 
            // feedback_btn
            // 
            this.feedback_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.feedback_btn.FlatAppearance.BorderSize = 0;
            this.feedback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedback_btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feedback_btn.Location = new System.Drawing.Point(19, 445);
            this.feedback_btn.Name = "feedback_btn";
            this.feedback_btn.Size = new System.Drawing.Size(122, 40);
            this.feedback_btn.TabIndex = 10;
            this.feedback_btn.Text = "Feedback";
            this.feedback_btn.UseVisualStyleBackColor = false;
            this.feedback_btn.Click += new System.EventHandler(this.feedback_btn_Click);
            // 
            // expenses_btn
            // 
            this.expenses_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.expenses_btn.FlatAppearance.BorderSize = 0;
            this.expenses_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenses_btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expenses_btn.Location = new System.Drawing.Point(19, 389);
            this.expenses_btn.Name = "expenses_btn";
            this.expenses_btn.Size = new System.Drawing.Size(122, 40);
            this.expenses_btn.TabIndex = 9;
            this.expenses_btn.Text = "Expenses";
            this.expenses_btn.UseVisualStyleBackColor = false;
            this.expenses_btn.Click += new System.EventHandler(this.expenses_btn_Click);
            // 
            // addCategory_btn
            // 
            this.addCategory_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addCategory_btn.FlatAppearance.BorderSize = 0;
            this.addCategory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory_btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCategory_btn.Location = new System.Drawing.Point(19, 271);
            this.addCategory_btn.Name = "addCategory_btn";
            this.addCategory_btn.Size = new System.Drawing.Size(122, 40);
            this.addCategory_btn.TabIndex = 8;
            this.addCategory_btn.Text = "Category";
            this.addCategory_btn.UseVisualStyleBackColor = false;
            this.addCategory_btn.Click += new System.EventHandler(this.addCategory_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout_btn.Location = new System.Drawing.Point(19, 614);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(122, 40);
            this.logout_btn.TabIndex = 7;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // income_btn
            // 
            this.income_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.income_btn.FlatAppearance.BorderSize = 0;
            this.income_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.income_btn.Location = new System.Drawing.Point(19, 329);
            this.income_btn.Name = "income_btn";
            this.income_btn.Size = new System.Drawing.Size(122, 40);
            this.income_btn.TabIndex = 4;
            this.income_btn.Text = "Income";
            this.income_btn.UseVisualStyleBackColor = false;
            this.income_btn.Click += new System.EventHandler(this.income_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard_btn.Location = new System.Drawing.Point(19, 206);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(122, 40);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // greetUser
            // 
            this.greetUser.AutoSize = true;
            this.greetUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.greetUser.Location = new System.Drawing.Point(8, 146);
            this.greetUser.Name = "greetUser";
            this.greetUser.Size = new System.Drawing.Size(86, 22);
            this.greetUser.TabIndex = 2;
            this.greetUser.Text = "Welcome,";
            this.greetUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(37, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 87);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Controls.Add(this.expensesForm1);
            this.panel3.Controls.Add(this.incomeForm1);
            this.panel3.Controls.Add(this.categoryForm2);
            this.panel3.Controls.Add(this.categoryForm1);
            this.panel3.Controls.Add(this.feedbackForm1);
            this.panel3.Controls.Add(this.cryptoForm1);
            this.panel3.Controls.Add(this.charts1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(166, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1125, 666);
            this.panel3.TabIndex = 2;
            // 
            // chart_btn
            // 
            this.chart_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chart_btn.FlatAppearance.BorderSize = 0;
            this.chart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chart_btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chart_btn.Location = new System.Drawing.Point(19, 557);
            this.chart_btn.Name = "chart_btn";
            this.chart_btn.Size = new System.Drawing.Size(122, 40);
            this.chart_btn.TabIndex = 12;
            this.chart_btn.Text = "Charts";
            this.chart_btn.UseVisualStyleBackColor = false;
            this.chart_btn.Click += new System.EventHandler(this.chart_btn_Click);
            // 
            // charts1
            // 
            this.charts1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.charts1.Location = new System.Drawing.Point(0, 0);
            this.charts1.Name = "charts1";
            this.charts1.Size = new System.Drawing.Size(1125, 666);
            this.charts1.TabIndex = 7;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dashboardForm1.Location = new System.Drawing.Point(-3, 0);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1154, 746);
            this.dashboardForm1.TabIndex = 4;
            // 
            // expensesForm1
            // 
            this.expensesForm1.Location = new System.Drawing.Point(-3, 0);
            this.expensesForm1.Name = "expensesForm1";
            this.expensesForm1.Size = new System.Drawing.Size(1125, 666);
            this.expensesForm1.TabIndex = 4;
            // 
            // incomeForm1
            // 
            this.incomeForm1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.incomeForm1.Location = new System.Drawing.Point(0, 0);
            this.incomeForm1.Name = "incomeForm1";
            this.incomeForm1.Size = new System.Drawing.Size(1125, 666);
            this.incomeForm1.TabIndex = 3;
            // 
            // categoryForm2
            // 
            this.categoryForm2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryForm2.Location = new System.Drawing.Point(320, 16);
            this.categoryForm2.Name = "categoryForm2";
            this.categoryForm2.Size = new System.Drawing.Size(13, 10);
            this.categoryForm2.TabIndex = 2;
            // 
            // categoryForm1
            // 
            this.categoryForm1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryForm1.Location = new System.Drawing.Point(0, 0);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(1125, 666);
            this.categoryForm1.TabIndex = 0;
            // 
            // feedbackForm1
            // 
            this.feedbackForm1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.feedbackForm1.Location = new System.Drawing.Point(0, 0);
            this.feedbackForm1.Name = "feedbackForm1";
            this.feedbackForm1.Size = new System.Drawing.Size(1125, 666);
            this.feedbackForm1.TabIndex = 5;
            // 
            // cryptoForm1
            // 
            this.cryptoForm1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cryptoForm1.Location = new System.Drawing.Point(0, 0);
            this.cryptoForm1.Name = "cryptoForm1";
            this.cryptoForm1.Size = new System.Drawing.Size(1125, 666);
            this.cryptoForm1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 711);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label greetUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button income_btn;
        private System.Windows.Forms.Panel panel3;
        private CategoryForm categoryForm1;
        private System.Windows.Forms.Button logout_btn;
        private CategoryForm categoryForm2;
        private IncomeForm incomeForm1;
        private ExpensesForm expensesForm1;
        private DashboardForm dashboardForm1;
        private System.Windows.Forms.Button addCategory_btn;
        private System.Windows.Forms.Button expenses_btn;
        private FeedbackForm feedbackForm1;
        private System.Windows.Forms.Button feedback_btn;
        private CryptoForm cryptoForm1;
        private System.Windows.Forms.Button crypto_btn;
        private System.Windows.Forms.Button chart_btn;
        private Charts charts1;
    }
}