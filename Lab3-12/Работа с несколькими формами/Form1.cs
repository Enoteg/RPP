namespace Работа_с_несколькими_формами
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            label1.Text = "Сумма равна " + Convert.ToString(f2.a + f2.b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
