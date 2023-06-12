using Sigida.MathModeling.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Application
{
    public class LabaratoryWork
    {
        private IOperationStep logger;
        private IDecision methodCalculation;

        public LabaratoryWork(IOperationStep logger, IDecision methodCalculation)
        {
            this.logger=logger;
            this.methodCalculation=methodCalculation;
        }

        public void Run()
        {
            methodCalculation.Decision(logger);
        }
    }
}
