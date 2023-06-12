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
    public partial class InputTextForm : Form
    {
        public InputTextForm()
        {
            InitializeComponent();
        }
        public string QuizName { get; private set; }
        public bool IsStartedCreateQuiz { get; private set; }

        private void buttonConfirmStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxQuizName.Text))
            {
                MessageBox.Show("Введите название теста");
                return;
            }

            QuizName = textBoxQuizName.Text;
            IsStartedCreateQuiz = true;

            if (IsStartedCreateQuiz)
            {
                var testDisigner = new TestDesigner(QuizName);

                testDisigner.ShowDialog();
            }

            this.Dispose();
            this.Close();
        }

        private void InputTextForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsStartedCreateQuiz=false;
        }
    }
}
