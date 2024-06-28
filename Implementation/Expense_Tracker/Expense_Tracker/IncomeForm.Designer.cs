﻿namespace Expense_Tracker
{
    partial class IncomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Income = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.income_clearBtn = new System.Windows.Forms.Button();
            this.income_deleteBtn = new System.Windows.Forms.Button();
            this.income_updateBtn = new System.Windows.Forms.Button();
            this.income_addBtn = new System.Windows.Forms.Button();
            this.income_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.income_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.income_income = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.income_item = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.income_category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Income);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 355);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 303);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Income
            // 
            this.Income.AutoSize = true;
            this.Income.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income.Location = new System.Drawing.Point(12, 12);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(113, 24);
            this.Income.TabIndex = 1;
            this.Income.Text = "Income List";
            this.Income.Click += new System.EventHandler(this.Income_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.income_clearBtn);
            this.panel2.Controls.Add(this.income_deleteBtn);
            this.panel2.Controls.Add(this.income_updateBtn);
            this.panel2.Controls.Add(this.income_addBtn);
            this.panel2.Controls.Add(this.income_date);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.income_description);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.income_income);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.income_item);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.income_category);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 283);
            this.panel2.TabIndex = 1;
            // 
            // income_clearBtn
            // 
            this.income_clearBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.income_clearBtn.FlatAppearance.BorderSize = 0;
            this.income_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.income_clearBtn.Location = new System.Drawing.Point(723, 219);
            this.income_clearBtn.Name = "income_clearBtn";
            this.income_clearBtn.Size = new System.Drawing.Size(97, 40);
            this.income_clearBtn.TabIndex = 15;
            this.income_clearBtn.Text = "Clear";
            this.income_clearBtn.UseVisualStyleBackColor = false;
            this.income_clearBtn.Click += new System.EventHandler(this.income_clearBtn_Click);
            // 
            // income_deleteBtn
            // 
            this.income_deleteBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.income_deleteBtn.FlatAppearance.BorderSize = 0;
            this.income_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.income_deleteBtn.Location = new System.Drawing.Point(581, 219);
            this.income_deleteBtn.Name = "income_deleteBtn";
            this.income_deleteBtn.Size = new System.Drawing.Size(97, 40);
            this.income_deleteBtn.TabIndex = 14;
            this.income_deleteBtn.Text = "Delete";
            this.income_deleteBtn.UseVisualStyleBackColor = false;
            this.income_deleteBtn.Click += new System.EventHandler(this.income_deleteBtn_Click);
            // 
            // income_updateBtn
            // 
            this.income_updateBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.income_updateBtn.FlatAppearance.BorderSize = 0;
            this.income_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_updateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.income_updateBtn.Location = new System.Drawing.Point(394, 219);
            this.income_updateBtn.Name = "income_updateBtn";
            this.income_updateBtn.Size = new System.Drawing.Size(97, 40);
            this.income_updateBtn.TabIndex = 13;
            this.income_updateBtn.Text = "Update";
            this.income_updateBtn.UseVisualStyleBackColor = false;
            this.income_updateBtn.Click += new System.EventHandler(this.income_updateBtn_Click);
            // 
            // income_addBtn
            // 
            this.income_addBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.income_addBtn.FlatAppearance.BorderSize = 0;
            this.income_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.income_addBtn.Location = new System.Drawing.Point(252, 219);
            this.income_addBtn.Name = "income_addBtn";
            this.income_addBtn.Size = new System.Drawing.Size(97, 40);
            this.income_addBtn.TabIndex = 12;
            this.income_addBtn.Text = "Add";
            this.income_addBtn.UseVisualStyleBackColor = false;
            this.income_addBtn.Click += new System.EventHandler(this.income_addBtn_Click);
            // 
            // income_date
            // 
            this.income_date.Location = new System.Drawing.Point(630, 137);
            this.income_date.Name = "income_date";
            this.income_date.Size = new System.Drawing.Size(288, 26);
            this.income_date.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(555, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // income_description
            // 
            this.income_description.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_description.Location = new System.Drawing.Point(630, 25);
            this.income_description.Multiline = true;
            this.income_description.Name = "income_description";
            this.income_description.Size = new System.Drawing.Size(409, 80);
            this.income_description.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // income_income
            // 
            this.income_income.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_income.Location = new System.Drawing.Point(179, 136);
            this.income_income.Name = "income_income";
            this.income_income.Size = new System.Drawing.Size(223, 27);
            this.income_income.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Income:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // income_item
            // 
            this.income_item.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_item.Location = new System.Drawing.Point(179, 78);
            this.income_item.Name = "income_item";
            this.income_item.Size = new System.Drawing.Size(223, 27);
            this.income_item.TabIndex = 5;
            this.income_item.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item:";
            // 
            // income_category
            // 
            this.income_category.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_category.FormattingEnabled = true;
            this.income_category.Location = new System.Drawing.Point(179, 25);
            this.income_category.Name = "income_category";
            this.income_category.Size = new System.Drawing.Size(223, 27);
            this.income_category.TabIndex = 3;
            this.income_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category: ";
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeForm";
            this.Size = new System.Drawing.Size(1125, 682);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Income;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox income_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox income_item;
        private System.Windows.Forms.TextBox income_income;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox income_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker income_date;
        private System.Windows.Forms.Button income_clearBtn;
        private System.Windows.Forms.Button income_deleteBtn;
        private System.Windows.Forms.Button income_updateBtn;
        private System.Windows.Forms.Button income_addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
