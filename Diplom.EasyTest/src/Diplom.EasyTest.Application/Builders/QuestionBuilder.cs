using Diplom.EasyTest.App.Common;
using Diplom.EasyTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.App.Builders
{
    public class QuestionBuilder
    {
        private Quiz _quiz;
        private Question _question;

        public QuestionBuilder(string title ,Quiz quiz)
        {
            _quiz=quiz;
            _question = new Question(quiz.Questions.Count, title);
        }

        public QuestionBuilder AddAnswer(string title,bool status)
        {
            _question.Answers.Add(new Answer(_question.Answers.Count, title, status));
            return this;
        }

        public QuestionBuilder AddScore(float score)
        {
            if (_question.Score != 0)
                return this;

            _question.Score = score;
            return this;
        }

        public QuestionBuilder AddImage(string imageByte)
        {
            _question.Image = imageByte;
            return this;
        }
        public void Build()
        {
            _quiz.Questions.Add(_question);
        }
    }
}
