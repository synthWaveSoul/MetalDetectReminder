using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetalDetectReminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // start timer on load
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            WindowState = FormWindowState.Maximized;
        }

        // every 0.7s change color of bars and font
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxBottom.BackColor == Color.Red)
            {
                pictureBoxBottom.BackColor = Color.DarkRed;
                pictureBoxTop.BackColor = Color.DarkRed;
                mainText.ForeColor = Color.Black;
            } else
            {
                pictureBoxBottom.BackColor= Color.Red;
                pictureBoxTop.BackColor= Color.Red;
                mainText.ForeColor = Color.Red;
            }
        }

    }
}
