using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookieClickerBot.Helpers;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;


namespace CookieClickerBot
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void butChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageChoser = new OpenFileDialog();
            DialogResult imageChoserResult = imageChoser.ShowDialog();
            if (imageChoserResult == DialogResult.OK)
            {
                tbImageLocation.Text = imageChoser.FileName;
                UpdateTestEnvironment();
            }
        }

        private void tbImageLocation_Validating(object sender, CancelEventArgs e)
        {
            UpdateTestEnvironment();
        }

        private void tbImageLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateTestEnvironment();
            }
        }

        private void pbImageToCompare_Click(object sender, EventArgs e)
        {
            ClickCounterIncrease();
        }

        private void butClickCounterClear_Click(object sender, EventArgs e)
        {
            ClearClickCounter();
        }

        private void UpdateTestEnvironment()
        {
            UpdateImageToCompare();
            ClearClickCounter();
        }

        private void ClickCounterIncrease()
        {
            Int32.TryParse(lbClickCounter.Text, out int clickCounter);
            lbClickCounter.Text = (clickCounter + 1).ToString();
        }

        private void ClearClickCounter()
        {
            lbClickCounter.Text = "0";
        }

        private void UpdateImageToCompare()
        {
            if (ImageHelper.IsImageByPath(tbImageLocation.Text))
            {
                pbImageToCompare.ImageLocation = tbImageLocation.Text;
            }
            else
            {
                MessageBox.Show("Необходимо выбрать изображение!", "Внимание!");
            }
        }

        private void butRescale_Click(object sender, EventArgs e)
        {
            List<string> targets = ImageHelper.GetImagesFromFolderList(@"D:\Code\Repos\CookieClickerBot\CookieClickerBot\CookieClickerBot\CookieClickerTargets\", false);

            List<double> percents = new List<double>();
            double percentVariant = 0.50;
            while (percentVariant < 1.01)
            {
                percents.Add(percentVariant);
                percentVariant += 0.05;
            }
            

            foreach (var percent in percents)
            {
                for (int i = 0; i < targets.Count; i++)
                {
                    string foldername = Path.GetFileName(targets[i]).Replace(".png","");
                    foldername = @"D:\Code\Repos\CookieClickerBot\CookieClickerBot\CookieClickerBot\CookieClickerTargets\TargetsRescaled\" + foldername + @"\";
                    string filename = $"{i}_{percent}.png";
                    filename = filename.Replace(",", "").Replace("_0","_");
                    string fullFilename = foldername + filename;
                    if (!Directory.Exists(foldername))
                    {
                        Directory.CreateDirectory(foldername);
                    }
                    ImageHelper.PercentResizeImage(targets[i], percent);
                    ImageHelper.PercentResizeImage(targets[i], percent).Save(fullFilename);
                    //Image<Bgr, byte> image = ImageHelper.PercentResizeImage(targets[i], percent);
                    //ImageHelper.GetGrayScaledImage(image).Save(fullFilename);
                    //MessageBox.Show($"Сохранен файл {filename}");
                }
            }
        }
    }
}
