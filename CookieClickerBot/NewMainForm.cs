using System;
using System.Drawing;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookieClickerBot.Helpers;
using CookieClickerBot.ProcessTypes;
using CookieClickerBot.PannelFoms;
using System.Runtime.InteropServices;

namespace CookieClickerBot
{
    public partial class NewMainForm : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public NewMainForm()
        {
            InitializeComponent();
            RemoveStandartBorder();
            FileHelper.UnzipResouceImages();
            random = new Random();
            pbLogo.Image = Properties.Resources.logo;
            OpenChildForm(new ReadMeForm(), pbLogo);
        }

        //Methods

        private void RemoveStandartBorder()
        {
            ///this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            // Функционал для множества цветов
            //while (tempIndex == index)
            //{
            //    index = random.Next(ThemeColor.ColorList.Count);
            //}
            tempIndex = index;
            string color = ThemeColor.ColorList[index];

            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (btnSender.GetType() == typeof(Button))
                {
                    if (currentButton != (Button)btnSender)
                    {
                        Button activeButton = btnSender as Button;
                        DisableButton();
                        Color color = SelectThemeColor();
                        currentButton = (Button)btnSender;
                        currentButton.BackColor = color;
                        currentButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    }
                }
                else
                {
                    DisableButton();
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previusBtn in  panelMenu.Controls)
            {
                if (previusBtn.GetType() == typeof(Button))
                {
                    previusBtn.BackColor = Color.FromArgb(182, 183, 167);
                    previusBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    currentButton = null;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            desctopPanel.Controls.Add(childForm);
            desctopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }

        private void btnClicker_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BotStartForm(),sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SettingsForm(), sender);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TestEnvForm(), sender);
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReadMeForm(), sender);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.Image = Properties.Resources.minimize_fromMax;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.Image = Properties.Resources.maximize;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
