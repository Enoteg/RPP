using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab2Sam3;
    public partial class Form1 : Form
    {
        private int countdownValue = 10; // ��������� �������� ��������� �������

        public Form1()
        {
            InitializeComponent();

            // ���������� ���������� ��������� �������� �� �����
            label1.Text = countdownValue.ToString();

            // ��������� Timer: �������� � 1 ������� (1000 �����������)
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            // ������ �� ������� ����������
            timer1.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // ��������� �������� ��������
            countdownValue--;

            if (countdownValue >= 0)
            {
                // ��������� ����� Label ��� ����������� �������� ��������
                label1.Text = countdownValue.ToString();
            }
            else
            {
                // ����� ������� ��������� -1, ������������� ������ � ���������� "����!"
                timer1.Stop();
                label1.Text = "����!";
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ������������� ��������� �������� ��������
            countdownValue = 10;
            label1.Text = countdownValue.ToString();

            // ��������� ������
            timer1.Start();
        }
    }

