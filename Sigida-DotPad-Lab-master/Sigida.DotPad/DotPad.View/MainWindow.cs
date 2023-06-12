using DotPad.View.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotPad.View
{
    public partial class MainWindow : Form
    {
        private Notepad _notepad;
        public MainWindow()
        {
            InitializeComponent();
            _notepad = new Notepad();

            _notepad.CharactersCountChanged += StatusBarTextChanger;
        }

        /// <summary>
        /// Изменяет текст statusBar
        /// </summary>
        private void StatusBarTextChanger()
        { 
            statusBar.Items[1].Text = $"Ln {_notepad.CurentLine}, Col {_notepad.CurentColumn}";         
        }
        /// <summary>
        /// Вызывает окно информации о тексте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statusBarItemExtension_Click(object sender, EventArgs e)
        {
            InfoMessage.Show(_notepad.Characters, _notepad.Spaces);
        }

        /// <summary>
        /// При изменении текста записывает новые данные в модель 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxRealm_TextChanged(object sender, EventArgs e)
        {
            var text = (TextBox)sender;

            _notepad.Spaces = text.Text.Split(' ').Length - 1;
            _notepad.CurentLine = text.Lines.Length;
            if (text.Lines.Length != 0)
            {
                _notepad.CurentColumn = text.Lines[_notepad.CurentLine - 1].Length;
            }
            _notepad.Characters = text.Text.Replace(" ", "").Length;
        }
    }
}
