using Diplom.EasyTest.App;
using Diplom.EasyTest.App.Common;
using Diplom.EasyTest.Core.Models;
using Diplom.EasyTest.Infrastructure.File;
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
    public partial class MainForm : Form
    {
        private Quiz quiz;

        private List<CheckBox> checkBoxes;
        private QuizManager quizManager;

        private string testerName;

        private event Action AnswerIsRegister;

        private System.Diagnostics.Stopwatch timer;

        public MainForm()
        {
            InitializeComponent();
            checkBoxes = new List<CheckBox>()
            {
                checkBoxAnswer1,
                checkBoxAnswer2,
                checkBoxAnswer3,
                checkBoxAnswer4
            };            
        }

        private void createNewQuiz_Click(object sender, EventArgs e)
        {
            var inputForm = new InputTextForm();
            inputForm.ShowDialog();            
        }

        private async void uploadQuiz_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog();

                dialog.Title  = "Open Image";
                dialog.Filter = "JSON files(*.json)|*.JSON;";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    IQuizFileBuilder builder = new JsonFileBuilder();
                    quiz = await builder.Load(dialog.FileName);
                }

                dialog.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить файл");
            }
        }

        #region Check checkbox status
        private void checkBoxAnswer1_Click(object sender, EventArgs e)
        {
            var falseBox = checkBoxes.Where((x) => !(x.Equals((CheckBox)sender)));

            foreach (var item in falseBox)
            {
                item.Checked = false;
            }
        }
        #endregion

        private void buttonSetAnswer_Click(object sender, EventArgs e)
        {
            if (checkBoxes.Where(ch => ch.Checked).Count() == 0)
                return;

            var trueBox = checkBoxes.Where(ch => ch.Checked);
            var answer = (Answer)trueBox.First().Tag;

            quizManager.GetAnswerToQuestion(answer);

            AnswerIsRegister.Invoke();
        }

        private void buttonStartQuiz_Click(object sender, EventArgs e)
        {
            if(quiz is null)
            {
                MessageBox.Show("Для старта теста необходимо загрузить тест");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxTesterName.Text))
                return;

            quizManager = new QuizManager(quiz);
            quizManager.Start();
            timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            UpdateTextBoxes();

            AnswerIsRegister += UpdateTextBoxes;
        
            testerName = textBoxTesterName.Text;

            panelMainMenu.Enabled = false;
            panelMainMenu.Visible = false; 
        }

        private void UpdateTextBoxes()
        {
            if (quizManager.IsStarted == false)
            {
                QuizEnd();
                return;
            }

            textBoxQuestion.Text = quizManager.CurrentQuestion.Title;

            checkBoxAnswer1.Text = quizManager.CurrentQuestion.Answers[0].Title;
            checkBoxAnswer2.Text = quizManager.CurrentQuestion.Answers[1].Title;
            checkBoxAnswer3.Text = quizManager.CurrentQuestion.Answers[2].Title;
            checkBoxAnswer4.Text = quizManager.CurrentQuestion.Answers[3].Title;

            checkBoxAnswer1.Tag = quizManager.CurrentQuestion.Answers[0];
            checkBoxAnswer2.Tag = quizManager.CurrentQuestion.Answers[1];
            checkBoxAnswer3.Tag = quizManager.CurrentQuestion.Answers[2];
            checkBoxAnswer4.Tag = quizManager.CurrentQuestion.Answers[3];
            pictureBox.Image = null;
            checkBoxes.ForEach(ch => ch.Checked = false);

            var image = quizManager.CurrentQuestion.Image;
            if (image != null)
            {
                pictureBox.Image = ImageViewModel.GetImageFromBase64String(quizManager.CurrentQuestion.Image);
            }
            else
            {
                pictureBox.Image = Properties.Resources.Screenshot_2022_05_24_151847;
            }           
        }

        private void QuizEnd()
        {
            var report =  quizManager.End();
            timer.Stop();
            report.Time = timer.ElapsedMilliseconds;
            timer = null;
            var reportForm = new ReportForm(testerName, report);
            reportForm.Show();

            Dispose();
        }

        private void Dispose()
        {
            textBoxQuestion.Text = "";
            checkBoxes.ForEach(ch => ch.Text = "");
            checkBoxes.ForEach(ch => ch.Tag = null);

            quiz = null;
            quizManager = null;

            AnswerIsRegister -= UpdateTextBoxes;

            textBoxTesterName.Text = "";
            testerName = "";

            panelMainMenu.Enabled = true;
            panelMainMenu.Visible = true;
        }
    }
}
