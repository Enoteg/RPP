namespace Тест
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte k = 0;
            if (radioButton1.Checked) k++;
            if (radioButton5.Checked) k++;
            if (radioButton7.Checked) k++;
            if (k == 3) MessageBox.Show("Вы верно ответили на все вопросы!", "Результат:");
            else MessageBox.Show("Вы ответили верно на " + Convert.ToString(k) + " из трёх вопросов", "Результат:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
        }
    }
}
