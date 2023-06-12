using Sigida.MathModeling.Domain.Interface;
using Sigida.MathModeling.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution
{
    internal class ContinuouRandomVariables : ITask
    {
        private readonly MyRange range;
        private readonly double lambda;
        private readonly double m;
        private readonly double o;
        private readonly IOperationStep step;

        public ContinuouRandomVariables(MyRange range,double lambda, double m, double o, IOperationStep step)
        {
            this.range=range;
            this.lambda=lambda;
            this.m=m;
            this.o=o;
            this.step=step;
        }
        public void Run()
        {
            step.Append("\nЗадание № 3");
            InverseFunctionMethod();
            step.Append("\n\nЗадание № 4");
            InverseFunctionMethod(lambda);
            step.Append("\n\nЗадание № 5");
            InverseFunctionMethod(m, o);
        }

        public void InverseFunctionMethod()
        {
            step.Append($@"

                               |-
                               |0, x <= {range.Start},
                        F(x) = |x - {range.Start}
                               |-------, {range.Start} < x <= {range.End}
                               | {(range.End) - (range.Start)}
                               |1, x > {range.End}
                               |-
            ");

            var result = new double[4];

            for (int i = 0; i < 4; i++)
            {
                var random = new Random().NextDouble();
                result[i] = ((range.End) - (range.Start)) * random + (range.Start);
                step.Append($"\nr {i+1} = {random}, x{i+1} = {(range.End - range.Start)} * {random} + {range.Start} = {result[i]}");
            }

            step.Append($"\nТаким образом, смоделированы возможные значения случайной величины X:\n");
            foreach (var item in result)
            {
                step.Append($"{item}; ");
            }
        }

        public void InverseFunctionMethod(double lambda)
        {

            var result = new double[5];

            for (int i = 0; i < 5; i++)
            {
                var random = new Random().NextDouble();
                result[i] = (-(1/ (lambda))) * (Math.Log(random));
                step.Append($"\nr {i+1} = {random}, x{i+1} = {(-(1/ (lambda)))} * {Math.Log(random)} = {result[i]}");
            }

            step.Append($"\nТаким образом, смоделированы возможные значения случайной величины X:\n");
            foreach (var item in result)
            {
                step.Append($"{item}; ");
            }
        }

        public void InverseFunctionMethod(double m = 2, double o = 3)
        {
            var randomValues = new double[] { 0.06, -1.10, -1.52, 0.83 };


            var result = new double[4];

            for (int i = 0; i < 4; i++)
            {
                result[i] = (o) * (randomValues[i]) + m;
                step.Append($"\nx{i+1} = {o} * {randomValues[i]} + {m} = {result[i]}");
            }

            step.Append($"\nТаким образом, смоделированы возможные значения случайной величины X:\n");
            foreach (var item in result)
            {
                step.Append($"{item}; ");
            }
        }
    }
}
