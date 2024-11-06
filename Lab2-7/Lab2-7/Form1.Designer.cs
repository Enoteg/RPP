namespace Lab2_7
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(41, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Сумма";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(41, 63);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Разность";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(41, 88);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(104, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Произведение";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Click += radioButton3_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(41, 113);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(70, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Частное";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.Click += radioButton4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(374, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 28);
            label1.Name = "label1";
            label1.Size = new Size(186, 15);
            label1.TabIndex = 6;
            label1.Text = "Задайте два числовых значения:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 298);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Location = new Point(270, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(173, 160);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите действие";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Арифметические действия";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
    }
}
