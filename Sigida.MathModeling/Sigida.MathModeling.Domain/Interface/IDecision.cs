using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain
{
    public interface IDecision
    {
        public void Decision(IOperationStep operationStep);
    }
}
