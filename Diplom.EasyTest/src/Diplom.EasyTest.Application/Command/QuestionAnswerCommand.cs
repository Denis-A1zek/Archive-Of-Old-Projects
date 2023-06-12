using Diplom.EasyTest.App.Common.Interfaces;
using Diplom.EasyTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.App.Command
{
    public class QuestionAnswerCommand : IQuizCommand
    {
        private readonly QuizManager _quizManager;
        private Answer answer;
        public QuestionAnswerCommand(QuizManager quizManager, Answer answer)
        {
            _quizManager=quizManager;
            this.answer=answer;
        }

        public void Execute()
        {
            var currentQuestion = _quizManager.CurrentQuestion;
            var answerIsContains = currentQuestion.Answers.Contains(answer);
            if(answerIsContains)
            {
                _quizManager.QuizResult.Report.Add(currentQuestion, answer);
            }
            if (currentQuestion.Id != _quizManager.Quiz.Questions.Last().Id)
                _quizManager.CurrentQuestion = 
                        _quizManager.Quiz.Questions[_quizManager.CurrentQuestion.Id + 1];
            else
                _quizManager.IsStarted = false;
        }
        public bool CanExecute()
        {
            return _quizManager.Quiz.Questions.Last().Id + 1 != _quizManager.CurrentQuestion.Id;
        }
    }
}
