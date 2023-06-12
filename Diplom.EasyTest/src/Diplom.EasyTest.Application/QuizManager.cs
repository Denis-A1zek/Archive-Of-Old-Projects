using Diplom.EasyTest.App.Common;
using Diplom.EasyTest.App.Command;
using Diplom.EasyTest.App.Common.Interfaces;
using Diplom.EasyTest.App.Common.Models;
using Diplom.EasyTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.App
{
    public class QuizManager
    {
        private IQuizCommand quizCommand;

        public QuizManager(Quiz quiz)
        {
            Quiz = quiz;
        }
        internal Quiz Quiz { get; set; }
        protected internal QuizResult QuizResult { get; internal set; }
        public Question CurrentQuestion { get; internal set; }

        public bool IsStarted { get; internal set; }
        public void Start()
        {
            quizCommand = new StartQuizCommand(this);
            quizCommand.Execute();
        }
        public void GetAnswerToQuestion(Answer answer)
        {
            quizCommand = new QuestionAnswerCommand(this, answer);

            if (quizCommand.CanExecute())
            {
                quizCommand.Execute();                
            }
        }


        public QuizResult End()
        {
            var result = QuizResult;

            quizCommand = new EndQuizCommand(this);
            quizCommand.Execute();

            return result;
        }


    }
}
