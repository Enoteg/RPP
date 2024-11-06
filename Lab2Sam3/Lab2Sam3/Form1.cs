using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab2Sam3;
    public partial class Form1 : Form
    {
        private int countdownValue = 10; // Начальное значение обратного отсчета

        public Form1()
        {
            InitializeComponent();

            // Изначально показываем начальное значение на форме
            label1.Text = countdownValue.ToString();

            // Настройка Timer: интервал в 1 секунду (1000 миллисекунд)
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            // Таймер не запущен изначально
            timer1.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Уменьшаем значение счетчика
            countdownValue--;

            if (countdownValue >= 0)
            {
                // Обновляем текст Label для отображения текущего значения
                label1.Text = countdownValue.ToString();
            }
            else
            {
                // Когда счетчик достигнет -1, останавливаем таймер и показываем "Пуск!"
                timer1.Stop();
                label1.Text = "Пуск!";
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Устанавливаем начальное значение счётчика
            countdownValue = 10;
            label1.Text = countdownValue.ToString();

            // Запускаем таймер
            timer1.Start();
        }
    }

