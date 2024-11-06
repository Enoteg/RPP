using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab2Sam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowImage(0);
        }

        private void ShowImage(int index)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            if (index == 0) pictureBox1.Visible = true;
            else if (index == 1) pictureBox2.Visible = true;
            else if (index == 2) pictureBox3.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ShowImage(0); 
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ShowImage(1); 
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                ShowImage(2);
            }
        }
    }
}
