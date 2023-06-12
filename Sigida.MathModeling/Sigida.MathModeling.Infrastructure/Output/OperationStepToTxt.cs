using Sigida.MathModeling.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Infrastructure.Output
{
    public class OperationStepToTxt : IOperationStep
    {
        private string _path;
        public OperationStepToTxt(string path)
        {
            _path = path;
        }
        public async void Append(string operation)
        {
            using (var writer = new StreamWriter(_path, true))
            {
                await writer.WriteAsync(operation);
            }
        }
    }
}
