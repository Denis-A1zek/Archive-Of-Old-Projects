using Sigida.MathModeling.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Infrastructure.Output
{
    public class OperationStepToConsole : IOperationStep
    {
        public void Append(string operation)
        {
            Console.Write(operation);
        }
    }
}
