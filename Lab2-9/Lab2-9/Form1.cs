using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
namespace Lab2_9
{
    public partial class Form1 : Form
    {
        //минуты, секунды, миллисекунды
        int min = 0, sec = 0, msec = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
            label4.Text = ":";
            label5.Text = ":";
            timer1.Interval = 1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) 
            {
                timer1.Enabled = false;
                button1.Text = "Пуск";
                button2.Enabled = true;
            }
            else 
            { 
                timer1.Enabled = true;
                button1.Text = "Стоп";
                button2.Enabled = false;
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            min = 0; sec = 0; msec = 0;
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (msec == 99)
            {
                if (sec == 59)
                {
                    if (min == 59) min = 0;
                    else min++;
                    sec = 0;
                }
                else sec++;
                msec = 0;
            }
            else msec++;
            if (min.ToString().Length == 1)
            label1.Text = "0" + min.ToString();
            else label1.Text = min.ToString();
            if (sec.ToString().Length == 1)
                label2.Text = "0" + sec.ToString();
            else label2.Text = sec.ToString();
            if (msec.ToString().Length == 1)
                label3.Text = "0" + msec.ToString();
            else label3.Text = msec.ToString();
            if (msec == 1)
            { label4.Text = ":"; label5.Text = ":"; }
            if (msec == 50)
            { label4.Text = ""; label5.Text = ""; }
        }
    }
}
