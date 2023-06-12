using Sigida.PollingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.PollingSystem.Application
{
    /// <summary>
    /// Build new poll object 
    /// </summary>
    public class PollBuilder
    {
        private readonly string _questionText;
        private List<PollAnswer> _items = new();
        public PollBuilder(string questionText)
        {
            _questionText = questionText;
        }

        /// <summary>
        /// Fluient add new answer
        /// </summary>
        /// <param name="id">answer id</param>
        /// <param name="title">title</param>
        /// <returns></returns>
        public PollBuilder AddAnswer(Guid id, string title)
        {
            _items.Add(new PollAnswer(id, title));

            return this;
        }
        
        /// <summary>
        /// Return new instance
        /// </summary>
        /// <returns></returns>
        public Poll Build()
        {
            return new Poll(_questionText, _items);
        }

        /// <summary>
        /// Get result for poll
        /// </summary>
        /// <param name="poll"></param>
        /// <returns></returns>
        public PollResults GetResult(Poll poll) => new(poll);
    }
}
