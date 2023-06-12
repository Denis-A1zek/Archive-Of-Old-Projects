using IntersactionPont.MathLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IntersactionPont.MathLogic
{
    public class StraightLine
    {
        public Line Line { get; private set; }
        public StraightLine(Line line)
        {
            Line = line;
        }

        public Vector2 FindPointY(float x)
        {
            var k = ((Line.Point2.Y) - (Line.Point1.Y)) / ((Line.Point2.X) - (Line.Point1.X));
            var b = (Line.Point2.Y) - ((k) * (Line.Point2.X));

            var y = ((k) * (x)) + (b);

            return new Vector2(x, y);
        }
    }
}
