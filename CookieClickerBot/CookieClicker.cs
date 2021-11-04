using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing;
using CookieClickerBot.Helpers;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using CookieClickerBot.Extentions;

namespace CookieClickerBot
{
    class CookieClicker : Clicker
    {
        private ScreenShotForm workViewer;

        private IntPtr windowHandler;

        private CancellationToken clicerCancelationToken;

        private Bitmap сurrentImage;

        private Bitmap imageWithRectangles;

        private object imageWithRectanglesLocker = new object();

        public CookieClicker(ScreenShotForm workViewer, IntPtr hWnd, CancellationToken token)
        {
            this.workViewer = workViewer;
            windowHandler = hWnd;
            clicerCancelationToken = token;
        }


        public async Task Run()
        {
            GetCurrentImage();
            ShowImageWithRectangles();

            Task bigCookieClickeTask = Task.Run(() => FindCookie(@"D:\Code\Repos\CookieClickerBot\CookieClickerBot\CookieClickerBot\CookieClickerTargets\TargetsRescaled\perfectCookie"));
            Task goldCookieClickeTask = Task.Run(() => FindCookie(@"D:\Code\Repos\CookieClickerBot\CookieClickerBot\CookieClickerBot\CookieClickerTargets\TargetsRescaled\goldCookie"));
            while (!clicerCancelationToken.IsCancellationRequested)
            {
                await Task.Delay(300);
                GetCurrentImage();
                ShowImageWithRectangles();
            }
            workViewer.Close();
        }

        public void GetCurrentImage()
        {
            var sc = new ScreenCapture();
            сurrentImage = sc.GetScreenshot(windowHandler);
        }

        public void ShowImageWithRectangles()
        {
            Bitmap imageToShow = imageWithRectangles;
            workViewer.CopyWindowSize(windowHandler);
            workViewer.SetPictureBoxImage(imageToShow);
        }


        //путь к папке пока захардкожен, надо будет как-то это поменять
        public void FindCookie(string targetsFolder)
        {
            List<string> targetsPaths = ImageHelper.GetImagesFromFolderList(targetsFolder, false);

            List<Image<Bgr, byte>> targets = new List<Image<Bgr, byte>>();

            foreach (string targetsPath in targetsPaths)
            {
                targets.Add(new Image<Bgr, byte>(targetsPath));
            }

            while (!clicerCancelationToken.IsCancellationRequested)
            {
                Task.Delay(300);
                Image<Bgr, byte> source = сurrentImage.ToImage<Bgr, byte>();
                bool isMatchFound = false;
                Rectangle rectangleToClick = new Rectangle();

                Rectangle matchingRectangle = new Rectangle();

                bool isFound = false;

                Parallel.ForEach(targets, (target, state) =>
                {
                    isFound = ImageHelper.IsMatching(source, target, out matchingRectangle);
                    if (isFound)
                    {
                        rectangleToClick = matchingRectangle;
                        isMatchFound = isFound;
                        state.Break();
                    }
                });
                if (isMatchFound)
                {
                    ClickOnCookie(rectangleToClick);
                    DrawRectangleOnImage(rectangleToClick);
                }
            }
        }

        public void DrawRectangleOnImage(Rectangle recToDraw)
        {
            lock (imageWithRectanglesLocker)
            {
                imageWithRectangles = сurrentImage;
                Image<Bgr, byte> source = imageWithRectangles.ToImage<Bgr, byte>();
                source.Draw(recToDraw, new Bgr(Color.Red), 3);
                imageWithRectangles = source.ToBitmap();
            }
        }

        public void ClickOnCookie(Rectangle recToClick)
        {
            Rectangle handlerRect = WindowHelper.GetWindowBorderRectangle(windowHandler);

            recToClick.Offset(handlerRect.X, handlerRect.Y);

            LesftMouseClickInRectangle(recToClick);
        }
    }
}
