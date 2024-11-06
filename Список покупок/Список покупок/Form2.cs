using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Список_покупок
{
    public partial class Form2 : Form
    {
        public string a;
        public double b;
        public int c = 1;
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = textBox1.Text;
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToInt32(textBox3.Text);
                this.Close();
            }
            catch 
            { 
                MessageBox.Show("Проверьте коректность данных", "Внимание!"); 
            }
        }
    }
}
