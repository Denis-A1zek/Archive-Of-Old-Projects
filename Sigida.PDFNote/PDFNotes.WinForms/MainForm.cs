using PDFNotes.Core.PDF;
using PDFNotes.WinForms.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFNotes.WinForms
{
    public partial class MainForm : Form
    {
        ImagePanelController imageLeftController;
        ImagePanelController pageController;
        List<Image> notes;
        public MainForm()
        {
            InitializeComponent();

            imageLeftController = new ImagePanelController (flowLayoutPanel1);
            pageController = new ImagePanelController(flowLayoutPanel2);
            notes = new List<Image>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void addImage_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            ofd.Multiselect = true;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in ofd.FileNames)
                {                   
                    notes.Add(new Bitmap(new Bitmap(item),523,760));
                }     
                imageLeftController.AddImage(notes);
            }
        }

        private async void convertToPDF_Click(object sender, EventArgs e)
        {
            if (notes.Count == 0 || imageLeftController.Count == 0)
                return;

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save document";
            saveDialog.OverwritePrompt = true;
            saveDialog.CheckPathExists = true;
            saveDialog.Filter = "PDF document(*.pdf)|*.pdf";           

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var pdfWriter = new PRFWorker(saveDialog.FileName);                
                    await pdfWriter.AddAsync(notes, sizeChecker.Checked == true ? System.Drawing.Imaging.ImageFormat.Jpeg: System.Drawing.Imaging.ImageFormat.Png);
                    
                    pageController.AddPage(pdfWriter.Path);
                }
                catch (Exception)
                {
                    throw;
                }
            }                         
        }

        private void deleteList_Click(object sender, EventArgs e)
        {
            notes.Clear();
            imageLeftController.Clear();
        }
    }
}
