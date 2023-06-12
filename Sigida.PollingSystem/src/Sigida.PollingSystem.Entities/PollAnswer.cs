using Sigida.PollingSystem.Entities;
using System.Diagnostics;

namespace Sigida.PollingSystem.Entities
{

    /// <summary>
    /// Poll answer model
    /// </summary>
    [DebuggerDisplay("{Title} {Votes} {Percents}")]
    public class PollAnswer : Identity
    {
        public PollAnswer(Guid id, string title)
        {
            Id = id;
            Title = title;
        }
        public string Title { get; init; }
        public int Votes { get; set; }
        public double Percents { get; set; }

        /// <summary>
        /// Calculate precents
        /// </summary>
        /// <param name="totalVotes"></param>
        public void SetPercents(int totalVotes)
        {
            if(totalVotes > 0)
            {
                Percents = Votes * 100d / (totalVotes);
            }
        }

        public override string ToString()
        {
            return $"* {Title} ({Votes}) {Percents:F}%";
        }
    }
}
