using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClickerBot.Helpers
{   ///<summary>Статический класс, содержащий в себе методы для работы с файлами.</summary>
    static class FileHelper
    {
        public static void UnzipResouceImages()
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string ExtractionPath = AppDomain.CurrentDomain.BaseDirectory + @"TargetImages\";
            string zipPath = appPath + @"\TargetsRescaled.zip";
            if (!Directory.Exists(ExtractionPath))
            {
                Directory.CreateDirectory(ExtractionPath);
                File.WriteAllBytes(zipPath, Properties.Resources.TargetsRescaled);
                ZipFile.ExtractToDirectory(zipPath, ExtractionPath);
                File.Delete(zipPath);
            }
        }

        public static string GetTargetImagesFolderPath()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"TargetImages\";

            return path;
        }

        public async static Task<string> GetTextFromFile(string path)
        {
            string text = "";
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path, Encoding.UTF8))
                {
                    text = await file.ReadToEndAsync();
                }
            }

            return text;
        }
    }
}
