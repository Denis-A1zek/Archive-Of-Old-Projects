using Diplom.EasyTest.App.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.App.Command
{
    internal class EndQuizCommand : IQuizCommand
    {
        private QuizManager _manager;
        public EndQuizCommand(QuizManager manager)
        {
            _manager = manager;
        }
        public void Execute()
        {
            _manager.IsStarted = false;
            _manager.QuizResult = null;
        }

        public bool CanExecute()
        {
            return _manager.IsStarted;
        }

    }
}
