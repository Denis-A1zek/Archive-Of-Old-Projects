using Sigida.PollingSystem.Entities;
using System.Text;

namespace Sigida.PollingSystem.Application
{
    /// <summary>
    /// Results of poll
    /// </summary>
    public class PollResults
    {
        private readonly Poll _poll;

        public PollResults(Poll poll)
        {
            _poll=poll;
        }

        /// <summary>
        /// Get prety view to presentation
        /// </summary>
        /// <returns></returns>
        public string GetView()
        {
            var stringBuilder = new StringBuilder(_poll.QuestionText);
            stringBuilder.AppendLine("-".PadLeft(50));

            if (_poll.Answers != null && _poll.Answers.Any())
            {
                _poll.Answers.ForEach(x => stringBuilder.AppendLine(x.ToString()));
            }

            return stringBuilder.ToString();
        }
    }
}