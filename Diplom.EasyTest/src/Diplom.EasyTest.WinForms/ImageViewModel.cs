using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.WinForms
{
    internal static class ImageViewModel
    {
        public static string GetBase64StringImage(string path)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var newImage = new Bitmap(path);
                newImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                var buteImage = ms.ToArray();

                return Convert.ToBase64String(buteImage);
            }
        }

        public static Image GetImageFromBase64String(string base64String)
        {
            byte[] b = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(b, 0, b.Length))
            {
                return Image.FromStream(ms, true);
            }
        }
    }
}
