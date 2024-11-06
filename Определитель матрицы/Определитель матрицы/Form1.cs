namespace Определитель_матрицы
{
    public partial class Form1 : Form
    {
        const int n = 3;
        const int m = 3;
        int part1;
        int part2;
        int[] temp;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            dataGridView1.BackgroundColor = this.BackColor;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = m;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Width = 200;
            dataGridView1.Height = 100;
            dataGridView1.Font = new Font("Arial", 14);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            temp = new int[9];
            Random r = new Random();
            for (int i = 0; i < 9; i++)
                temp[i] = r.Next(-100, 100);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = temp[index];
                    index++;
                }
            part1 = (temp[0] * temp[4] * temp[8]) + (temp[1] * temp[5] * temp[6]) + (temp[2] * temp[3] * temp[7]);
            part2 = (temp[2] * temp[4] * temp[6]) + (temp[0] * temp[5] * temp[7]) + (temp[1] * temp[3] * temp[8]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = $"Определитель данной матрицы равен {part1 - part2}";
        }
    }
}
