using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookieClickerBot.ProcessTypes;
using CookieClickerBot.WindowFinder;

namespace CookieClickerBot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateProcessList();
        }

        private void butTestFormStart_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.Show();
        }

        private void UpdateProcessList()
        {
            List<ComboBoxWindows> comboBoxOpenWindows = WindowHelper.GetComboBoxOpenedWindowsList();
            cbProcessNamesList.Items.Clear();

            foreach (var comboBoxWindow in comboBoxOpenWindows)
            {
                cbProcessNamesList.Items.Add(comboBoxWindow);
            }
        }

        private void cbProcessNamesList_DropDown(object sender, EventArgs e)
        {
            UpdateProcessList();
        }
    }
}
