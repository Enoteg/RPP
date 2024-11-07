namespace Lab5Sam3
{
    public partial class Form1 : Form
    { public int p = 0;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.HideSelection = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            String todayString = today.ToString("dd.MM.yyyy");
            int index = richTextBox1.Text.IndexOf(todayString);
            if (richTextBox1.Text.IndexOf(todayString, p) >= 0)
            {
                if (p <= richTextBox1.Text.Length)
                {
                    richTextBox1.SelectionStart =
               richTextBox1.Text.IndexOf(todayString, p);
                    richTextBox1.SelectionLength = todayString.Length;
                    p = richTextBox1.SelectionStart + 1;
                }
            }
            else
            {
                MessageBox.Show("Поиск не дал результатов");

                p = 0;
            }
        }
    }
}
