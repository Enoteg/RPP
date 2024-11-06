namespace Lab5_20
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 58);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите текст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 288);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 323);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(370, 288);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 323);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 357);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 5;
            label6.Text = "Найти";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 76);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 120);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(580, 75);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 7;
            button1.Text = "Задать шрифт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(580, 124);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 8;
            button2.Text = "Задать фон";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(195, 228);
            button3.Name = "button3";
            button3.Size = new Size(264, 46);
            button3.TabIndex = 9;
            button3.Text = "Обработать выделенный фрагмент текста";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(580, 349);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "Поиск";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(580, 404);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 11;
            button5.Text = "Выход";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(195, 203);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(137, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Выделить весь текст";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 350);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 23);
            textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(checkBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
    }
}
