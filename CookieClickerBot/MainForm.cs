using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClickerBot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void butTestFormStart_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.Show();
        }
    }
}
