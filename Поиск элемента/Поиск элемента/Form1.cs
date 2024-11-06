using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Поиск_элемента
{
    public partial class Form1 : Form
    {
        public int[] Mas;
        int i;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Mas = new int[10];
            Random n = new Random();
            for (int i = 0; i < 10; i++)
                Mas[i] = n.Next(100);
            foreach (int elem in Mas)
                label1.Text = label1.Text + elem + " ";
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                for (i = 0; i < Mas.Length; i++)
                {
                    if (Mas[i] == Convert.ToInt32(textBox1.Text))
                    {
                        label3.Text = $"Элемент {textBox1.Text} на позиции {i + 1}";
                        break;
                    }
                    else if (i == Mas.Length - 1)
                        label3.Text = $"Элемент {textBox1.Text} не найден";
                }
            }
            catch 
            {
                MessageBox.Show("Проверьте искомое число", "Внимание!");
            }
        }
    }
}
