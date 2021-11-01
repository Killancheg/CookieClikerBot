using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing;

namespace CookieClickerBot
{
    class CookieClicker : Clicker
    {
        private ScreenShotForm workViewer;

        private IntPtr windowHandler;

        private CancellationToken clicerCancelationToken;

        private Bitmap сurrentImage;

        private Bitmap imageWithRectangles;

        public CookieClicker(ScreenShotForm workViewer, IntPtr hWnd, CancellationToken token)
        {
            this.workViewer = workViewer;
            windowHandler = hWnd;
            clicerCancelationToken = token;
        }


        public async Task Run()
        {
            while (!clicerCancelationToken.IsCancellationRequested)
            {
                await Task.Delay(5000);
                GetCurrentImage();
                ShowImageWithRectangles();
            }
            workViewer.Close();
        }

        public void GetCurrentImage()
        {
            var sc = new ScreenCapture();
            сurrentImage = sc.GetScreenshot(windowHandler);
            imageWithRectangles = сurrentImage;
        }

        public void ShowImageWithRectangles()
        {
            workViewer.CopyWindowSize(windowHandler);
            workViewer.SetPictureBoxImage(imageWithRectangles);
        }

        public void FindBigCookie()
        {

        }

        public void ClickOnBigCookie()
        {

        }
    }
}
