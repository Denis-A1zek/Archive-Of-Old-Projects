using Diplom.EasyTest.App.Common;
using Diplom.EasyTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.App.Common.Interfaces
{
    internal interface IQuizCommand
    {
        void Execute();
        bool CanExecute();
    }
}
