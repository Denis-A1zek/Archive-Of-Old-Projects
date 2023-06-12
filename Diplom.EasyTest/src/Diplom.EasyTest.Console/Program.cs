using Diplom.EasyTest.App.Builders;
using Diplom.EasyTest.App.Common;
using Diplom.EasyTest.App;
using Diplom.EasyTest.Infrastructure.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.EasyTest.Core.Models;

namespace Diplom.EasyTest.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //QuizBuilder quizBuilder = new QuizBuilder("Квиз по информатике за 7 класс");

            //quizBuilder.AddQuestion("Вопрос от дудя").AddAnswer("Сколько, ты, зарабатываешь?", false)
            //                                         .AddAnswer("Сколько, ты, зарабатываешь?", true)
            //                                         .AddAnswer("Сколько, ты, зарабатываешь?", false)
            //                                         .AddAnswer("Сколько, ты, зарабатываешь?", false)   
            //                                            .AddScore(5.0f).Build();

            //quizBuilder.AddQuestion("Как ваша жизнь").AddAnswer("Сколько, ты, зарабатываешь?", false)
            //                                         .AddAnswer("Сколько, ты, зарабатываешь?", true)
            //                                         .AddAnswer("Сколько, ты, зарабатываешь?", false)
            //                                         .AddAnswer("Сколько, ты, зарабатываешь?", false)
            //                                         .AddScore(5.0f).Build();

            //var quiz = quizBuilder.Build();

            IQuizFileBuilder builder = new JsonFileBuilder();

            var quiz = builder.Load(@"C:\Users\den1s\Desktop\TestQuizEasyStudent.json").Result;

            System.Console.WriteLine(quiz.Name);
            foreach (var question in quiz.Questions)
            {
                System.Console.WriteLine($"{question.Id}, " +
                    $"{question.Title}, ");
                question.Answers.ForEach(answer => System.Console.WriteLine($"{answer.Id}: {answer.Title}"));
            }

            var quizManager = new QuizManager(quiz);
            quizManager.Start();

            while(quizManager.IsStarted)
            {
    
                System.Console.WriteLine(quizManager.CurrentQuestion.Title);
                System.Console.WriteLine($"Автоматический ответ {quizManager.CurrentQuestion.Answers[1].Title}");
                quizManager.GetAnswerToQuestion(quizManager.CurrentQuestion.Answers[1]);                
            }

            var result = quizManager.End();

            System.Console.WriteLine(result);

        }
    }
}
