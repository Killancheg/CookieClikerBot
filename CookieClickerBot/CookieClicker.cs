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

        private string bigCooliePath = "";
        private string goldCooliePath = "";

        public CookieClicker(ScreenShotForm workViewer, IntPtr hWnd, CancellationToken token)
        {
            this.workViewer = workViewer;
            windowHandler = hWnd;
            clicerCancelationToken = token;
            GetTargetsPaths();
        }

        private void GetTargetsPaths()
        {
            bigCooliePath = FileHelper.GetTargetImagesFolderPath() + @"perfectCookie";
            goldCooliePath = FileHelper.GetTargetImagesFolderPath() + @"goldCookie";
        }


        public async Task Run()
        {
            GetCurrentImage();
            ShowImageWithRectangles();

            Task bigCookieClickeTask = Task.Run(() => FindCookie(bigCooliePath));
            Task goldCookieClickeTask = Task.Run(() => FindCookie(goldCooliePath));
            while (!clicerCancelationToken.IsCancellationRequested)
            {
                GetCurrentImage();
                await Task.Delay(300);
                ShowImageWithRectangles();
            }
            workViewer.Close();
        }

        private void GetCurrentImage()
        {
            var sc = new ScreenCapture();
            сurrentImage = sc.GetScreenshot(windowHandler);
            imageWithRectangles = сurrentImage.Clone() as Bitmap;
        }

        private void ShowImageWithRectangles()
        {
            Bitmap imageToShow = imageWithRectangles.Clone() as Bitmap;
            workViewer.CopyWindowSize(windowHandler);
            workViewer.SetPictureBoxImage(imageToShow);
        }

        private void FindCookie(string targetsFolder)
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

        private void DrawRectangleOnImage(Rectangle recToDraw)
        {
            lock (imageWithRectanglesLocker)
            {
                
                Image<Bgr, byte> source = imageWithRectangles.ToImage<Bgr, byte>();
                source.Draw(recToDraw, new Bgr(Color.Red), 3);
                imageWithRectangles = source.ToBitmap();
            }
        }

        private void ClickOnCookie(Rectangle recToClick)
        {
            Rectangle handlerRect = WindowHelper.GetWindowBorderRectangle(windowHandler);

            recToClick.Offset(handlerRect.X, handlerRect.Y);

            LesftMouseClickInRectangle(recToClick);
        }
    }
}
