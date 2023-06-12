using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.PollingSystem.Entities
{
    [DebuggerDisplay("{QuestionText}")]
    public class Poll : Identity
    {

        public Poll(string questionText, List<PollAnswer> answers) : this(questionText)
        {
            QuestionText = questionText;
            Answers = answers;
        }
        private Poll(String questionText)
        {
            QuestionText = questionText;
        }

        public string QuestionText { get; init;  } = null!;
        public List<PollAnswer>? Answers { get; init; }

        public void VoteTo(Guid id, int value = 1)
        {
            var item = Answers?.SingleOrDefault(x => x.Id == id);
            if(item != null)
            {
                item.Votes += value;
            }

            var totalVotes = Answers?.Sum(x => x.Votes) ?? 0;
            Answers?.ForEach(answer => answer.SetPercents(totalVotes));
        }


    }
}
