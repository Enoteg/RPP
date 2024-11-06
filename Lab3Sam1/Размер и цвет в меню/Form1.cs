namespace Размер_и_цвет_в_меню
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void крупныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 30);
        }

        private void среднийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 20);
        }

        private void мелкийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 10);
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void жёлтыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Yellow;
        }

        private void зелёныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
        }
    }
}
