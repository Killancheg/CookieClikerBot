using System;
using System.Drawing;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookieClickerBot.Helpers;
using CookieClickerBot.ProcessTypes;

namespace CookieClickerBot.PannelFoms
{
    public partial class BotStartForm : Form
    {
        public event StartStopBot ChangeActiveStatus;

        private bool isRunning;

        private CancellationTokenSource DrawingTokenSource;

        private CancellationTokenSource ClickerTokenSource;

        private KeyHandler ghk;

        public BotStartForm()
        {
            InitializeComponent();
            ItializeActiveStatusChangeEvent();
            ghk = new KeyHandler(Keys.Insert, this);
            ghk.Register();
        }

        private void ItializeActiveStatusChangeEvent()
        {
            ChangeActiveStatus += ChageBotActiveStatus;
            ChangeActiveStatus += ChangeStartButtion;
            ChangeActiveStatus += StartStopClicker;
            ChangeActiveStatus += ChageComboboxEnambledStatus;
        }

        private void UpdateProcessList()
        {
            List<ComboBoxWindow> comboBoxOpenWindows = WindowHelper.GetComboBoxOpenedWindowsList();
            cbWindowList.Items.Clear();

            foreach (var comboBoxWindow in comboBoxOpenWindows)
            {
                cbWindowList.Items.Add(comboBoxWindow);
            }
        }

        private void ChageComboboxEnambledStatus()
        {
            if (isRunning)
            {
                cbWindowList.Enabled = false;
            }
            else
            {
                cbWindowList.Enabled = true;
            }
        }

        private void ChangeStartButtion()
        {
            if (isRunning)
            {
                btnStart.Text = btnStart.Text.Replace("Start", "Stop");
                btnStart.Image = Properties.Resources.Small_stop_img;
            }
            else
            {
                btnStart.Text = btnStart.Text.Replace("Stop", "Start");
                btnStart.Image = Properties.Resources.Small_start_img;
            }
        }

        private void ChageBotActiveStatus()
        {
            isRunning = !isRunning;
        }

        private async void StartStopClicker()
        {
            if (isRunning)
            {
                ClickerTokenSource = new CancellationTokenSource();

                ScreenShotForm clickerViewer = CreateSceenShotForm();

                clickerViewer.Show();

                ComboBoxWindow selectedWindow = cbWindowList.SelectedItem as ComboBoxWindow;

                CookieClicker cookieClicker = new CookieClicker(clickerViewer, selectedWindow.ID, ClickerTokenSource.Token);

                await cookieClicker.Run();
                //Task autoCkickCokies = Task.Run(() => cookieClicker.Run());
            }
            else
            {
                ClickerTokenSource.Cancel();
            }

        }

        private ScreenShotForm CreateSceenShotForm()
        {
            ScreenShotForm screenshotViewer = new ScreenShotForm();
            ComboBoxWindow selectedWindow = cbWindowList.SelectedItem as ComboBoxWindow;
            screenshotViewer.CopyWindowSize(selectedWindow.ID);
            return screenshotViewer;
        }

        private void HandleHotkey()
        {
            if (cbWindowList.SelectedIndex != -1)
            {
                ChangeActiveStatus();
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void cbWindowList_DropDown(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbWindowList.SelectedIndex != -1)
            {
                ChangeActiveStatus();
            }
        }

        private void chbDrawRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWindowList.SelectedIndex != -1)
            {
                if (chbDrawRectangle.Checked)
                {
                    ComboBoxWindow selectedWindow = cbWindowList.SelectedItem as ComboBoxWindow;

                    DrawingTokenSource = new CancellationTokenSource();

                    Task drowRectangleTask = Task.Run(() => DrawHelper.HighlightSelectedWindow(selectedWindow.ID, DrawingTokenSource.Token));
                }
                else
                {
                    DrawingTokenSource.Cancel();
                }
            }
        }

        private void cbWindowList_Enter(object sender, EventArgs e)
        {
            UpdateProcessList();
        }
    }
}
