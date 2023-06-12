using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Models
{
    internal class MyRange
    {
        public MyRange(int num,float start, float end)
        {
            Num = num;
            Start=start;
            End=end;
        }

        public int Num { get; }
        public float Start { get; }
        public float End { get; }

        public bool IsIncuded(float value)
        {
            return (value >= Start && value <= End);
        }

        public static List<MyRange> CreateRange(int interval, int min, int max)
        {
            List<MyRange> ranges = new();

            for (int i = 0, currentRangeMax = min + interval; currentRangeMax <= max + 8; currentRangeMax += interval, i++)
            {
                MyRange range = new(i, currentRangeMax - interval, currentRangeMax);
                ranges.Add(range);
            }

            return ranges;
        }

        public static Dictionary<MyRange, int> CalcualteFrequence(List<MyRange> ranges, int[] frequense)
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

        public static Dictionary<int, int> GetAvgFreq(Dictionary<MyRange, int> rangeFreq)
        {
            Dictionary<int, int> dictionaryAvg = new();

            foreach (var valuePair in rangeFreq)
            {
                int avgValue = (int)(valuePair.Key.Start + valuePair.Key.End) / 2;
                dictionaryAvg.Add(avgValue, valuePair.Value);
            }

            return dictionaryAvg;
        }
        public override string ToString()
        {
            return $"{Start}:{End}";
        }

    }
}
