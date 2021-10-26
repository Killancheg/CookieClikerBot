using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookieClickerBot.Helpers;

namespace CookieClickerBot
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void butChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageChoser = new OpenFileDialog();
            DialogResult imageChoserResult = imageChoser.ShowDialog();
            if (imageChoserResult == DialogResult.OK)
            {
                tbImageLocation.Text = imageChoser.FileName;
                UpdateTestEnvironment();
            }
        }

        private void tbImageLocation_Validating(object sender, CancelEventArgs e)
        {
            UpdateTestEnvironment();
        }

        private void tbImageLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateTestEnvironment();
            }
        }

        private void pbImageToCompare_Click(object sender, EventArgs e)
        {
            Int32.TryParse(lbClickCounter.Text, out int clickCounter);
            lbClickCounter.Text = (clickCounter + 1).ToString();
        }

        private void butClickCounterClear_Click(object sender, EventArgs e)
        {
            ClearClickCounter();
        }

        private void UpdateTestEnvironment()
        {
            UpdateImageToCompare();
            ClearClickCounter();
        }

        private void ClearClickCounter()
        {
            lbClickCounter.Text = "0";
        }

        private void UpdateImageToCompare()
        {
            if (ImageHelper.IsImageByPath(tbImageLocation.Text))
            {
                pbImageToCompare.ImageLocation = tbImageLocation.Text;
            }
            else
            {
                MessageBox.Show("Необходимо выбрать изображение!", "Внимание!");
            }
        }

        
    }
}
