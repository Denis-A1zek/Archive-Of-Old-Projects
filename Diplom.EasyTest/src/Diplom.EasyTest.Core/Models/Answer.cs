using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.Core.Models
{
    public class Answer
    {    
        public Answer(int id, string title, bool isCorrect)
        {
            Id=id;
            Title=title;
            IsCorrect=isCorrect;
        }

        public int Id { get; }
        public string Title { get; }
        public bool IsCorrect { get; }
    }
}
