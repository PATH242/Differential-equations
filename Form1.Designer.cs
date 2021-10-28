
namespace Differential_Equations__ODE_approximation_and_actual_answer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_n0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_x0 = new System.Windows.Forms.TextBox();
            this.label_x0 = new System.Windows.Forms.Label();
            this.button_plot = new System.Windows.Forms.Button();
            this.textBox_y0 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label_N = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart_methods = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart_lte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart_gte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_methods)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_lte)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_gte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.textBox_n0);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_x0);
            this.panel1.Controls.Add(this.label_x0);
            this.panel1.Controls.Add(this.button_plot);
            this.panel1.Controls.Add(this.textBox_y0);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.textBox_X);
            this.panel1.Controls.Add(this.label_X);
            this.panel1.Controls.Add(this.textBox_N);
            this.panel1.Controls.Add(this.label_N);
            this.panel1.Location = new System.Drawing.Point(825, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 479);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox_n0
            // 
            this.textBox_n0.Location = new System.Drawing.Point(60, 199);
            this.textBox_n0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_n0.Name = "textBox_n0";
            this.textBox_n0.Size = new System.Drawing.Size(132, 22);
            this.textBox_n0.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "n₀";
            // 
            // textBox_x0
            // 
            this.textBox_x0.Location = new System.Drawing.Point(60, 36);
            this.textBox_x0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_x0.Name = "textBox_x0";
            this.textBox_x0.Size = new System.Drawing.Size(132, 22);
            this.textBox_x0.TabIndex = 12;
            this.textBox_x0.TextChanged += new System.EventHandler(this.textBox_x0_TextChanged);
            // 
            // label_x0
            // 
            this.label_x0.AutoSize = true;
            this.label_x0.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x0.Location = new System.Drawing.Point(25, 32);
            this.label_x0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_x0.Name = "label_x0";
            this.label_x0.Size = new System.Drawing.Size(35, 31);
            this.label_x0.TabIndex = 9;
            this.label_x0.Text = "x₀";
            // 
            // button_plot
            // 
            this.button_plot.BackColor = System.Drawing.Color.DarkGray;
            this.button_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_plot.Location = new System.Drawing.Point(60, 416);
            this.button_plot.Margin = new System.Windows.Forms.Padding(4);
            this.button_plot.Name = "button_plot";
            this.button_plot.Size = new System.Drawing.Size(133, 42);
            this.button_plot.TabIndex = 5;
            this.button_plot.Text = "Plot";
            this.button_plot.UseVisualStyleBackColor = false;
            this.button_plot.Click += new System.EventHandler(this.button_plot_Click);
            // 
            // textBox_y0
            // 
            this.textBox_y0.Location = new System.Drawing.Point(60, 87);
            this.textBox_y0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_y0.Name = "textBox_y0";
            this.textBox_y0.Size = new System.Drawing.Size(132, 22);
            this.textBox_y0.TabIndex = 16;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(47, 375);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(109, 21);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Runge Kutta";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "y₀";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(47, 319);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Euler";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(47, 347);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(125, 21);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Improved Euler";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(60, 144);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(132, 22);
            this.textBox_X.TabIndex = 13;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X.Location = new System.Drawing.Point(25, 145);
            this.label_X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(24, 22);
            this.label_X.TabIndex = 10;
            this.label_X.Text = "X";
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(60, 256);
            this.textBox_N.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(132, 22);
            this.textBox_N.TabIndex = 14;
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_N.Location = new System.Drawing.Point(25, 255);
            this.label_N.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(24, 22);
            this.label_N.TabIndex = 11;
            this.label_N.Text = "N";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 511);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart_methods);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(755, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Methods";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart_methods
            // 
            this.chart_methods.BackColor = System.Drawing.Color.PowderBlue;
            chartArea4.Name = "ChartArea1";
            this.chart_methods.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_methods.Legends.Add(legend4);
            this.chart_methods.Location = new System.Drawing.Point(3, 7);
            this.chart_methods.Margin = new System.Windows.Forms.Padding(4);
            this.chart_methods.Name = "chart_methods";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.LegendText = "Euler";
            series11.Name = "Series1";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.LegendText = "Improved Euler";
            series12.Name = "Series2";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.LegendText = "Runge Kutta";
            series13.Name = "Series3";
            series14.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.Lime;
            series14.Legend = "Legend1";
            series14.LegendText = "Exact";
            series14.Name = "Series4";
            this.chart_methods.Series.Add(series11);
            this.chart_methods.Series.Add(series12);
            this.chart_methods.Series.Add(series13);
            this.chart_methods.Series.Add(series14);
            this.chart_methods.Size = new System.Drawing.Size(743, 464);
            this.chart_methods.TabIndex = 0;
            this.chart_methods.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart_lte);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(821, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Local Errors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart_lte
            // 
            this.chart_lte.BackColor = System.Drawing.Color.PowderBlue;
            chartArea5.Name = "ChartArea1";
            this.chart_lte.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_lte.Legends.Add(legend5);
            this.chart_lte.Location = new System.Drawing.Point(8, 7);
            this.chart_lte.Margin = new System.Windows.Forms.Padding(4);
            this.chart_lte.Name = "chart_lte";
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.LegendText = "Euler";
            series15.Name = "Series1";
            series16.BorderWidth = 2;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.LegendText = "Improved Euler";
            series16.Name = "Series2";
            series17.BorderWidth = 2;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.LegendText = "Runge Kutta";
            series17.Name = "Series3";
            this.chart_lte.Series.Add(series15);
            this.chart_lte.Series.Add(series16);
            this.chart_lte.Series.Add(series17);
            this.chart_lte.Size = new System.Drawing.Size(736, 468);
            this.chart_lte.TabIndex = 24;
            this.chart_lte.Text = "chart_lte";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart_gte);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(821, 482);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Global Errors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart_gte
            // 
            this.chart_gte.BackColor = System.Drawing.Color.PowderBlue;
            chartArea6.Name = "ChartArea1";
            this.chart_gte.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_gte.Legends.Add(legend6);
            this.chart_gte.Location = new System.Drawing.Point(4, 4);
            this.chart_gte.Margin = new System.Windows.Forms.Padding(4);
            this.chart_gte.Name = "chart_gte";
            series18.BorderWidth = 2;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.LegendText = "Euler";
            series18.Name = "Series1";
            series19.BorderWidth = 2;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Legend = "Legend1";
            series19.LegendText = "Improved Euler";
            series19.Name = "Series2";
            series20.BorderWidth = 2;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.LegendText = "Runge Kutta";
            series20.Name = "Series3";
            this.chart_gte.Series.Add(series18);
            this.chart_gte.Series.Add(series19);
            this.chart_gte.Series.Add(series20);
            this.chart_gte.Size = new System.Drawing.Size(740, 468);
            this.chart_gte.TabIndex = 25;
            this.chart_gte.Text = "chart_gte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1081, 589);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_methods)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_lte)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_gte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_n0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_x0;
        private System.Windows.Forms.Label label_x0;
        private System.Windows.Forms.Button button_plot;
        private System.Windows.Forms.TextBox textBox_y0;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_methods;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_lte;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_gte;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

