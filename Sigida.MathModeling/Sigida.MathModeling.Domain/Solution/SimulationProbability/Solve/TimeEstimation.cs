using Sigida.MathModeling.Domain.Interface;
using Sigida.MathModeling.Domain.Models;
using Sigida.MathModeling.Domain.Solution.LossQueuingSystem.Exstensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution
{
    internal class TimeEstimation : ITask
    {
        private readonly IOperationStep operationStep;
        private int[,] frequense;

        public TimeEstimation(int variant, IOperationStep operationStep)
        {
            frequense = new int[,]
            {
                { 180+variant, 188, 206, 190+variant,197,167, 198, 194, 210, 176 },
                { 190, 182, 160, 202, 189-variant,181+variant,200, 211-variant,188, 207-variant },
                {176, 186, 204+variant,170, 225, 190, 180, 212, 200-variant,191 },
                {174, 187, 184, 200, 190, 222, 210-variant,   192, 183, 223-variant },
                {197, 190+variant,   178, 207, 203, 174, 190, 179+variant,208, 187 },
                {173, 193, 199, 211-variant, 194, 207, 179, 187, 171+variant, 201 },
                {177, 180, 188, 198, 210+variant,190, 164, 182, 200, 191 },
                {171-variant,   195, 190, 166, 205, 185, 217, 180, 220, 191 },
                {192, 178, 208-variant,   199, 155, 191-variant, 180+variant,196-variant,172+variant,187+variant },
                { 194, 192-variant,211, 190, 201, 182, 220, 161,188, 215 }

            };
            this.operationStep=operationStep;
        }

        public void Run()
        {
            operationStep.Append($"\n\nЗадание № 6\nГистограмма частот\n");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    operationStep.Append($"{frequense[i, j]}\t");
                }
                operationStep.Append("\n");
            }

            var h = FingLengthFreq();
            var min_max = FindMaxAndMin(frequense);

            operationStep.Append($"\n Min: {min_max.min} Max: {min_max.max}");

            var ranges = CreateRange((int)h, min_max.min, min_max.max);

            operationStep.Append("\n");

            var freq = CalcualteFrequence(ranges);
            foreach (var item in freq)
            {
                operationStep.Append($"\n{item.Key.Start} : {item.Key.End} - {item.Value}");
            }

            operationStep.Append("\n");

            var avg = GetAvgFreq(freq);

            foreach (var item in avg)
            {
                operationStep.Append($"\n{item.Key} - {item.Value}");
            }


            var x = ExpectedValue(avg);
            var d = Dispersion(x, avg);

            operationStep.Append($"Оценка среднего квадратического отклонения:");
            operationStep.Append($"o = SQRT {d} =  {Math.Sqrt(d)}");

        }


        private double FingLengthFreq()
        {

            var min_max = FindMaxAndMin(frequense);
            var h =Math.Ceiling(((double)min_max.max - (double)min_max.min) / ((double)8));
            operationStep.Append($@"
                          {min_max.max} - {min_max.min}   {min_max.max - min_max.min}
                        h= --------- = -- = {h}
                              8        8
            ");
            return h;
        }

        private (int min, int max) FindMaxAndMin(int[,] array)
        {
            var list = new List<int>();
            foreach (var item in array)
            {
                list.Add(item);
            }

            return (list.Min(),list.Max());

        }

        private List<MyRange> CreateRange(int interval, int min, int max)
        {
            List<MyRange> ranges = new();

            //int currentMaxRange = min + interval;
            //MyRange currentRange = new(0, min, currentMaxRange);
            //ranges.Add(currentRange);

            for (int i = 0, currentRangeMax = min + interval; currentRangeMax <= max + 8; currentRangeMax += interval, i++)
            {
                MyRange range = new(i, currentRangeMax - interval, currentRangeMax);
                operationStep.Append($"\nAdd new interval: [{range.Start} : {range.End}]");
                ranges.Add(range);
            }

            return ranges;
        }

        private Dictionary<MyRange, int> CalcualteFrequence(List<MyRange> ranges)
        {
            Dictionary<MyRange, int> rangeFrequPair = new();

            
            var list = new List<int>();
            foreach (var item in frequense)
                list.Add(item);
            list.Sort();


            foreach (var range in ranges)
            {
                var values = list.Where((value) => range.IsIncuded(value));
                rangeFrequPair.Add(range, values.Count());

            }

            return rangeFrequPair;
        }

        private Dictionary<int, int> GetAvgFreq(Dictionary<MyRange,int> rangeFreq)
        {
            Dictionary<int, int> dictionaryAvg = new();

            foreach (var valuePair in rangeFreq)
            {
                int avgValue = (int)(valuePair.Key.Start + valuePair.Key.End) / 2;
                dictionaryAvg.Add(avgValue, valuePair.Value);
            }

            return dictionaryAvg;
        }

        private double ExpectedValue(Dictionary<int, int> avgTable)
        {
            double sum = 0;
            operationStep.Append($"\nОценка математического ожидания:");
            operationStep.Append($"\n~x = ");
            foreach (var value in avgTable)
            {
                sum += value.Key * ((double)value.Value );
                operationStep.Append($"{value.Key} * {(double)value.Value} +");
            }
            operationStep.Append($") = {sum} / 100 = {sum / (100d)}\n");

            return sum / 100d;
        }

        private double Dispersion(double expectedValue,Dictionary<int, int> avgTable)
        {
            double sum = 0;
            operationStep.Append($"\nОценка дисперсии:");
            operationStep.Append($"\n~D = ");
            foreach (var value in avgTable)
            {
                sum += Math.Pow(value.Key - expectedValue ,2) * ((double)value.Value ) ;
                operationStep.Append($"({value.Key} - {expectedValue})^2 * {value.Value} +");
            }
            operationStep.Append($") = {sum} / 100 ={sum / (100d)}\n");

            return sum / 100d; 
        }

    }
}
