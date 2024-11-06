namespace Работа_с_меню
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
            menuStrip1 = new MenuStrip();
            действияToolStripMenuItem = new ToolStripMenuItem();
            загрузитьДанныеToolStripMenuItem = new ToolStripMenuItem();
            операцияToolStripMenuItem = new ToolStripMenuItem();
            суммаToolStripMenuItem = new ToolStripMenuItem();
            разностьToolStripMenuItem = new ToolStripMenuItem();
            произведениеToolStripMenuItem = new ToolStripMenuItem();
            частноеToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            информацияОРазработчикеToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 289);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { действияToolStripMenuItem, помощьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // действияToolStripMenuItem
            // 
            действияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загрузитьДанныеToolStripMenuItem, операцияToolStripMenuItem, toolStripSeparator1, выходToolStripMenuItem });
            действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            действияToolStripMenuItem.Size = new Size(70, 20);
            действияToolStripMenuItem.Text = "Действия";
            // 
            // загрузитьДанныеToolStripMenuItem
            // 
            загрузитьДанныеToolStripMenuItem.Name = "загрузитьДанныеToolStripMenuItem";
            загрузитьДанныеToolStripMenuItem.Size = new Size(172, 22);
            загрузитьДанныеToolStripMenuItem.Text = "Загрузить данные";
            загрузитьДанныеToolStripMenuItem.Click += загрузитьДанныеToolStripMenuItem_Click;
            // 
            // операцияToolStripMenuItem
            // 
            операцияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { суммаToolStripMenuItem, разностьToolStripMenuItem, произведениеToolStripMenuItem, частноеToolStripMenuItem });
            операцияToolStripMenuItem.Name = "операцияToolStripMenuItem";
            операцияToolStripMenuItem.Size = new Size(172, 22);
            операцияToolStripMenuItem.Text = "Операция";
            // 
            // суммаToolStripMenuItem
            // 
            суммаToolStripMenuItem.Name = "суммаToolStripMenuItem";
            суммаToolStripMenuItem.Size = new Size(153, 22);
            суммаToolStripMenuItem.Text = "Сумма";
            суммаToolStripMenuItem.Click += суммаToolStripMenuItem_Click;
            // 
            // разностьToolStripMenuItem
            // 
            разностьToolStripMenuItem.Name = "разностьToolStripMenuItem";
            разностьToolStripMenuItem.Size = new Size(153, 22);
            разностьToolStripMenuItem.Text = "Разность";
            разностьToolStripMenuItem.Click += разностьToolStripMenuItem_Click;
            // 
            // произведениеToolStripMenuItem
            // 
            произведениеToolStripMenuItem.Name = "произведениеToolStripMenuItem";
            произведениеToolStripMenuItem.Size = new Size(153, 22);
            произведениеToolStripMenuItem.Text = "Произведение";
            произведениеToolStripMenuItem.Click += произведениеToolStripMenuItem_Click;
            // 
            // частноеToolStripMenuItem
            // 
            частноеToolStripMenuItem.Name = "частноеToolStripMenuItem";
            частноеToolStripMenuItem.Size = new Size(153, 22);
            частноеToolStripMenuItem.Text = "Частное";
            частноеToolStripMenuItem.Click += частноеToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(169, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(172, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { информацияОРазработчикеToolStripMenuItem });
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(68, 20);
            помощьToolStripMenuItem.Text = "Помощь";
            // 
            // информацияОРазработчикеToolStripMenuItem
            // 
            информацияОРазработчикеToolStripMenuItem.Name = "информацияОРазработчикеToolStripMenuItem";
            информацияОРазработчикеToolStripMenuItem.Size = new Size(237, 22);
            информацияОРазработчикеToolStripMenuItem.Text = "Информация о разработчике";
            информацияОРазработчикеToolStripMenuItem.Click += информацияОРазработчикеToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Главная форма";
            Activated += Form1_Activated;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem действияToolStripMenuItem;
        private ToolStripMenuItem загрузитьДанныеToolStripMenuItem;
        private ToolStripMenuItem операцияToolStripMenuItem;
        private ToolStripMenuItem суммаToolStripMenuItem;
        private ToolStripMenuItem разностьToolStripMenuItem;
        private ToolStripMenuItem произведениеToolStripMenuItem;
        private ToolStripMenuItem частноеToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem информацияОРазработчикеToolStripMenuItem;
    }
}
