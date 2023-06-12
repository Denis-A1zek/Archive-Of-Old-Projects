using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Apitron.PDF.Rasterizer.Configuration;

namespace PDFNotes.Core.PDF
{
    public class PRFWorker
    {

        private Document doc;
        public string Path;
        public delegate void PRDWriterHandler(object sender);
        public event PRDWriterHandler PDFWriteEnd;

        public PRFWorker(string path)
        {
            Path = path;
            doc = new Document();
        }

        public async Task AddAsync(List<System.Drawing.Image> image, System.Drawing.Imaging.ImageFormat format)
        {
            await Task.Run(() => Add(image, format));

        }

        public void Add(List<System.Drawing.Image> element, System.Drawing.Imaging.ImageFormat format)
        {
            using (var fs = new FileStream(Path, FileMode.Create))
            {
                PdfWriter.GetInstance(doc, fs);               
                doc.Open();

                foreach (var item in element)
                {
                    doc.Add(iTextSharp.text.Image.GetInstance(item,format));
                   
                }
                doc.Close();
            }

            PDFWriteEnd?.Invoke(this);
        }

        public static List<System.Drawing.Image> ToImage(string pdfInputPath)
        {
            FileStream fs = new FileStream(pdfInputPath, FileMode.Open);
            Apitron.PDF.Rasterizer.Document doc = new Apitron.PDF.Rasterizer.Document(fs);
            RenderingSettings option = new RenderingSettings();
            option.DrawAnotations = true;
            var listImage = new List<System.Drawing.Image>();
            
            foreach (var item in doc.Pages)
            {
                listImage.Add(item.Render((int)doc.Pages[0].Width,
                (int)doc.Pages[0].Height, option));
            }

            doc.Dispose();
            fs.Dispose();

            return listImage;
            //Save(Path.ChangeExtension(Path.Combine(imageOutputPath, imageName), ImageFormat.Png.ToString()), ImageFormat.Png);
        }
    }
}
