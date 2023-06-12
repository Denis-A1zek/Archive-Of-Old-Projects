using Diplom.EasyTest.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.App.Builders
{
    public class QuizBuilder
    {
        private Quiz _quiz;
        public QuizBuilder(string name)
        {
            _quiz = new Quiz(name);
        }
        public QuestionBuilder AddQuestion(string title)
        {
            return new QuestionBuilder(title, _quiz);
        }

        public Quiz Build()
        {
            return _quiz;
        }
    }
}
