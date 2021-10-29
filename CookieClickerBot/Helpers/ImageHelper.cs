using System;
using System.Collections.Generic;
using System.IO;
using CookieClickerBot;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

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

        public static List<string> GetImagesFromFolderList(string folderPath, bool isRecursive)
        {
            List<string> foundImages = new List<string>();

            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            foreach (var filter in ImageExtensions)
            {
                string[] allFiltredImages = Directory.GetFiles(folderPath, "*"+filter.ToLower(), searchOption);
                foundImages.AddRange(allFiltredImages);
            }

            return foundImages;
        }

        public static Image<Bgr, Byte> PercentResizeImage(string filePath,double percent)
        {
            Image<Bgr, Byte> captureImage = new Image<Bgr, byte>(filePath);

            int newWidth = (int)Math.Ceiling(captureImage.Width * percent);
            int newHeight = (int)Math.Ceiling(captureImage.Height * percent);

            Image<Bgr, byte> resizedImage = captureImage.Resize(newWidth, newHeight, Inter.Linear);

            return resizedImage;
        }

    }
}
