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
    public partial class ScreenShotForm : Form
    {
        public ScreenShotForm()
        {
            InitializeComponent();
        }

        public void CopyWindowSize(IntPtr hWnd)
        {
            Rectangle copiedWindowRectangle = WindowHelper.GetWindowBorderRectangle(hWnd);

            Width = copiedWindowRectangle.Width+20;
            Height = copiedWindowRectangle.Height+40;

            pbScreenshot.Width = copiedWindowRectangle.Width;
            pbScreenshot.Height = copiedWindowRectangle.Height;
        }

        public void SetPictureBoxImage(Bitmap image)
        {
            pbScreenshot.Image = image;
        }
    }
}
