using Diplom.EasyTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.App.Common
{
    public class Quiz
    {
        public Quiz(string name)
        {
            Name = name;
            Questions = new List<Question>();
        }
        public string Name { get; }
        public List<Question> Questions { get; set; }
    }
}
