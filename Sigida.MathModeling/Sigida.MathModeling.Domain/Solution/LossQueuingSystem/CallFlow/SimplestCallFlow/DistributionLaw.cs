using Sigida.MathModeling.Domain.Extension;
using Sigida.MathModeling.Domain.Solution.LossQueuingSystem.Exstensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution
{
    internal class DistributionLaw
    {
        private IOperationStep step;
        private double _gamma;

        public DistributionLaw(double gamma, IOperationStep operationStep)
        {
            _gamma = gamma;
            step = operationStep;
        }

        internal double[] Probabilitys { get; private set; }

        internal double M { get; private set; }
        internal double D { get; private set; }

        internal double O { get; private set; }

        internal void Calculate()
        {
            BusyChannelsCalculate();

            step.Append($"Проверим ∑p = 1:\n " +
                $"{Probabilitys[0]} + {Probabilitys[1]} " +
                $"+ {Probabilitys[2]} + {Probabilitys[3]} " +
                $"= {Probabilitys.Sum()}\n\n");

            M = QueuingSystemOperation.ExpectedValue(Probabilitys, step);
            D = QueuingSystemOperation.Dispersion(M, Probabilitys, step);
            O = QueuingSystemOperation.RMS(D, step);
        }

        private void BusyChannelsCalculate()
        {
            var arrayP = new double[5];

            arrayP[0] =  Math.Round((1) / (1 + _gamma +
                            (Math.Pow(_gamma, 2) / (Operation.Factorial(2))) +
                             (Math.Pow(_gamma, 3) / (Operation.Factorial(3))) +
                              (Math.Pow(_gamma, 4) / (Operation.Factorial(4)))), 10);
            step.Append($"p0 = (1) / 1 + {_gamma} + " +
                            $"{Math.Pow(_gamma, 2)} / {(Operation.Factorial(2))} + " +
                             $"{Math.Pow(_gamma, 3)} / {Operation.Factorial(3)} + " +
                              $"{Math.Pow(_gamma, 4)} / {Operation.Factorial(4)} = {arrayP[0]}\n");

            arrayP[1] = _gamma * arrayP[0];
            step.Append($"p1 ={_gamma} * {arrayP[0]} = {arrayP[1]}\n");

            for (int i = 2; i < 5; i++)
            {
                arrayP[i] = Math.Pow(_gamma, i) / (Operation.Factorial(i)) * arrayP[0];
                step.Append($"p{i} = {Math.Pow(_gamma, i)} / {(Operation.Factorial(i))} * {arrayP[0]} = {arrayP[i]}\n");
            }

            Probabilitys = arrayP;
        }
     
    }
}
