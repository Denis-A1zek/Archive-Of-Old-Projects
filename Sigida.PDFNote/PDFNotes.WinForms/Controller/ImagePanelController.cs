using PDFNotes.Core.PDF;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFNotes.WinForms.Controller
{
    internal class ImagePanelController
    {
        FlowLayoutPanel _panel;
        public int Count { get; set; }
        public ImagePanelController(FlowLayoutPanel panel)
        {          
            _panel = panel;
        }

        public void Clear()
        {
            _panel.Controls.Clear();
        }

        public ImagePanelController AddImage(List<Image> images)
        {
            _panel.Controls.Clear();
            var count = 0;
            foreach (var image in images)
            {
                var pictureBox = new PictureBox();
                pictureBox.Location = new Point(images.Count * 120 + 10, 10);
                pictureBox.Size = new Size(100, 120);
                if(count == 0)
                    pictureBox.Margin =  new Padding(50, 40, 40, 40);
                else
                    pictureBox.Margin =  new Padding(50, 0, 40, 40);

                try
                {
                    pictureBox.Image = image;
                }
                catch (Exception)
                {
                    throw;
                }

                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                _panel.Controls.Add(pictureBox);
                count++;
                Count = count;
            }

            return this;
        }

        public void AddPage(string path)
        {
            _panel.Controls.Clear();
            var listPage = PRFWorker.ToImage(path);
            var count = 0;
            foreach (var pdfImage in listPage)
            {
                var pictureBox = new PictureBox();
                pictureBox.Location = new Point(listPage.Count * 120 + 10, 10);
                pictureBox.Size = new Size(280, 370);
                if (count == 0)
                    pictureBox.Margin =  new Padding(50, 40, 40, 40);
                else
                    pictureBox.Margin =  new Padding(50, 0, 40, 40);


                try
                {
                    pictureBox.Image = pdfImage;
                }
                catch (Exception)
                {
                    throw;
                }

                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                _panel.Controls.Add(pictureBox);
                count++;

                Count = count;
            }

        }
    }
}
