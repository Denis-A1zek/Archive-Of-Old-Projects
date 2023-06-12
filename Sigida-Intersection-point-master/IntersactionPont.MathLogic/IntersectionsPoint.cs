using IntersactionPont.MathLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IntersactionPont.MathLogic
{
    public class IntersectionsPoint
    {
        private Line _firstLine;
        private Line _secondLine;

        public IntersectionsPoint(Line firstLine, Line secondLine)
        {
            _firstLine = firstLine;
            _secondLine = secondLine;
        }

        public Conclusion Find()
        {

            var coefFirstLine = GetCoefficent(_firstLine);
            var coefSecondLine = GetCoefficent(_secondLine);

            if (IsParallel(coefFirstLine, coefSecondLine))
                return new Conclusion(new Vector2(0,0), "Прямые параллельны", false);

            var crossPoint = Cross(coefFirstLine, coefSecondLine);

            if (IsPerpendicular(coefFirstLine, coefSecondLine))
                return new Conclusion(crossPoint, "Прямые перпендикулярны", true);

            return new Conclusion(crossPoint, "Прямые пересекаются", true);

        }

        private Vector2 Cross(Coefficent c1, Coefficent c2)
        {
            Vector2 point = new Vector2();

            point.X = (float)((c1.B * c2.C - c2.B * c1.C) / (c1.A * c2.B - c2.A * c1.B));
            point.Y = (float)((c2.A * c1.C - c1.A * c2.C) / (c1.A * c2.B - c2.A * c1.B));

            return point;

        }

        private Coefficent GetCoefficent(Line line)
        {
            var coef = new Coefficent();
            coef.A = line.Point2.Y - line.Point1.Y;
            coef.B = line.Point1.X - line.Point2.X;
            coef.C = (-line.Point1.X) * line.Point2.Y + line.Point1.Y * line.Point2.X ;

            return coef;
        }

        private bool IsParallel(Coefficent c1, Coefficent c2)
        {
            return (c1.A * c2.B - c2.A * c1.B) == 0;
        }
        private bool IsPerpendicular(Coefficent c1, Coefficent c2)
        {
            return (c1.A * c2.A + c1.B * c2.B) == 0;
        }
        
        private struct Coefficent
        {
            public double A;
            public double B;
            public double C;
        }
    }

    public class Conclusion
    {
        public Conclusion(Vector2 result, string message, bool isSucccessfuly)
        {
            Result = result;
            Message = message;
            IsSuccessfully = isSucccessfuly;
        }

        public Vector2 Result { get; internal set; }
        public string Message { get; internal set; }
        public bool IsSuccessfully { get; internal set; }


    }

}
