namespace Expense_Tracker
{
    partial class Form1
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_signupBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.login_signupBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 450);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(155, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 37);
            this.label7.TabIndex = 22;
            this.label7.Text = "View";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(99, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 37);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Expense_Tracker.Properties.Resources.accountant2;
            this.pictureBox1.Location = new System.Drawing.Point(40, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 187);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // login_signupBtn
            // 
            this.login_signupBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_signupBtn.FlatAppearance.BorderSize = 0;
            this.login_signupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.login_signupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.login_signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_signupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_signupBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_signupBtn.Location = new System.Drawing.Point(51, 360);
            this.login_signupBtn.Name = "login_signupBtn";
            this.login_signupBtn.Size = new System.Drawing.Size(251, 49);
            this.login_signupBtn.TabIndex = 10;
            this.login_signupBtn.Text = "SIGNUP";
            this.login_signupBtn.UseVisualStyleBackColor = false;
            this.login_signupBtn.Click += new System.EventHandler(this.login_signupBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(82, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Register Here";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(767, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 20);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // login_username
            // 
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(384, 173);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(375, 30);
            this.login_username.TabIndex = 4;
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(384, 260);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(375, 30);
            this.login_password.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // login_showPass
            // 
            this.login_showPass.AutoSize = true;
            this.login_showPass.Location = new System.Drawing.Point(611, 305);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(148, 24);
            this.login_showPass.TabIndex = 7;
            this.login_showPass.Text = "Show Password";
            this.login_showPass.UseVisualStyleBackColor = true;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_btn.Location = new System.Drawing.Point(385, 361);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(108, 49);
            this.login_btn.TabIndex = 8;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_showPass);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox login_showPass;
        private System.Windows.Forms.Button login_signupBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}