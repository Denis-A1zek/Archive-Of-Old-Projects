using Sigida.MathModeling.Domain.Interface;
using Sigida.MathModeling.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution
{
    internal class SingleEventSolve : ITask
    {
        private double _m;
        private float[] _p;

        private IOperationStep operationStep;
        public SingleEventSolve(double m, float[] p, IOperationStep operationStep)
        {
            _m=m;
            _p=p;
            this.operationStep=operationStep;
        }

        public void Run()
        {
            operationStep.Append($"\nЗадание № 2");

            operationStep.Append($"\nk\t0\t1\t2\t3\tSum\n");
            operationStep.Append($"pk\t{_p[0]}\t{_p[1]}\t{_p[2]}\t{_p[3]}\t{_p.Sum()}\n\n");

            var ranges = GetRange(_p);

            for (int i = 1; i < 5; i++)
            {
                var randomNumber = new Random().NextDouble(); //* (table.Sum() - 0.1) + 0.1
                foreach (var range in ranges)
                {
                    if (range.IsIncuded((float)randomNumber))
                    {
                        operationStep.Append($"{randomNumber} = ({range.Start}:{range.End}) поэтому X = {range.Num}. Следовательно, произошло событие А{range.Num}\n");
                        continue;
                    }
                }
            }
        }

        private List<MyRange> GetRange(float[] array)
        {

            MyRange range1 = new(1, 0, array[0]);
            operationStep.Append($"New range is (0:{range1.End})\n");

            MyRange range2 = new(2, range1.End, array[0] + array[1]);
            operationStep.Append($"New range is ({range2.Start}:{range2.End})\n");

            MyRange range3 = new(3, range2.End, array[0] + array[1] + array[2]);
            operationStep.Append($"New range is ({range3.Start}:{range3.End})\n");

            MyRange range4 = new(4, range3.End, array.Sum());
            operationStep.Append($"New range is ({range4.Start}:{array.Sum()})\n");

            return new List<MyRange>
            {
                range1, range2, range3, range4
            };
        }

    }
}
