namespace Expense_Tracker
{
    partial class Charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.income_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.expenses_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.income_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenses_chart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income Chart";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expenses Chart";
            // 
            // income_chart
            // 
            chartArea3.Name = "ChartArea1";
            this.income_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.income_chart.Legends.Add(legend3);
            this.income_chart.Location = new System.Drawing.Point(44, 170);
            this.income_chart.Name = "income_chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.income_chart.Series.Add(series3);
            this.income_chart.Size = new System.Drawing.Size(500, 479);
            this.income_chart.TabIndex = 2;
            this.income_chart.Text = "Income";
            this.income_chart.Click += new System.EventHandler(this.income_chart_Click);
            // 
            // expenses_chart
            // 
            chartArea4.Name = "ChartArea1";
            this.expenses_chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.expenses_chart.Legends.Add(legend4);
            this.expenses_chart.Location = new System.Drawing.Point(585, 170);
            this.expenses_chart.Name = "expenses_chart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.expenses_chart.Series.Add(series4);
            this.expenses_chart.Size = new System.Drawing.Size(500, 479);
            this.expenses_chart.TabIndex = 3;
            this.expenses_chart.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 78);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(324, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Visual Analysis Charts";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Expense_Tracker.Properties.Resources.chart4;
            this.pictureBox1.Location = new System.Drawing.Point(747, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expenses_chart);
            this.Controls.Add(this.income_chart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Charts";
            this.Size = new System.Drawing.Size(1125, 682);
            ((System.ComponentModel.ISupportInitialize)(this.income_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenses_chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart income_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart expenses_chart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
