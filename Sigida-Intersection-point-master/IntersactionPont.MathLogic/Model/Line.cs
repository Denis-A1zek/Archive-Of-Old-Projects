using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IntersactionPont.MathLogic.Model
{
    public struct Line
    {
        public Vector2 Point1;
        public Vector2 Point2;

        public Line(Vector2 point1, Vector2 point2)
        {
            Point1=point1;
            Point2=point2;
        }
    }
}
