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

            StatusLabel.Location = new Point(40, 50);
            StatusLabel.Text = "Not Protected";
            StatusLabel.ForeColor = System.Drawing.Color.Orange;
            statusIcon.IconChar = FontAwesome.Sharp.IconChar.Viruses;
            statusIcon.IconColor = System.Drawing.Color.Red;


        }

        async private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            progressBar1.Visible = true;
            StatusLabel.Location = new Point(80, 50);
            StatusLabel.Text = "Scanning";
            StatusLabel.ForeColor = System.Drawing.Color.Blue;
            statusIcon.IconChar = FontAwesome.Sharp.IconChar.Vial;
            statusIcon.IconColor = System.Drawing.Color.Blue;
            int bar = 0;
            while(bar < 100)
            {
                if(statusIcon.Rotation>0) statusIcon.Rotation = -1;
                else statusIcon.Rotation = 1;
                bar = bar + 1;
                progressBar1.Value = bar;
                await Task.Delay(50);
            }

            button1.Visible = false;
            progressBar1.Visible = true;
            StatusLabel.Text = "Protected";
            StatusLabel.ForeColor = System.Drawing.Color.Green;
            StatusLabel.Location = new Point(80, 50);
            statusIcon.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            statusIcon.IconColor = System.Drawing.Color.Green;
            button1.Visible = true;
            progressBar1.Visible = false;
            bar = 0;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (iconButton1.BackColor == System.Drawing.Color.Red)
            {
                iconButton1.BackColor = System.Drawing.Color.Green;
            }
            else iconButton1.BackColor = System.Drawing.Color.Red;
        }
    }
}
