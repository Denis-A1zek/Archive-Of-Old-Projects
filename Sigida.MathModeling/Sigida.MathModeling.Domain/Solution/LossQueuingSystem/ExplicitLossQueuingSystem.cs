using Sigida.MathModeling.Domain.Interface;
using Sigida.MathModeling.Domain.Solution.LossQueuingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution
{
    public class ExplicitLossQueuingSystem : IDecision
    {
        private double _gamma = 5.5;
        private double N = 6;
        private double a = 2;

        private IOperationStep localStep;

        public ExplicitLossQueuingSystem(double gamma, double N, double a)
        {
            _gamma = gamma;
            this.N = N;
            this.a = a;
        }

        public void Decision(IOperationStep operationStep)
        {
            localStep = operationStep;

            ISubtask subtask1 = new QualityTheSimplestCallFlow(_gamma, localStep);
            subtask1.Calculate();
            subtask1.CreateReport();

            ISubtask subtask2 = new PrimitiveCallFlow(N, a, localStep);
            subtask2.Calculate();
            subtask2.CreateReport();

            //TO-DO  2) Определим числовые характеристики качества обслуживания вызовов:
        }
     

    }
}
