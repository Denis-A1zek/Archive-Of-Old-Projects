using Diplom.EasyTest.App.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom.EasyTest.WinForms
{
    public partial class ReportForm : Form
    {
        private readonly QuizResult quizResult;

        public ReportForm(string disription ,QuizResult quizResult)
        {
            InitializeComponent();

            this.quizResult=quizResult;
            this.Text = disription;
            labelName.Text = disription;
            labeldata.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = $"{Math.Round(((quizResult.Time / 1000f) / 60f),2)} минуты";
            textBoxScore.Text = $"{quizResult.Report.Where(
                                r => r.Value.IsCorrect == true).Count()}/{quizResult.Report.Count}";
            textBoxGrade.Text = quizResult.Grade.ToString();
        }
    }
}
