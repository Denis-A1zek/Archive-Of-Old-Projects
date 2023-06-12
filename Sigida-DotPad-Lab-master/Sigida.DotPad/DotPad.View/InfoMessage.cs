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
    public partial class InfoMessage : Form
    {    
        public InfoMessage()
        {
            InitializeComponent();
        }
        public static void Show(int charact, int spaces)
        {
            InfoMessage msg = new InfoMessage();
            msg.label2.Text = $"Chars: {charact}";
            msg.label3.Text = $"Spaces: {spaces}";
            msg.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
