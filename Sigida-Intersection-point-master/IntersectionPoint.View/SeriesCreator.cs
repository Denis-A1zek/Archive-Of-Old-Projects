using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;

namespace IntersectionPoint.View
{
    internal class SeriesCreator
    {
        public static Series CreateLine(string name,Vector2 vector1, Vector2 vector2)
        {
            var series = new Series()
            {
                Name = name,
                XValueType = ChartValueType.Double,
                YValueType = ChartValueType.Double,   
                ChartType = SeriesChartType.Line              
            };

            var point1 = new DataPoint(vector1.X, vector1.Y)
            {
                Label = $"{name}: [{vector1.X}:{vector1.Y}]",
                LabelForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Noto Sans", 10)
            };


            var point2 = new DataPoint(vector2.X, vector2.Y)
            {
                Label = $"{name}: [{vector2.X}:{vector2.Y}]",
                LabelForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Noto Sans", 10)
            };

            series.Points.Add(point1);
            series.Points.Add(point2);

            return series;
        }

        public static Series CreateDot(Vector2 vector)
        {
            var series = new Series()
            {
                XValueType = ChartValueType.Double,
                YValueType = ChartValueType.Double,
                ChartType = SeriesChartType.Point,
                ToolTip = $"Cross {vector.X}:{vector.Y}"
            };


            var point1 = new DataPoint(vector.X, vector.Y)
            {
                Label = $"Cross: [{vector.X}:{vector.Y}]",
                LabelForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Noto Sans", 10)
            };

            series.Points.Add(point1);

            return series;
        }
    }
}
