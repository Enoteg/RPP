namespace Lab2_6
{
    public partial class Кафе : Form
    {
        public Кафе()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (checkBox1.Checked) sum += 35;
            if (checkBox2.Checked) sum += 15;
            if (checkBox3.Checked) sum += 9;
            if (checkBox4.Checked) sum += 15;
            if (checkBox5.Checked) sum += 25;
            if (checkBox6.Checked) sum += 20;

            if (checkBox7.Checked) sum *= 0.85;
            label2.Text = "Ваш заказ на сумму " + sum.ToString("C");
        }


    }
}

