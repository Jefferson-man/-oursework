namespace Курсач
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.size_Array = new System.Windows.Forms.TextBox();
            this.Button_general_array = new System.Windows.Forms.Button();
            this.Button_sort = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radio_Bubble_sort = new System.Windows.Forms.RadioButton();
            this.radio_Quick_sort = new System.Windows.Forms.RadioButton();
            this.Button_array_to_File = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Buttom_WriteArrayToFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // size_Array
            // 
            this.size_Array.Location = new System.Drawing.Point(312, 189);
            this.size_Array.Name = "size_Array";
            this.size_Array.Size = new System.Drawing.Size(182, 27);
            this.size_Array.TabIndex = 1;
            this.size_Array.Text = " Розмір масиву";
            this.size_Array.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button_general_array
            // 
            this.Button_general_array.Location = new System.Drawing.Point(339, 222);
            this.Button_general_array.Name = "Button_general_array";
            this.Button_general_array.Size = new System.Drawing.Size(131, 57);
            this.Button_general_array.TabIndex = 3;
            this.Button_general_array.Text = "Згенерувати масив";
            this.Button_general_array.UseVisualStyleBackColor = true;
            this.Button_general_array.Click += new System.EventHandler(this.Button_general_array_Click);
            // 
            // Button_sort
            // 
            this.Button_sort.Location = new System.Drawing.Point(657, 218);
            this.Button_sort.Name = "Button_sort";
            this.Button_sort.Size = new System.Drawing.Size(131, 57);
            this.Button_sort.TabIndex = 4;
            this.Button_sort.Text = "Сортувати";
            this.Button_sort.UseVisualStyleBackColor = true;
            this.Button_sort.Click += new System.EventHandler(this.Button_sort_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 109);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.TabStop = false;
            // 
            // radio_Bubble_sort
            // 
            this.radio_Bubble_sort.AutoSize = true;
            this.radio_Bubble_sort.Location = new System.Drawing.Point(540, 252);
            this.radio_Bubble_sort.Name = "radio_Bubble_sort";
            this.radio_Bubble_sort.Size = new System.Drawing.Size(111, 23);
            this.radio_Bubble_sort.TabIndex = 7;
            this.radio_Bubble_sort.TabStop = true;
            this.radio_Bubble_sort.Text = "Bubble Sort";
            this.radio_Bubble_sort.UseVisualStyleBackColor = true;
            // 
            // radio_Quick_sort
            // 
            this.radio_Quick_sort.AutoSize = true;
            this.radio_Quick_sort.Location = new System.Drawing.Point(540, 223);
            this.radio_Quick_sort.Name = "radio_Quick_sort";
            this.radio_Quick_sort.Size = new System.Drawing.Size(104, 23);
            this.radio_Quick_sort.TabIndex = 8;
            this.radio_Quick_sort.TabStop = true;
            this.radio_Quick_sort.Text = "Quick Sort";
            this.radio_Quick_sort.UseVisualStyleBackColor = true;
            // 
            // Button_array_to_File
            // 
            this.Button_array_to_File.Location = new System.Drawing.Point(12, 219);
            this.Button_array_to_File.Name = "Button_array_to_File";
            this.Button_array_to_File.Size = new System.Drawing.Size(131, 56);
            this.Button_array_to_File.TabIndex = 9;
            this.Button_array_to_File.Text = "Взяти масив з файлу";
            this.Button_array_to_File.UseVisualStyleBackColor = true;
            this.Button_array_to_File.Click += new System.EventHandler(this.Button_array_to_File_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(264, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cортування масиву";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Шлях до файлу";
            // 
            // Buttom_WriteArrayToFile
            // 
            this.Buttom_WriteArrayToFile.Location = new System.Drawing.Point(171, 223);
            this.Buttom_WriteArrayToFile.Name = "Buttom_WriteArrayToFile";
            this.Buttom_WriteArrayToFile.Size = new System.Drawing.Size(98, 48);
            this.Buttom_WriteArrayToFile.TabIndex = 15;
            this.Buttom_WriteArrayToFile.Text = "Запись в файл";
            this.Buttom_WriteArrayToFile.UseVisualStyleBackColor = true;
            this.Buttom_WriteArrayToFile.Click += new System.EventHandler(this.Button_WriteArrayToFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Записать в файл";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this.Buttom_WriteArrayToFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_array_to_File);
            this.Controls.Add(this.radio_Quick_sort);
            this.Controls.Add(this.radio_Bubble_sort);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button_sort);
            this.Controls.Add(this.Button_general_array);
            this.Controls.Add(this.size_Array);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox size_Array;
        private System.Windows.Forms.Button Button_general_array;
        private System.Windows.Forms.Button Button_sort;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radio_Bubble_sort;
        private System.Windows.Forms.RadioButton radio_Quick_sort;
        private System.Windows.Forms.Button Button_array_to_File;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buttom_WriteArrayToFile;
        private System.Windows.Forms.Label label3;
    }
}

