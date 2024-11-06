namespace Lab5_22
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            treeView1 = new TreeView();
            label1 = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(312, 70);
            button1.Name = "button1";
            button1.Size = new Size(156, 24);
            button1.TabIndex = 0;
            button1.Text = "Выбрать каталог";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(492, 70);
            button2.Name = "button2";
            button2.Size = new Size(208, 24);
            button2.TabIndex = 1;
            button2.Text = "Обработать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(557, 482);
            button3.Name = "button3";
            button3.Size = new Size(143, 25);
            button3.TabIndex = 2;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 3;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(31, 114);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(437, 351);
            treeView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 96);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 6;
            label1.Text = "Структура каталога:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 97);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 7;
            label2.Text = "Файлы:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(492, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(217, 349);
            listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TreeView treeView1;
        private Label label1;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private ListBox listBox1;
    }
}
