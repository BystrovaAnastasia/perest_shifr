namespace Lab2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.перестановкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.усложненнаяПоМаршрутамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методомГаммированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(41, 121);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(195, 163);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(41, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "m";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(41, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(41, 320);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(195, 20);
            this.textBox5.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Простая перестановка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перестановкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // перестановкаToolStripMenuItem
            // 
            this.перестановкаToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.перестановкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.простаяToolStripMenuItem,
            this.усложненнаяПоМаршрутамToolStripMenuItem,
            this.методомГаммированияToolStripMenuItem,
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem});
            this.перестановкаToolStripMenuItem.Name = "перестановкаToolStripMenuItem";
            this.перестановкаToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.перестановкаToolStripMenuItem.Text = "Перестановка";
            // 
            // простаяToolStripMenuItem
            // 
            this.простаяToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.простаяToolStripMenuItem.Name = "простаяToolStripMenuItem";
            this.простаяToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.простаяToolStripMenuItem.Text = "Простая";
            // 
            // усложненнаяПоМаршрутамToolStripMenuItem
            // 
            this.усложненнаяПоМаршрутамToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.усложненнаяПоМаршрутамToolStripMenuItem.Name = "усложненнаяПоМаршрутамToolStripMenuItem";
            this.усложненнаяПоМаршрутамToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.усложненнаяПоМаршрутамToolStripMenuItem.Text = "Усложненная по маршрутам";
            this.усложненнаяПоМаршрутамToolStripMenuItem.Click += new System.EventHandler(this.усложненнаяПоМаршрутамToolStripMenuItem_Click);
            // 
            // методомГаммированияToolStripMenuItem
            // 
            this.методомГаммированияToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.методомГаммированияToolStripMenuItem.Name = "методомГаммированияToolStripMenuItem";
            this.методомГаммированияToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.методомГаммированияToolStripMenuItem.Text = "Методом гаммирования";
            this.методомГаммированияToolStripMenuItem.Click += new System.EventHandler(this.методомГаммированияToolStripMenuItem_Click);
            // 
            // сПомощьюАналитическихПреобразованийToolStripMenuItem
            // 
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem.Name = "сПомощьюАналитическихПреобразованийToolStripMenuItem";
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem.Text = "С помощью аналитических преобразований";
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem.Click += new System.EventHandler(this.сПомощьюАналитическихПреобразованийToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem перестановкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem простаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem усложненнаяПоМаршрутамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методомГаммированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сПомощьюАналитическихПреобразованийToolStripMenuItem;
    }
}

