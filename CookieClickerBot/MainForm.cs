using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookieClickerBot.Helpers;
using CookieClickerBot.ProcessTypes;
using CookieClickerBot.WindowFinder;

namespace CookieClickerBot
{
    public delegate void StartStopBot();
    

    public partial class MainForm : Form
    {
        public event StartStopBot ChangeActiveStatus;

        private bool isRunning;

        private CancellationTokenSource DrawingTokenSource;

        public MainForm()
        {
            InitializeComponent();
            UpdateProcessList();
            ChangeActiveStatus += ChageBotActiveStatus;
            ChangeActiveStatus += ChangeStartButtion;
        }

        private void butTestFormStart_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.Show();
        }

        private void UpdateProcessList()
        {
            List<ComboBoxWindow> comboBoxOpenWindows = WindowHelper.GetComboBoxOpenedWindowsList();
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

        private void ChangeStartButtion()
        {
            if (isRunning)
            {
                butStart.Text = "Стоп";
                butStart.Image = Properties.Resources.Small_stop_img;
            }
            else
            {
                butStart.Text = "Старт";
                butStart.Image = Properties.Resources.Small_start_img;
            }
        }

        private void ChageBotActiveStatus()
        {
            isRunning = !isRunning;
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            ChangeActiveStatus();
        }

        private void cbDrawRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProcessNamesList.SelectedIndex != -1)
            {
                if (cbDrawRectangle.Checked)
                {
                    ComboBoxWindow selectedWindow = cbProcessNamesList.SelectedItem as ComboBoxWindow;

                    DrawingTokenSource = new CancellationTokenSource();

                    Task drowRectangleTask = Task.Run(() => DrawHelper.HighlightSelectedWindow(selectedWindow.ID, DrawingTokenSource.Token));
                }
                else
                {
                    DrawingTokenSource.Cancel();
                }
            }
        }
    }
}
