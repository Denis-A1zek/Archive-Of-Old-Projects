using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Extension
{
    public static class Operation
    {
        public static double Factorial(double n)
        {
            double factiroal = 1;
            for (double i = 2; i <= n; i++)
            {
                factiroal *= i;
            }
            return factiroal;
        }
    }
}
