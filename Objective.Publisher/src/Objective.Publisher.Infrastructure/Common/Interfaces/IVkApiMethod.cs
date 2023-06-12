using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Common
{
    public interface IVkApiMethod<T>
    {
        T Get { get; }
    }
}
