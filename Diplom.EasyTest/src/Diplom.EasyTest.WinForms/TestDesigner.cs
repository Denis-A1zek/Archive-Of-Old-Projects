using Diplom.EasyTest.App.Builders;
using Diplom.EasyTest.App.Common;
using Diplom.EasyTest.Infrastructure.File;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom.EasyTest.WinForms
{
    public partial class TestDesigner : Form
    {
        private bool _questionNameIsValid => string.IsNullOrWhiteSpace(textQuestionName.Text);
        private QuizBuilder _quizBuilder;

        private string image;

        TextBox[] textBoxes;
        CheckBox[] checkBoxes;

        private int _questionCount = 0;

        public TestDesigner(string title)
        {
            InitializeComponent();
            _quizBuilder = new QuizBuilder(title);
            _questionCount = 0;

            textBoxes = new TextBox[] { textAnswer1, textAnswer2, textAnswer3, textAnswer4 };
            checkBoxes = new CheckBox[] { stateAnswer1, stateAnswer2, stateAnswer3, stateAnswer4 };

            AddNewQuestionHandler += CleanAllTextBox;
            AddNewQuestionHandler += ToolStripUpdate;
        }

        public event Action AddNewQuestionHandler;



        private bool AnswerTextBoxIsNotNull()
        {

            foreach (var box in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                    return false;
            }

            var selectedBoxes = checkBoxes.Select(box => box.Checked == true);

            if (selectedBoxes.Count() == 0)
                return false;

            return true;
        }
       
        private void CleanAllTextBox()
        {
            foreach (var checkBox in checkBoxes)
            {
                checkBox.Checked = false;
            }

            foreach (var textBox in textBoxes)
            {
                textBox.Text = "";
            }

            textBoxScore.Text = "";
            textQuestionName.Text = "";
            image = null;
            pictureBox1.Image = null;
        }

        private void ToolStripUpdate()
        {
            toolStripLabel.Text = $"Вопросов в тесте: {_questionCount}";
        }
        
        private void textBoxScore_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxScore.Text, out int score) && score != 0)
            {
                textBoxScore.Text = score.ToString();
            }
            else
            {
                textBoxScore.Text = "";
            }
        }
        
        #region Button Logic
        private void buttonAddNewQuestion_Click(object sender, EventArgs e)
        {
            var answerValidation = AnswerTextBoxIsNotNull();
           
            if (!_questionNameIsValid && answerValidation)
            {
                _quizBuilder
                    .AddQuestion(textQuestionName.Text)
                        .AddAnswer(textAnswer1.Text, stateAnswer1.Checked)
                        .AddAnswer(textAnswer2.Text, stateAnswer2.Checked)
                        .AddAnswer(textAnswer3.Text, stateAnswer3.Checked)
                        .AddAnswer(textAnswer4.Text, stateAnswer4.Checked)
                    .AddScore(int.Parse(textBoxScore.Text)).AddImage(image == null ? null: image).Build();
                _questionCount++;

                AddNewQuestionHandler.Invoke();
            }
            else
                MessageBox.Show("Вы ввели не все свойства вопроса, пожалуйста повторите попытку");
        }
        private void buttonCreateQuiz_Click(object sender, EventArgs e)
        {
            if (_questionCount == 0)
            {
                MessageBox.Show("Error zero questions problem","Ошибка 0 вопросов в тесте", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON (*.json)|*.json";

            IQuizFileBuilder quizFileBuilder = new JsonFileBuilder();
            var quiz = _quizBuilder.Build();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                quizFileBuilder.Build(quiz, saveFileDialog.FileName);

        }
        private void buttonCleanQuestion_Click(object sender, EventArgs e)
        {
            CleanAllTextBox();
        }
        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog();

                dialog.Title  = "Open Image";
                dialog.Filter = "Image Files(*.bmp; *.jpg; *.jpeg,*.png)|*.BMP; *.JPG; *.JPEG; *.PNG";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    image = ImageViewModel.GetBase64StringImage(dialog.FileName);
                    pictureBox1.Image = new Bitmap(dialog.FileName);
                }

                dialog.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Название файла или файл не соответствуют норме");
            }
            
        }
        #endregion

        #region Form Logic
        private void TestDesigner_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddNewQuestionHandler -= CleanAllTextBox;
            AddNewQuestionHandler -= ToolStripUpdate;
        }

        #endregion

        
    }
}
