namespace Размер_и_цвет_в_меню
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
            menuStrip1 = new MenuStrip();
            параметрыТекстаToolStripMenuItem = new ToolStripMenuItem();
            размерШрифтаToolStripMenuItem = new ToolStripMenuItem();
            крупныйToolStripMenuItem = new ToolStripMenuItem();
            среднийToolStripMenuItem = new ToolStripMenuItem();
            мелкийToolStripMenuItem = new ToolStripMenuItem();
            цветToolStripMenuItem = new ToolStripMenuItem();
            красныйToolStripMenuItem = new ToolStripMenuItem();
            жёлтыйToolStripMenuItem = new ToolStripMenuItem();
            зелёныйToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { параметрыТекстаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // параметрыТекстаToolStripMenuItem
            // 
            параметрыТекстаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { размерШрифтаToolStripMenuItem, цветToolStripMenuItem });
            параметрыТекстаToolStripMenuItem.Name = "параметрыТекстаToolStripMenuItem";
            параметрыТекстаToolStripMenuItem.Size = new Size(120, 20);
            параметрыТекстаToolStripMenuItem.Text = "Параметры текста";
            // 
            // размерШрифтаToolStripMenuItem
            // 
            размерШрифтаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { крупныйToolStripMenuItem, среднийToolStripMenuItem, мелкийToolStripMenuItem });
            размерШрифтаToolStripMenuItem.Name = "размерШрифтаToolStripMenuItem";
            размерШрифтаToolStripMenuItem.Size = new Size(180, 22);
            размерШрифтаToolStripMenuItem.Text = "Размер шрифта";
            // 
            // крупныйToolStripMenuItem
            // 
            крупныйToolStripMenuItem.Name = "крупныйToolStripMenuItem";
            крупныйToolStripMenuItem.Size = new Size(180, 22);
            крупныйToolStripMenuItem.Text = "Крупный";
            крупныйToolStripMenuItem.Click += крупныйToolStripMenuItem_Click;
            // 
            // среднийToolStripMenuItem
            // 
            среднийToolStripMenuItem.Name = "среднийToolStripMenuItem";
            среднийToolStripMenuItem.Size = new Size(180, 22);
            среднийToolStripMenuItem.Text = "Средний";
            среднийToolStripMenuItem.Click += среднийToolStripMenuItem_Click;
            // 
            // мелкийToolStripMenuItem
            // 
            мелкийToolStripMenuItem.Name = "мелкийToolStripMenuItem";
            мелкийToolStripMenuItem.Size = new Size(180, 22);
            мелкийToolStripMenuItem.Text = "Мелкий";
            мелкийToolStripMenuItem.Click += мелкийToolStripMenuItem_Click;
            // 
            // цветToolStripMenuItem
            // 
            цветToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { красныйToolStripMenuItem, жёлтыйToolStripMenuItem, зелёныйToolStripMenuItem });
            цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            цветToolStripMenuItem.Size = new Size(180, 22);
            цветToolStripMenuItem.Text = "Цвет";
            // 
            // красныйToolStripMenuItem
            // 
            красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            красныйToolStripMenuItem.Size = new Size(123, 22);
            красныйToolStripMenuItem.Text = "Красный";
            красныйToolStripMenuItem.Click += красныйToolStripMenuItem_Click;
            // 
            // жёлтыйToolStripMenuItem
            // 
            жёлтыйToolStripMenuItem.Name = "жёлтыйToolStripMenuItem";
            жёлтыйToolStripMenuItem.Size = new Size(123, 22);
            жёлтыйToolStripMenuItem.Text = "Жёлтый";
            жёлтыйToolStripMenuItem.Click += жёлтыйToolStripMenuItem_Click;
            // 
            // зелёныйToolStripMenuItem
            // 
            зелёныйToolStripMenuItem.Name = "зелёныйToolStripMenuItem";
            зелёныйToolStripMenuItem.Size = new Size(123, 22);
            зелёныйToolStripMenuItem.Text = "Зелёный";
            зелёныйToolStripMenuItem.Click += зелёныйToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(264, 202);
            label1.Name = "label1";
            label1.Size = new Size(246, 47);
            label1.TabIndex = 1;
            label1.Text = "Добрый день!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 451);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem параметрыТекстаToolStripMenuItem;
        private ToolStripMenuItem размерШрифтаToolStripMenuItem;
        private ToolStripMenuItem крупныйToolStripMenuItem;
        private ToolStripMenuItem среднийToolStripMenuItem;
        private ToolStripMenuItem мелкийToolStripMenuItem;
        private ToolStripMenuItem цветToolStripMenuItem;
        private ToolStripMenuItem красныйToolStripMenuItem;
        private ToolStripMenuItem жёлтыйToolStripMenuItem;
        private ToolStripMenuItem зелёныйToolStripMenuItem;
        private Label label1;
    }
}
