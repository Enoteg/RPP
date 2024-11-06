namespace Поиск_максимума_и_минимума_в_таблице
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(241, 46);
            label1.Name = "label1";
            label1.Size = new Size(278, 21);
            label1.TabIndex = 0;
            label1.Text = "Нахождение максимума и минимума";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(604, 146);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Найти максимум";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(604, 212);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(117, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Найти минимум";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(157, 334);
            button1.Name = "button1";
            button1.Size = new Size(279, 23);
            button1.TabIndex = 3;
            button1.Text = "Заполнить таблицу случайными числами";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(542, 334);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Работа с матрицами";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
    }
}
