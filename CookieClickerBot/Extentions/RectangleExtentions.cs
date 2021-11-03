using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClickerBot.Extentions
{
    public static class RectangleExtentions
    {
        public static Point Center(this Rectangle rect)
        {
            return new Point(rect.Left + rect.Width / 2,
                     rect.Top + rect.Height / 2);
        }

    }
}
