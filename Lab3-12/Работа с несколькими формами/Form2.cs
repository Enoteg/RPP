using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_несколькими_формами
{
    public partial class Form2 : Form
    {
        public double a, b;
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.a = Convert.ToDouble(textBox1.Text);
                this.b = Convert.ToDouble(textBox2.Text);
                this.Close();
            }
            catch { MessageBox.Show("Проверьте корректность данных", "Внимание!"); }
        }
    }
}
