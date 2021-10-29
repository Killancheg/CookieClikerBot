using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using CookieClickerBot.WindowFinder;


namespace CookieClickerBot.Helpers
{
    static class DrawHelper
    {
        [DllImport("user32.dll", EntryPoint = "GetDC")]
        public static extern IntPtr GetDC(IntPtr ptr);

        public static void HighlightSelectedWindow(IntPtr hWnd, CancellationToken token)
        {
            IntPtr screen = GetDC(IntPtr.Zero);
            while (!token.IsCancellationRequested)
            {
                if (WindowHelper.IsWindowActive(hWnd))
                {
                    using (Graphics g = Graphics.FromHdc(screen))
                    {
                        g.Clear(Color.Transparent);
                        Rectangle rect = WindowHelper.GetWindowBorderRectangle(hWnd);
                        Pen myPen = new Pen(System.Drawing.Color.Red, 3);
                        g.DrawRectangle(myPen, rect);
                        g.Dispose();
                    }
                }
            }
        }
    }
}
