using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2Sam1
{
    public partial class Form1 : Form
    {
        private double carpetPrice = 300;    
        private double linoleumPrice = 200;  
        private double parquetPrice = 500;   
        private double deliveryCost = 500;   

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double length = Convert.ToDouble(textBox1.Text);
                double width = Convert.ToDouble(textBox2.Text);

                double area = length * width;

                double pricePerSquareMeter = 0;
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "��������":
                        pricePerSquareMeter = carpetPrice;
                        break;
                    case "��������":
                        pricePerSquareMeter = linoleumPrice;
                        break;
                    case "������":
                        pricePerSquareMeter = parquetPrice;
                        break;
                }

                double totalCost = area * pricePerSquareMeter;

                if (checkBox1.Checked)
                {
                    totalCost += deliveryCost;
                }

                label3.Text = $"� ������: {totalCost} �.";
            }
            catch (FormatException)
            {
                MessageBox.Show("����������, ������� ���������� �������� ��� ����� � ������.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
