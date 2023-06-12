using Diplom.EasyTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.App.Common.Models
{
    public class QuizResult
    {
        public QuizResult()
        {
            Report = new Dictionary<Question, Answer>();
        }
        public Dictionary<Question, Answer> Report { get; set; }
        
        public float TotalScore => Report.Select(x=> x.Key.Score).Sum();

        private float _pointsScored;
        public float PointsScored
        {
            get
            {
                if (Report.Count == 0)
                    return 0;
                else
                {
                    _pointsScored = 0;
                    foreach (var report in Report)
                    {
                        if (report.Value.IsCorrect == true)
                        {
                            _pointsScored += report.Key.Score;
                        }
                    }
                    return _pointsScored;
                }
            }
        }

        public int Grade
        {
            get
            {
                var grade = (PointsScored/TotalScore) * 100f;

                if (grade >= 50f && grade < 72)
                    return 3;
                else if (grade >= 75f && grade < 91)
                    return 4;
                else if (grade >= 95f)
                    return 5;
                else
                    return 2;
            }
        }

        public long Time { get; set; }
        
    }
}
