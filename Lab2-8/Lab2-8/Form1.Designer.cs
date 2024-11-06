namespace Lab2_8
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(646, 29);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Котировка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(587, 65);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "USD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 97);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "EUR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 130);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Сумма";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "RUB", "USD", "EUR" });
            comboBox1.Location = new Point(405, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(621, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(621, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(292, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(292, 202);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 71);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Конвертировать в";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(188, 46);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(46, 19);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "EUR";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(97, 46);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "USD";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 46);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "RUB";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(318, 279);
            button1.Name = "button1";
            button1.Size = new Size(190, 36);
            button1.TabIndex = 9;
            button1.Text = "Расссчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 359);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(601, 371);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private Button button1;
        private Label label5;
        private Button button2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
