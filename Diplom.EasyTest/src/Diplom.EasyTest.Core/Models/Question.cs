using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.Core.Models
{
    public class Question
    {
        public Question() { }
        public Question(int id, string title)
        {
            Id = id;
            Title = title;
            Answers = new List<Answer>(4);
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public List<Answer> Answers { get; set; }
        public float Score { get; set; }

    }
}
