using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            IntPtr desktop = GetDC(IntPtr.Zero);
            while (!token.IsCancellationRequested)
            {
                using (Graphics g = Graphics.FromHdc(desktop))
                {
                    Rectangle rect = WindowHelper.GetWindowBorderRectangle(hWnd);
                    Pen myPen = new Pen(System.Drawing.Color.Red, 3);
                    g.DrawRectangle(myPen, rect);
                    g.Dispose();
                }
            }
        }
    }
}
