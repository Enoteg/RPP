using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
namespace Lab5_21
{
    public partial class Form1 : Form
    {
        DateTime d0, d1, d2;
        int t = 100; // Степень прозрачности формы
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = false;
            timer1.Interval = 500;
            timer1.Interval = 50;
            label1.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            d0 = DateTime.Now;
            label1.Text = "Today is" + Convert.ToString(d0.DayOfWeek)
            + " " + Convert.ToString(d0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "";
                d1 = dateTimePicker1.Value;
                for (int i = 1; i < 9; i++)
                {
                    label4.Text = label4.Text +
               d1.ToLongDateString() + "\n";
                    d1 = d1.AddDays(14);
                }
                d2 = Convert.ToDateTime(maskedTextBox1.Text);
                label5.Text = "Время занятий: " + maskedTextBox1.Text +
                "-"
                + d2.AddHours(3).AddMinutes(10).ToShortTimeString();
            }
            catch
            {
                MessageBox.Show("Проверьте корректность входных данных!");}
           }
private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
 }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (t != 0)
            {
                this.Opacity = (float)t / 100;
                this.Refresh();
                t--;
            }
            else this.Close();
        }
    }
}
