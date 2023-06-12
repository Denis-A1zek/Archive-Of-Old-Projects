using Sigida.MathModeling.Domain.Interface;
using Sigida.MathModeling.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution
{
    public class StatisticalProcessing : ITask
    {
        private int[] plus = new int[] { 0, 3, 15, 22, 41, 47, 47, 58, 64, 86, 88, 89 };
        private int[] minus = new int[] { 14, 17, 19, 28, 36, 39, 53, 70, 82, 85, 87, 91 };
        private int[] values;
        private int k;
        private readonly IOperationStep logger;

        public StatisticalProcessing(int k, IOperationStep logger)
        {
            this.k = k;
            this.logger=logger;
            values = new int[] { 180, 188, 206, 190, 197, 167, 198, 194, 210, 176,
                                 190, 182, 160, 202, 189, 181, 200, 211, 188, 207,
                                 176, 186, 204, 170, 225, 190, 180, 212, 200, 191,
                                 174, 187, 184, 200, 190, 222, 210, 192, 183, 223,
                                 197, 190, 178, 207, 203, 174, 190, 179, 208, 187,
                                 173, 193, 199, 211, 194, 207, 179, 187, 171, 201,
                                 177, 180, 188, 198, 210, 190, 164, 182, 200, 191,
                                 17 , 195, 190, 166, 205, 185, 217, 180, 220, 191,
                                 192, 178, 208, 199, 155, 191, 180, 196, 172, 187,
                                 194, 12 , 211, 190, 201, 182, 220, 161, 188, 215 };

        }

        public void Run()
        {
            AddValueTo(ref values);
            OutPutTable(values);
            var h = CalculateInterval();
            var listRanges = MyRange.CreateRange(h, values.Min(), values.Max());

            var frequences = MyRange.CalcualteFrequence(listRanges, values);

            foreach (var item in frequences)
            {
                logger.Append($"\n{item}");
            }

            var listFrequnces = frequences.Values.ToList();

            var modeMaxRange = frequences.FirstOrDefault(x => x.Value == frequences.Values.Max()).Key;

            var mO = CalculateMode(h, listFrequnces.Max(),
                listFrequnces[listFrequnces.IndexOf(listFrequnces.Max()) - 1],
                listFrequnces[listFrequnces.IndexOf(listFrequnces.Max()) + 1],
                (int)modeMaxRange.Start);

            var dicProp = GetPropabilities(frequences);

            var dicF = GetF(dicProp);

            foreach (var item in dicF)
            {
                logger.Append($"\n{item}");
            }

            var median = CalculateMedian((int)modeMaxRange.Start, h, dicF[modeMaxRange], dicF.First(x => x.Key.End == modeMaxRange.Start).Value);

            var avgRange = MyRange.GetAvgFreq(frequences);

            foreach (var item in avgRange)
            {
                logger.Append($"\n{item}");
            }

            var expectedValue = ExpectedValue(avgRange);
            var dispersion = Dispersion(expectedValue, avgRange);
            var o = AverageDeviation(dispersion);
            var s = CalculateS(dispersion);


        }

        private double CalculateS(double dispersion)
        {
            var n = 100;
            var s = Math.Sqrt((n / (n-1)) * dispersion);

            logger.Append($"\n s = √({n}/{n-1}) * {dispersion} = {s}");

            return s;
        }

        private double ExpectedValue(Dictionary<int, int> avgTable)
        {
            double sum = 0;
            logger.Append($"\nОценка математического ожидания:");
            logger.Append($"\n~x = ");
            foreach (var value in avgTable)
            {
                sum += value.Key * ((double)value.Value);
                logger.Append($"{value.Key} * {(double)value.Value} +");
            }
            logger.Append($") = {sum} / 100 = {sum / (100d)}\n");

            return sum / 100d;
        }

        private double Dispersion(double expectedValue, Dictionary<int, int> avgTable)
        {
            double sum = 0;
            logger.Append($"\nОценка дисперсии:");
            logger.Append($"\n~D = ");
            foreach (var value in avgTable)
            {
                sum += Math.Pow(value.Key - expectedValue, 2) * ((double)value.Value);
                logger.Append($"({value.Key - expectedValue})^2 * {value.Value} +");
            }
            logger.Append($") = {sum} / 100 ={sum / (100d)}\n");

            return sum / 100d;
        }

        private double AverageDeviation(double Dispersion)
        {
            logger.Append($"Оценка среднего квадратического отклонения:");
            logger.Append($"o = SQRT {Dispersion} =  {Math.Sqrt(Dispersion)}");

            return Math.Sqrt(Dispersion);
        }

        private double CalculateMedian(int x, int h, double maxM, double maxMoMinus1)
        {
            var numerator = (0.5 - maxMoMinus1);
            var denominator = (maxM - maxMoMinus1);
            var fraction = numerator / (denominator);

            var median = x + fraction * h;

            logger.Append($"\n\nMe* = {x} + (0.5 - {maxMoMinus1} / {maxM} - {maxMoMinus1}) * {h} = {median}");

            return median;
        }

        private double[] GetF(double[] propabilities)
        {
            double previosValue = 0;
            double[] valuesF = new double[propabilities.Length];

            for (int i = 0; i < propabilities.Length; i++)
            {
                
                double newValue = (double)previosValue + propabilities[i];
                valuesF[i] = newValue;
                previosValue = newValue;
            }

            return valuesF;
        }  

        private Dictionary<MyRange, double> GetF(Dictionary<MyRange, double> dicProp)
        {
            Dictionary<MyRange, double> dic = new Dictionary<MyRange, double>();

            double previosValue = 0;

            foreach (var item in dicProp)
            {
                double newValue = (double)previosValue + item.Value;
                dic[item.Key] = newValue;
                previosValue = newValue;
            }

            return dic;
        }

        private Dictionary<MyRange, double> GetPropabilities(Dictionary<MyRange, int> frequ)
        {
            Dictionary<MyRange, double> prop = new Dictionary<MyRange, double>();

            var sum = frequ.Values.Sum();

            foreach (var keyValuePair in frequ)
            {
                prop.Add(keyValuePair.Key, (double)keyValuePair.Value / (sum));
            }

            return prop;

        }

        private double CalculateMode(int h, int nMo, int nMoMinus1, int nMoPlus1, int x)
        {
            var numerator = (double)nMo - nMoMinus1;
            var denominator = (double)(2 * nMo) - nMoMinus1 - nMoPlus1;
            var fraction = (double)numerator / (denominator);

            var mo = x + (fraction * h);

            logger.Append($"\n\nm = {x} + ({nMo} - {nMoMinus1} / 2*{nMo} - {nMoMinus1} - {nMoPlus1}) * {h} = {mo}");

            return mo;
        }

        private int CalculateInterval()
        {
            var h = (values.Max() - values.Min()) / (8);
            logger.Append($"\n\n\th = {values.Max()} - {values.Min()} / 8 = {h}\n");
            return h;
        }

        private void AddValueTo(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(plus.Contains(i))
                {
                    array[i] += k;
                    continue;
                }
                else if(minus.Contains(i))
                {
                    array[i] -= k;
                    continue;
                }
            }
        }

        private void OutPutTable(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (i % 10 == 0)
                    logger.Append("\n");
                logger.Append($"{values[i]}\t");                    
            }
        }
    }
}
