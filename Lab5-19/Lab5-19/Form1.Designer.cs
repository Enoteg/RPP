namespace Lab5_19
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
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 24);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Right;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(122, 19);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 19);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(229, 269);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(294, 23);
            progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 96);
            label1.Name = "label1";
            label1.Size = new Size(221, 15);
            label1.TabIndex = 3;
            label1.Text = "Угадайте задуманное число от 1 до 999";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 221);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(progressBar1);
            Controls.Add(statusStrip1);
            Name = "Form1";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Label label1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Label label2;
    }
}
