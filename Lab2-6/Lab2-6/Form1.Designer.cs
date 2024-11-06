namespace Lab2_6
{
    partial class Кафе
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(165, 86);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Сэндвич";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(165, 135);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(114, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Картофель-фри";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(165, 183);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(53, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Соус";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(386, 86);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(47, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Чай";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(386, 135);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(55, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Кофе";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(386, 183);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(80, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Coca-cola";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(155, 240);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(124, 19);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Дисконтная карта";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(386, 229);
            button1.Name = "button1";
            button1.Size = new Size(93, 39);
            button1.TabIndex = 7;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 51);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 8;
            label1.Text = "Ваш заказ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 353);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 9;
            label2.Click += label2_Click;
            // 
            // Кафе
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Кафе";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
