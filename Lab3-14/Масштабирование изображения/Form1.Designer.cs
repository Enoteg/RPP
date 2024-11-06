namespace Масштабирование_изображения
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
            trackBar1 = new TrackBar();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(173, 54);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(308, 45);
            trackBar1.TabIndex = 0;
            trackBar1.TickFrequency = 10;
            toolTip1.SetToolTip(trackBar1, "Выберите масштаб изображения");
            trackBar1.Value = 50;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.spinning_tomato_tomato;
            pictureBox1.Location = new Point(173, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(568, 54);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Label label1;
    }
}
