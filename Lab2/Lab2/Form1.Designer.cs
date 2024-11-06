namespace Lab2
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 97);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Количество литров";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 162);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Вид топлива";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Аи-92", "Аи-95", "Аи-98", "ДТ" });
            comboBox1.Location = new Point(362, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(262, 235);
            button1.Name = "button1";
            button1.Size = new Size(172, 40);
            button1.TabIndex = 4;
            button1.Text = "Рассчитать сумму";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 313);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(363, 95);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Автозаправка";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private Label label3;
        private NumericUpDown numericUpDown1;
    }
}
