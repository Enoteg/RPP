namespace Успеваемость_студентов
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewComboBoxColumn();
            Column3 = new DataGridViewCheckBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            Column5 = new DataGridViewCheckBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(277, 415);
            button1.Name = "button1";
            button1.Size = new Size(213, 23);
            button1.TabIndex = 0;
            button1.Text = "Обработать данные";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(424, 30);
            label1.TabIndex = 1;
            label1.Text = "Успеваемость студентов по Объекто ориентируемому программированию\r\n\r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(82, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(682, 150);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ФИО";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Группа";
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            Column3.FalseValue = "0";
            Column3.HeaderText = "Лабораторная 1";
            Column3.IndeterminateValue = "0";
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            Column3.TrueValue = "1";
            // 
            // Column4
            // 
            Column4.FalseValue = "0";
            Column4.HeaderText = "Лабораторная 2";
            Column4.IndeterminateValue = "0";
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            Column4.TrueValue = "1";
            // 
            // Column5
            // 
            Column5.FalseValue = "0";
            Column5.HeaderText = "Лабораторная 3";
            Column5.IndeterminateValue = "0";
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            Column5.TrueValue = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 373);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewComboBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewCheckBoxColumn Column5;
        private Label label2;
    }
}
