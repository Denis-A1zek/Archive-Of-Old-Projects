using Diplom.EasyTest.App.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.App.Command
{
    public class StartQuizCommand : IQuizCommand
    {
        private QuizManager _manager;
        public StartQuizCommand(QuizManager manager)
        {
            _manager = manager;
        }

        public void Execute()
        {
            _manager.IsStarted = true;
            _manager.QuizResult = new Common.Models.QuizResult();
            _manager.CurrentQuestion = _manager.Quiz.Questions[0];
        }
        public bool CanExecute()
        {
            return _manager.IsStarted;
        }
    }
}
