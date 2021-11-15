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
    public partial class NewMainForm : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;

        //Constructor
        public NewMainForm()
        {
            InitializeComponent();
            random = new Random();
        }

        //Methods

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
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
                }
            }
        }

        private void btnClicker_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
