using System;
using System.Drawing;
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

        public static Image<Bgr, byte> PercentResizeImage(string filePath,double percent)
        {
            Image<Bgr, byte> captureImage = new Image<Bgr, byte>(filePath);

            int newWidth = (int)Math.Ceiling(captureImage.Width * percent);
            int newHeight = (int)Math.Ceiling(captureImage.Height * percent);

            Image<Bgr, byte> resizedImage = captureImage.Resize(newWidth, newHeight, Inter.Linear);

            return resizedImage;
        }

        public static bool IsMatching(Image<Bgr, byte> source, Image<Bgr, byte> template, out Rectangle match)
        {
            match = new Rectangle();

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
                if (maxValues[0] > 0.80)
                {
                    match = new Rectangle(maxLocations[0], template.Size);
                    return true;
                }
            }
            return false;
        }

        public static Image<Gray, byte> GetGrayScaledImage(Image<Bgr, byte> source)
        {
            Image<Gray, byte> grayImage = source.Convert<Gray, byte>();

            return grayImage;
        }

    }
}
