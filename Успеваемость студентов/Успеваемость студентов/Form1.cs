using System.Diagnostics.Metrics;

namespace Успеваемость_студентов
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            label2.Text = "";

            ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]).Items.AddRange(new string[] { "ИС-31", "ИС-32" });
            dataGridView1.BackgroundColor = this.BackColor;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.Width = 700;
            dataGridView1.Height = 160;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, counter1 = 0, counter2 = 0;
            if (dataGridView1.ColumnCount == 5)
            {
                dataGridView1.Columns.Add("Column5", "Допуск к экзамену");
                dataGridView1.Columns[5].Width = 140;
            }
            for (i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) != 0 && Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) != 0 && Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) != 0)
                {
                    dataGridView1.Rows[i].Cells[5].Value = "Допущен";
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.MistyRose;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[5].Value = ""; dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }

            for (i = 0; i < (dataGridView1.RowCount - 1); i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value == null)
                {
                    MessageBox.Show($"Выберите группу для студента номер {i + 1}", "Внимание");
                }
                else if (dataGridView1.Rows[i].Cells[5].Value == "Допущен" && dataGridView1.Rows[i].Cells[1].Value.ToString() == "ИС-31")
                {
                    counter1++;
                }
                else if (dataGridView1.Rows[i].Cells[5].Value == "Допущен" && dataGridView1.Rows[i].Cells[1].Value.ToString() == "ИС-32")
                {
                    counter2++;
                }
            }
            label2.Text = $"Кол-во допущенных из ИС-31: {counter1} \nКол-во допущенных из ИС-32: {counter2}";
            }
        }

    }
