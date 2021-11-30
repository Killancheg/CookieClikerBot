using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CookieClickerBot.Helpers;
using Markdig;

namespace CookieClickerBot.PannelFoms
{
    public partial class ReadMeForm : Form
    {
        public ReadMeForm()
        {
            InitializeComponent();
            FillReadme();
        }

        private void FillReadme()
        {
            var mdReadme = Properties.Resources.ReadMe;
            var htmlReadme = Markdown.ToHtml(mdReadme);
            wbReadMe.DocumentText = htmlReadme;
        }

        private void wbReadMe_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (!(e.Url.ToString().Equals("about:blank", StringComparison.InvariantCultureIgnoreCase)))
            {
                e.Cancel = true;
                Process.Start(e.Url.ToString());
            }
        }
    }
}
