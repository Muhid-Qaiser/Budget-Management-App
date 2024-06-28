namespace Expense_Tracker
{
    partial class FeedbackForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.feedback_box = new System.Windows.Forms.TextBox();
            this.happy = new System.Windows.Forms.PictureBox();
            this.surprised = new System.Windows.Forms.PictureBox();
            this.sad = new System.Windows.Forms.PictureBox();
            this.neutral = new System.Windows.Forms.PictureBox();
            this.angry = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.happy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surprised)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neutral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angry)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.happy);
            this.panel1.Controls.Add(this.surprised);
            this.panel1.Controls.Add(this.sad);
            this.panel1.Controls.Add(this.neutral);
            this.panel1.Controls.Add(this.angry);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(21, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 638);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "How was your experience?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Expense_Tracker.Properties.Resources.rocket1;
            this.pictureBox6.Location = new System.Drawing.Point(709, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(79, 88);
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Drop Us a Feedback";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(36, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 10);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.feedback_box);
            this.panel3.Location = new System.Drawing.Point(188, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 240);
            this.panel3.TabIndex = 17;
            // 
            // feedback_box
            // 
            this.feedback_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback_box.ForeColor = System.Drawing.SystemColors.InfoText;
            this.feedback_box.Location = new System.Drawing.Point(3, 3);
            this.feedback_box.Multiline = true;
            this.feedback_box.Name = "feedback_box";
            this.feedback_box.Size = new System.Drawing.Size(796, 219);
            this.feedback_box.TabIndex = 1;
            // 
            // happy
            // 
            this.happy.Image = global::Expense_Tracker.Properties.Resources.happy2;
            this.happy.Location = new System.Drawing.Point(744, 126);
            this.happy.Name = "happy";
            this.happy.Size = new System.Drawing.Size(83, 92);
            this.happy.TabIndex = 16;
            this.happy.TabStop = false;
            this.happy.Click += new System.EventHandler(this.happy_Click);
            // 
            // surprised
            // 
            this.surprised.Image = global::Expense_Tracker.Properties.Resources.surprised2;
            this.surprised.Location = new System.Drawing.Point(917, 126);
            this.surprised.Name = "surprised";
            this.surprised.Size = new System.Drawing.Size(83, 92);
            this.surprised.TabIndex = 15;
            this.surprised.TabStop = false;
            this.surprised.Click += new System.EventHandler(this.surprised_Click);
            // 
            // sad
            // 
            this.sad.Image = global::Expense_Tracker.Properties.Resources.sad2;
            this.sad.Location = new System.Drawing.Point(357, 126);
            this.sad.Name = "sad";
            this.sad.Size = new System.Drawing.Size(86, 92);
            this.sad.TabIndex = 14;
            this.sad.TabStop = false;
            this.sad.Click += new System.EventHandler(this.sad_Click);
            // 
            // neutral
            // 
            this.neutral.Image = global::Expense_Tracker.Properties.Resources.neutral2;
            this.neutral.Location = new System.Drawing.Point(542, 126);
            this.neutral.Name = "neutral";
            this.neutral.Size = new System.Drawing.Size(85, 92);
            this.neutral.TabIndex = 13;
            this.neutral.TabStop = false;
            this.neutral.Click += new System.EventHandler(this.neutral_Click);
            // 
            // angry
            // 
            this.angry.Image = global::Expense_Tracker.Properties.Resources.angry3;
            this.angry.Location = new System.Drawing.Point(188, 126);
            this.angry.Name = "angry";
            this.angry.Size = new System.Drawing.Size(90, 92);
            this.angry.TabIndex = 12;
            this.angry.TabStop = false;
            this.angry.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "FeedBack";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(843, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Name = "FeedbackForm";
            this.Size = new System.Drawing.Size(1125, 682);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.happy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surprised)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neutral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox feedback_box;
        private System.Windows.Forms.PictureBox happy;
        private System.Windows.Forms.PictureBox surprised;
        private System.Windows.Forms.PictureBox sad;
        private System.Windows.Forms.PictureBox neutral;
        private System.Windows.Forms.PictureBox angry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label3;
    }
}
