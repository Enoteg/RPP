namespace Сортировка_массива
{
    public partial class Form1 : Form
    {
        int[] Mas;
        int i;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mas = new int[10];
            Random n = new Random();
            for (i = 0; i < 10; i++)
                Mas[i] = n.Next();
            foreach (int elem in Mas)
                label1.Text = label1.Text + elem + " ";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Sort(Mas);
                label2.Text = "";
                foreach (int elem in Mas)
                    label2.Text = label2.Text + elem + " ";
            }
            catch { label2.Text = "Вы ещё не заполнили массив данными!"; }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Sort(Mas);
                Array.Reverse(Mas);
                label2.Text = "";
                foreach (int elem in Mas)
                    label2.Text = label2.Text + elem + " ";
            }
            catch { label2.Text = "Вы ещё не заполнили массив данными!"; }
        }
    }
}
