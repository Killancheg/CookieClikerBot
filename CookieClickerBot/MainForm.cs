using System;
using System.Drawing;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookieClickerBot.Helpers;
using CookieClickerBot.ProcessTypes;

namespace CookieClickerBot
{
    public delegate void StartStopBot();


    public partial class MainForm : Form
    {
        public event StartStopBot ChangeActiveStatus;

        private bool isRunning;

        private CancellationTokenSource DrawingTokenSource;

        private CancellationTokenSource ClickerTokenSource;

        private KeyHandler ghk;

        public MainForm()
        {
            InitializeComponent();
            UpdateProcessList();
            ItializeActiveStatusChangeEvent();
            ghk = new KeyHandler(Keys.Insert, this);
            ghk.Register();
        }

        private void ItializeActiveStatusChangeEvent()
        {
            ChangeActiveStatus += ChageBotActiveStatus;
            ChangeActiveStatus += ChangeStartButtion;
            ChangeActiveStatus += StartStopClicker;
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
                butStart.Text = butStart.Text.Replace("Старт","Стоп");
                butStart.Image = Properties.Resources.Small_stop_img;
            }
            else
            {
                butStart.Text = butStart.Text.Replace("Стоп", "Старт");
                butStart.Image = Properties.Resources.Small_start_img;
            }
        }

        private void ChageBotActiveStatus()
        {
            isRunning = !isRunning;
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            // не учитывает случая, когда кликкер был запущен в одном окне, а затем было выбрано другое
            // Возможно стоит написать триггеры для комбобокса
            if (cbProcessNamesList.SelectedIndex != -1)
            {
                ChangeActiveStatus();
            }
        }

        private async void StartStopClicker()
        {
            if (isRunning)
            {
                ClickerTokenSource = new CancellationTokenSource();

                ScreenShotForm clickerViewer = CreateSceenShotForm();

                clickerViewer.Show();

                ComboBoxWindow selectedWindow = cbProcessNamesList.SelectedItem as ComboBoxWindow;

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
            ComboBoxWindow selectedWindow = cbProcessNamesList.SelectedItem as ComboBoxWindow;
            screenshotViewer.CopyWindowSize(selectedWindow.ID);
            return screenshotViewer;
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


        private void HandleHotkey()
        {
            if (cbProcessNamesList.SelectedIndex != -1)
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
    }
}
