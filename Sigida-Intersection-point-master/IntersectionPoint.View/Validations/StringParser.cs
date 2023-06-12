using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionPoint.View.StringParser
{
    public static class StringParser
    {
        public static float Parse(string value, float caseOfErrorReturn = 0)
        {
            if(float.TryParse(value, out var result))
                return result;
            return caseOfErrorReturn;
        }
    }
}
