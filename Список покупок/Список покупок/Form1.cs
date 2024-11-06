using System.Diagnostics.Metrics;

namespace Список_покупок
{
    public partial class Form1 : Form
    {
        int coun = 1;
        double sum;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            coun = 1;
            sum = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            label1.Text += coun + ") " + form2.a + " " + form2.b.ToString("C") + " (" + form2.c + "шт)" + "\n";
            coun++;
            sum += form2.b * form2.c;
            label2.Text = "Итог: " + sum;
        }
    }
}
