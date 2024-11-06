namespace Работа_с_меню
{
    public partial class Form1 : Form
    {
        public double k1, k2;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }



        private void загрузитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            k1 = f2.a;
            k2 = f2.b;
            операцияToolStripMenuItem.Enabled = true;
        }

        private void суммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Сумма равна " + Convert.ToString(k1 + k2);
        }

        private void разностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Разность равна " + Convert.ToString(k1 - k2);
        }

        private void произведениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Произведение равно " + Convert.ToString(k1 * k2);
        }

        private void частноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (k2 != 0)
                label1.Text = "Частное равно " + Convert.ToString(k1 / k2);
            else label1.Text = "На ноль делить нельзя!";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void информацияОРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            операцияToolStripMenuItem.Enabled = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
