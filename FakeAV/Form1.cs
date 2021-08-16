using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FakeAV
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            
            StatusLabel.Text = "Not Protected";
            
            StatusLabel.BackColor = System.Drawing.Color.Transparent;
            statusIcon.IconChar = FontAwesome.Sharp.IconChar.Viruses;
            statusIcon.IconColor = System.Drawing.Color.Red;
            pictureBox1.SendToBack();
            pictureBox2.SendToBack();
            CircleProgressBar1.SendToBack();
            Scan.BringToFront();

        }

        async private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (iconButton1.IconColor == System.Drawing.Color.Red)
            {
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
                //iconButton1.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                iconButton1.IconColor = System.Drawing.Color.Lime;
            }

            else
            {
                //iconButton1.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
                iconButton1.IconColor = System.Drawing.Color.Red;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            if (iconButton2.IconColor == System.Drawing.Color.Red)
            {
                iconButton2.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
                //iconButton1.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                iconButton2.IconColor = System.Drawing.Color.Lime;
            }

            else
            {
                //iconButton1.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                iconButton2.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
                iconButton2.IconColor = System.Drawing.Color.Red;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (iconButton3.IconColor == System.Drawing.Color.Red)
            {
                iconButton3.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
                //iconButton1.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                iconButton3.IconColor = System.Drawing.Color.Lime;
            }

            else
            {
                //iconButton1.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                iconButton3.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
                iconButton3.IconColor = System.Drawing.Color.Red;
            }
        }

        private void iconPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private async void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            await Task.Delay(150);
            Scan.Visible = false;
            CircleProgressBar1.Visible = true;

            StatusLabel.Text = "  Scanning...";
            StatusLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            statusIcon.IconChar = FontAwesome.Sharp.IconChar.Vial;
            statusIcon.IconColor = System.Drawing.Color.DodgerBlue;
            int bar = 0;
            while (bar < 100)
            {
                if (statusIcon.Rotation > 0) statusIcon.Rotation = -1;
                else statusIcon.Rotation = 1;
                bar = bar + 1;
                CircleProgressBar1.Value = bar;
                await Task.Delay(50);
            }

            Scan.Visible = false;
            CircleProgressBar1.Visible = true;
            StatusLabel.Text = "  Protected";
            StatusLabel.ForeColor = System.Drawing.Color.Lime;

            statusIcon.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            statusIcon.IconColor = System.Drawing.Color.Lime;
            Scan.Visible = true;
            CircleProgressBar1.Visible = false;
            bar = 0;
        }
    }
}
