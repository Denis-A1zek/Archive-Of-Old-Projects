using Sigida.Timetable.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.Presentation.Model
{
    public class CoupleInfo
    {
        public CoupleInfo(int numCouple, Subject subject, string audience, bool onEven)
        {
            NumCouple=numCouple;
            Subject=subject;
            Audience=audience;
            OnEven=onEven;
        }

        public int NumCouple { get; }
        public Subject Subject { get; } 

        public string Audience { get; }
        public bool OnEven { get; }
    }
}
