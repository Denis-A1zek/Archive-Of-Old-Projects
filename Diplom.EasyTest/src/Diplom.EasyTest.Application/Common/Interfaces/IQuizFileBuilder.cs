using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.App.Common
{
    public interface IQuizFileBuilder
    {
        Task<Quiz> Load(string path);
        void Build(Quiz quiz, string path);
    }
}
