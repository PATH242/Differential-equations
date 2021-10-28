using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Differential_Equations__ODE_approximation_and_actual_answer
{
    class EulerMethod : NumericalMethod
    {
        public new double[] x, y, e;
        public double maxError = 0;
        public EulerMethod(int n, double xNode, double yNode, double X) : base(n, xNode, yNode, X)
        {
            x = new double[n + 1];
            y = new double[n + 1];
            e = new double[n + 1];
            x[0] = xNode;
            y[0] = yNode;

        }
        public double calculateEuler()
        {
            maxError = 0;
            for (int i = 1; i < n; i++)
            {
                x[i] = x[i - 1] + h;
                y[i] = y[i - 1] + h * getYPrime(x[i - 1], y[i - 1]);

                e[i] = Math.Abs(y[i] - getExactY(x[i]));
                maxError = Math.Max(maxError, e[i]);

                overflowChecker(x[i], y[i], e[i]);

            }
            return maxError;
        }
    }
}
