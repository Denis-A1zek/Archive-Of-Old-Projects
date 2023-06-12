using Sigida.MathModeling.Domain.Extension;
using Sigida.MathModeling.Domain.Solution.LossQueuingSystem.Exstensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution.LossQueuingSystem.CallFlow.PrimitiveCallFlow
{
    internal class DistributionLawPrimitive 
    {
        private double _N;
        private double _a;
        private IOperationStep _stepLogger;
        public DistributionLawPrimitive(double N, double a, IOperationStep step)
        {
            _N = N;
            _a = a;
            _stepLogger = step;
        }

        public double MaxProb { get; private set; }
        public void Calculate()
        {
            var prob = GetProbabilitys();

            var m = QueuingSystemOperation.ExpectedValue(prob, _stepLogger);
            var d = QueuingSystemOperation.Dispersion(m, prob, _stepLogger);
            var o = QueuingSystemOperation.RMS(d, _stepLogger);

            MaxProb = prob[4];

            var a = _a / (1+_a);
            _stepLogger.Append($"Среднее время занятости канала \n a= {_a} / {1} + {+_a} = {a}\n");

            _stepLogger.Append($"Вероятность того, что все каналы заняты: \n p_n=ε(N,n,a)= ε({_N},{4},{_a} = {prob[4]}\n");
        }



        private double[] GetProbabilitys()
        {
            var C = CalculateC();
            double[] p = new double[5];

            _stepLogger.Append($"Тогда:\n");

            for (int i = 0; i < 5; i++)
            {
                var Ci = ((Operation.Factorial(_N)) / (((Operation.Factorial(i)) * (Operation.Factorial(_N - i))))) * (Math.Pow(_a, i));
                p[i] = Math.Round(Ci /(C),10);
                _stepLogger.Append($"p{i} = {Ci}/{C} = {p[i]}]\n");
            }

            _stepLogger.Append($"Проверим, что ∑_(k=0)^n▒〖p_k=1〗\n");

            _stepLogger.Append($"p_0+p_1+p_2+p_3+p_4 = {p[0]} + {p[1]} + {p[2]} + {p[3]} + {p[4]} = {p.Sum()}\n");

           

            return p;
        }

        private double CalculateC()
        {
            var n = 4;

            _stepLogger.Append($"\n 1) Построим закон распределения числа занятых каналов: \n");
            _stepLogger.Append($"∑ C^j * {_a}^j =");

            var C = 0d;
            for (int i = 0; i < 5; i++)
            {
                var Ck = (Operation.Factorial(_N)) / (Operation.Factorial(i) * (Operation.Factorial(_N - i)));
                _stepLogger.Append($"{Ck} * {Math.Pow(_a, i)} + ");
                C += Ck * Math.Pow(_a, i);
            }

            _stepLogger.Append($" = {C}\n");

            return C;
        }



    }
}
