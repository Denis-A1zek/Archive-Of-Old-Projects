using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Interface
{
    internal interface ISubtask
    {
        public void Calculate();
        public void CreateReport();
    }
}
