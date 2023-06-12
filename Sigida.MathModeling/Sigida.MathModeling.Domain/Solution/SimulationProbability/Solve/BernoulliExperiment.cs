using Sigida.MathModeling.Domain.Extension;
using Sigida.MathModeling.Domain.Interface;
using Sigida.MathModeling.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution
{ 
    internal class BernoulliExperiment : ITask
    {
        private IOperationStep localStep;
        
        //Неизменяемые и инициализируемы в конструкторе
        private readonly double m;
        private readonly double n;
        private readonly double p;
        
        //Вспомогательные
        private double _q;
        private double _k = 3;
        public BernoulliExperiment(double m, double n,double p, IOperationStep logger)
        {
            this.m=m;
            this.n=n;
            this.p = p;
            _q = 1 - p;
            localStep = logger;
         }

        public void Run()
        {
            localStep.Append($"Задание № 1\n");

            var table = SimulationTable();

            OutputTable(table);

            var listRange = GetRange(table);

  

            Random random = new Random(DateTime.UtcNow.Millisecond);

            for (int i = 0; i < m; i++)
            {
                var randomNumber = random.NextDouble(); //* (table.Sum() - 0.1) + 0.1
                foreach (var range in listRange)
                {
                    if (range.IsIncuded((float)randomNumber))
                    {
                        localStep.Append($"{randomNumber} = ({range.Start}:{range.End}) поэтому X = {range.Num};\n");
                        continue;
                    }
                }
            }
        }

        private List<MyRange> GetRange(float[] array)
        {
            var list = new List<MyRange>();

            MyRange currentRange = new(0, 0, array[0]);
            localStep.Append($"New range is 0: (0:{currentRange.End})\n");

            for (int i = 1; i < array.Length ; i++)
            {
                var range = new MyRange(i, currentRange.End, array.Take(i + 1).Sum());
                localStep.Append($"New range is {i}: ({range.Start}:{range.End})\n");
                list.Add(range);
                currentRange = range;
            }

            return list;
        }

        private float[] SimulationTable()
        {
            float[] result = new float[Convert.ToInt16(n + 1)];

            for (int i = 0; i < n + 1; i++)
            {
                //3  это N в формуле C (Бернулли)
                var c = (Operation.Factorial(n)) / ((Operation.Factorial(i)) * Operation.Factorial(n-i));

                result[i] = (float)Math.Round(c * Math.Pow(p, i) * Math.Pow(_q, n-i),9);
                    
                localStep.Append($"p{i} = {c} * ({p})^{i}*({_q})^{n-i} = {result[i]}\n");
            }

            return result;
        }

        private void OutputTable(float[] table)
        {
            localStep.Append("k\t");
            for (int i = 0; i < table.Length; i++)
                localStep.Append($"{i}            ");

            localStep.Append($"\tSum\npk\t");
            for (int i = 0; i < table.Length; i++)
            {
                localStep.Append($"{table[i]}     ");
            }

            localStep.Append($"\t{table.Sum()}\n\n");
        }
    }
}
