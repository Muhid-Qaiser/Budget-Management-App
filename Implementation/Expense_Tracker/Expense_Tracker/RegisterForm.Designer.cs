namespace Expense_Tracker
{
    partial class RegisterForm
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
            this.register_btn = new System.Windows.Forms.Button();
            this.register_showPass = new System.Windows.Forms.CheckBox();
            this.register_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.register_loginBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.register_cPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register_btn.Location = new System.Drawing.Point(386, 367);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(108, 49);
            this.register_btn.TabIndex = 17;
            this.register_btn.Text = "SIGNUP";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.Location = new System.Drawing.Point(613, 326);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(148, 24);
            this.register_showPass.TabIndex = 16;
            this.register_showPass.Text = "Show Password";
            this.register_showPass.UseVisualStyleBackColor = true;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
            // 
            // register_password
            // 
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(386, 210);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(375, 30);
            this.register_password.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // register_username
            // 
            this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(386, 134);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(375, 30);
            this.register_username.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Register Account";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(773, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 20);
            this.exit.TabIndex = 10;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.register_loginBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 452);
            this.panel1.TabIndex = 9;
            // 
            // register_loginBtn
            // 
            this.register_loginBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.register_loginBtn.FlatAppearance.BorderSize = 0;
            this.register_loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.register_loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.register_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register_loginBtn.Location = new System.Drawing.Point(39, 367);
            this.register_loginBtn.Name = "register_loginBtn";
            this.register_loginBtn.Size = new System.Drawing.Size(251, 49);
            this.register_loginBtn.TabIndex = 14;
            this.register_loginBtn.Text = "SIGN IN";
            this.register_loginBtn.UseVisualStyleBackColor = false;
            this.register_loginBtn.Click += new System.EventHandler(this.register_loginBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(82, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sign In Here";
            // 
            // register_cPassword
            // 
            this.register_cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_cPassword.Location = new System.Drawing.Point(386, 282);
            this.register_cPassword.Name = "register_cPassword";
            this.register_cPassword.PasswordChar = '*';
            this.register_cPassword.Size = new System.Drawing.Size(375, 30);
            this.register_cPassword.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Confirm Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(152, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 37);
            this.label7.TabIndex = 25;
            this.label7.Text = "View";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(96, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 37);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Expense_Tracker.Properties.Resources.accountant2;
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 187);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 452);
            this.Controls.Add(this.register_cPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.register_showPass);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.CheckBox register_showPass;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox register_cPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register_loginBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}