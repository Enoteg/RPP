using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = 0, sum;
            switch (comboBox1.SelectedIndex)
            {
                case 0: c = 18.9; break;
                case 1: c = 20.3; break;
                case 2: c = 22; break;
                case 3: c = 17.6; break;
            }
            sum = Convert.ToDouble(numericUpDown1.Value) * c;
            label3.Text = "К оплате " + sum.ToString("C");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
