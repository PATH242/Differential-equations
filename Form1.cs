using System;
using System.Windows.Forms;

namespace Differential_Equations__ODE_approximation_and_actual_answer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_x0_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_plot_Click(object sender, EventArgs e)
        {
            double xNode = 0, yNode = 0, X = 0;
            int nNode = 0, N = 0;
            try
            {
                xNode = double.Parse(textBox_x0.Text);
                yNode = double.Parse(textBox_y0.Text);
                X = double.Parse(textBox_X.Text);
                nNode = int.Parse(textBox_n0.Text);
                N = int.Parse(textBox_N.Text);
                if (nNode <= 0 || N <= 0 || nNode >= N || xNode >= X) throw new Exception();
            }
            catch
            {
                MessageBox.Show("Invalid input\n");
                Application.Exit();
            }

            ///calculating GTE
            int[] GTEx = new int[N - nNode + 1];
            double[] GTEeuler = new double[N - nNode + 1], GTEimprovedEuler = new double[N - nNode + 1], GTErungeKutta = new double[N - nNode + 1];
            for (int i = nNode; i <= N; i++)
            {
                GTEx[i - nNode] = i;
                EulerMethod eulerTemp = new EulerMethod(i, xNode, yNode, X);
                ImprovedEulerMethod improvedEulerTemp = new ImprovedEulerMethod (i, xNode, yNode, X);
                RungeKuttaMethod rungeKuttaTemp = new RungeKuttaMethod(i, xNode, yNode, X);

                GTEeuler[i - nNode] = eulerTemp.calculateEuler();
                GTEimprovedEuler[i - nNode] = improvedEulerTemp.calculateImprovedEuler();
                GTErungeKutta[i - nNode] = rungeKuttaTemp.calculateRungeKutta();
            }


            NumericalMethod exact = new NumericalMethod(N, xNode, yNode, X);
            exact.calculateExactYValues();
            chart_methods.Series[3].Points.DataBindXY(exact.x, exact.y);

            if (checkBox1.Checked)
            {
                EulerMethod eulerMethod = new EulerMethod(N, xNode, yNode, X);
                eulerMethod.calculateEuler();
                chart_methods.Series[0].Points.DataBindXY(eulerMethod.x, eulerMethod.y);
                chart_lte.Series[0].Points.DataBindXY(eulerMethod.x, eulerMethod.e);
                chart_gte.Series[0].Points.DataBindXY(GTEx, GTEeuler);
            }
            if (checkBox2.Checked)
            {
                ImprovedEulerMethod improvedEulerMethod = new ImprovedEulerMethod (N, xNode, yNode, X);
                improvedEulerMethod.calculateImprovedEuler();
                chart_methods.Series[1].Points.DataBindXY(improvedEulerMethod.x, improvedEulerMethod.y);
                chart_lte.Series[1].Points.DataBindXY(improvedEulerMethod.x, improvedEulerMethod.e);
                chart_gte.Series[1].Points.DataBindXY(GTEx, GTEimprovedEuler);
            }
            if (checkBox3.Checked)
            {
                RungeKuttaMethod rungeKuttaMethod = new RungeKuttaMethod(N, xNode, yNode, X);
                rungeKuttaMethod.calculateRungeKutta();
                chart_methods.Series[2].Points.DataBindXY(rungeKuttaMethod.x, rungeKuttaMethod.y);
                chart_lte.Series[2].Points.DataBindXY(rungeKuttaMethod.x, rungeKuttaMethod.e);
                chart_gte.Series[2].Points.DataBindXY(GTEx, GTErungeKutta);
            }

            chart_methods.ChartAreas[0].AxisX.Minimum = xNode;
            chart_methods.ChartAreas[0].AxisX.Maximum = X;
            chart_lte.ChartAreas[0].AxisX.Minimum = xNode;
            chart_lte.ChartAreas[0].AxisX.Maximum = X;
            chart_gte.ChartAreas[0].AxisX.Minimum = nNode;
            chart_gte.ChartAreas[0].AxisX.Maximum = N;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chart_methods.Series[0].Enabled = checkBox1.Checked;
            chart_lte.Series[0].Enabled = checkBox1.Checked;
            chart_gte.Series[0].Enabled = checkBox1.Checked;
            button_plot_Click(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            chart_methods.Series[1].Enabled = checkBox2.Checked;
            chart_lte.Series[1].Enabled = checkBox2.Checked;
            chart_gte.Series[1].Enabled = checkBox2.Checked;
            button_plot_Click(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            chart_methods.Series[2].Enabled = checkBox3.Checked;
            chart_lte.Series[2].Enabled = checkBox3.Checked;
            chart_gte.Series[2].Enabled = checkBox3.Checked;
            button_plot_Click(sender, e);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MaximizeBox = false;

           // Initial textboxes data.
            textBox_x0.Text = "0";
            textBox_y0.Text = "0";
            textBox_X.Text = "7";
            textBox_n0.Text = "1";
            textBox_N.Text = "10";
            button_plot_Click(sender, e);
        }
    }
}
