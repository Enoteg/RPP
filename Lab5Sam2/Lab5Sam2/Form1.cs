namespace Lab5Sam2
{
 public partial class Form1 : Form
    {
        DateTime d0, d1, d2;
        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            d1 = dateTimePicker1.Value;
            d2 = dateTimePicker2.Value;
            for (DateTime date = d1; date <= d2; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                { if (date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        String d0 = " суббота";
                        label4.Text = label4.Text + date.ToLongDateString() + d0 + "\n";
                    }
                    else
                    {
                        String d0 = " воскресенье";
                        label4.Text = label4.Text + date.ToLongDateString() + d0 + "\n";
                    }
                }
            }



        }
    }
}
