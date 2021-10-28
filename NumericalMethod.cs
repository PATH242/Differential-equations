using System;

namespace Differential_Equations__ODE_approximation_and_actual_answer
{
    class NumericalMethod
    {
        protected double xNode, yNode, X, h, exactConst;
        public int n;
        public double[] x, y;
        private double stepValue = 0.01; //for the graph representation 
        public NumericalMethod(int n, double xNode, double yNode, double X)
        {
            this.n = n + 1;
            this.xNode = xNode;
            this.yNode = yNode;
            this.X = X;
            h = (X - xNode) / n;
            exactConst = Math.Exp(xNode) * yNode - Math.Exp(2 * xNode); ///the constant of our specific equation
        }
        protected double getExactY(double currentX)
        {
            double part1 = Math.Exp(2 * currentX) + exactConst, part2;
            part2 = Math.Exp(-currentX);
            return part1 * part2;

        }
        public void calculateExactYValues()
        {
            int size = (int)((X - xNode) / stepValue);
            x = new double[size + 1];
            y = new double[size + 1];
            int ind = 0; //index
            for (double i = xNode; i <= X; i += stepValue)
            {
                x[ind] = i;
                y[ind] = getExactY(i);
                ind++;
            }

        }
        protected double getYPrime(double currentX, double currentY)
        {
            double part1 = 2 * Math.Exp(currentX);
            return part1 - currentY;

        }
        protected void overflowChecker(double a, double b, double c)
        {
            if (double.IsInfinity(a) || double.IsInfinity(b) || double.IsInfinity(c))
            {
                //MessageBox.Show("Overflow happened!");
                //Application.Exit();
            }
        }
    }
}
