using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution.LossQueuingSystem.Exstensions
{
    internal static class QueuingSystemOperation
    {
        internal static double ExpectedValue(double[] probabilitys, IOperationStep stepLogger)
        {
            double m = 0;
            stepLogger.Append($"m = M(X) = ");
            for (int i = 0; i < 5; i++)
            {
                m += i * probabilitys[i];
                stepLogger.Append($"{i} * {probabilitys[i]} + ");
            }
            m = Math.Round(m, 3);
            stepLogger.Append($" = {m}\n");

            return m;
        }

        internal static double Dispersion(double m,double[] probabilitys, IOperationStep stepLogger)
        {
            var localM = 0.0d;

            stepLogger.Append($"M(X^2) = ");
            for (int i = 0; i < 5; i++)
            {
                localM += Math.Pow(i, 2) * probabilitys[i];
                stepLogger.Append($"{Math.Pow(i, 2)} * {probabilitys[i]} + ");
            }
            stepLogger.Append($" = {localM}\n");

            var d = localM - Math.Pow(m, 2);
            stepLogger.Append($"D = {localM} - {Math.Pow(m,2)} = {d}\n");

            return d;
        }

        internal static double RMS(double D, IOperationStep stepLogger)
        {
            var o = Math.Sqrt(D);
            stepLogger.Append($"σ(X)=√(D(X)) = {o}\n");
            return o;
        }       
    }
}
