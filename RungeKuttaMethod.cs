using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Differential_Equations__ODE_approximation_and_actual_answer
{
    class RungeKuttaMethod : NumericalMethod
    {
        public new double[] x, y, e;
        double maxError;
        public RungeKuttaMethod(int n, double xNode, double yNode, double X) : base(n, xNode, yNode, X)
        {
            x = new double[n + 1];
            y = new double[n + 1];
            e = new double[n + 1];
            x[0] = xNode;
            y[0] = yNode;
        }

        public double calculateRungeKutta()
        {
            maxError = 0;
            double k1, k2, k3, k4;
            for (int i = 1; i < n; i++)
            {
                x[i] = x[i - 1] + h;

                k1 = getYPrime(x[i - 1], y[i - 1]);
                k2 = getYPrime(x[i - 1] + h / 2.0, y[i - 1] + h / 2.0 * k1);
                k3 = getYPrime(x[i - 1] + h / 2.0, y[i - 1] + h / 2.0 * k2);
                k4 = getYPrime(x[i - 1] + h, y[i - 1] + h * k3);

                y[i] = y[i - 1] + h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
                e[i] = Math.Abs(e[i] - getExactY(x[i]));

                maxError = Math.Max(maxError, e[i]);

                overflowChecker(x[i], y[i], e[i]);

            }
            return maxError;
        }
    }
}
