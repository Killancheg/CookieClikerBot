using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookieClickerBot.Helpers;

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

            double[] percents = new double[] { 0.60, 0.65, 0.70, 0.75, 0.80, 0.95, 0.90, 0.95, 1.10 };

            foreach (var percent in percents)
            {
                for (int i = 0; i < targets.Count; i++)
                {
                    string filename = $"{i}_{percent}.png";
                    filename = filename.Replace(",", "").Replace("_0","_");
                    string fullFilename = @"D:\Code\Repos\CookieClickerBot\CookieClickerBot\CookieClickerBot\CookieClickerTargets\TargetsRescaled\" + filename;
                    ImageHelper.PercentResizeImage(targets[i], percent).Save(fullFilename);
                    //MessageBox.Show($"Сохранен файл {filename}");
                }
            }
        }
    }
}
