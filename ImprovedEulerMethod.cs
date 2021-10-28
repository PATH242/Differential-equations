using System;

namespace Differential_Equations__ODE_approximation_and_actual_answer
{
    class ImprovedEulerMethod : NumericalMethod
    {
        public new double[] x, y, e;
        public double maxError;
        public ImprovedEulerMethod(int n, double xNode, double yNode, double X) : base(n, xNode, yNode, X)
        {
            x = new double[n + 1];
            y = new double[n + 1];
            e = new double[n + 1];
            x[0] = xNode;
            y[0] = yNode;
        }

        public double calculateImprovedEuler()
        {
            maxError = 0;
            double tempPart;
            for (int i = 1; i < n; i++)
            {
                x[i] = x[i - 1] + h;
                tempPart = getYPrime(x[i - 1], y[i - 1]) + getYPrime(x[i - 1] + h, y[i - 1] + h * (getYPrime(x[i - 1], y[i - 1])));
                y[i] = y[i - 1] + (h / 2.0 * tempPart);
                e[i] = Math.Abs(y[i] - getExactY(x[i]));

                maxError = Math.Max(maxError, e[i]);

                overflowChecker(x[i], y[i], e[i]);

            }
            return maxError;
        }
    }

}
