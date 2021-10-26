using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClickerBot.Helpers
{
    static class ImageHelper
    {
        private static List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };

        public static bool IsImageByPath(string path)
        {
            bool isImage = false;

            if (ImageExtensions.Contains(Path.GetExtension(path).ToUpperInvariant()))
                isImage = true;

            return isImage;
        }
    }
}
