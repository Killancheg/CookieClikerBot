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

namespace CookieClickerBot
{
    public partial class MainForm : Form
    {
        private Process[] processList;

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
            processList = Process.GetProcesses();
            cbProcessNamesList.Items.Clear();
            foreach (Process process in processList)
            {
                if (process.MainWindowTitle.Length > 0)
                    cbProcessNamesList.Items.Add(new ComboBoxProcess(process.MainWindowTitle, process.Id));
            }
        }

        private void cbProcessNamesList_DropDown(object sender, EventArgs e)
        {
            UpdateProcessList();
        }
    }
}
