using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution
{
    public class SMO : IDecision
    {
        private float M = 150;
        private float Z = 10;

        private float q14 = 0.27f;
        private float q24 = 0.32f;
        private float q34 = 0.24f;

        private float V1 = 9;
        private float V2 = 11;
        private float V3 = 17;

        private float proc = 0.9f;
        private float S = 0.01f;
        public void Decision(IOperationStep operationStep)
        {
            float V4 = V1 * q14  +  V2* q24 +  V3* q34;
            operationStep.Append($"V4 = {V1 * q14} + {V2 * q24} + {V3*q34} = {V4}\n");

            float x0 = (proc) / (V4 * S);
            operationStep.Append($"x0: {proc} / {V4 * S} = {x0}\n");

            float R = ((M) / (x0)) - Z;
            operationStep.Append($"R: ({M} / {x0}) - {Z} = {R}\n");

            float N = R * x0;
            operationStep.Append($"N: {R} * {x0} = {N}\n");
            
        }
    }
}

