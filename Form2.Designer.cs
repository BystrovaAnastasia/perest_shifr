namespace Lab2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.перестановкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.усложненнаяПоМаршрутамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методомГаммированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Перестановка по маршруту";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перестановкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(353, 24);
            this.menuStrip1.TabIndex = 10;
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
            this.простаяToolStripMenuItem.Click += new System.EventHandler(this.простаяToolStripMenuItem_Click);
            // 
            // усложненнаяПоМаршрутамToolStripMenuItem
            // 
            this.усложненнаяПоМаршрутамToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.усложненнаяПоМаршрутамToolStripMenuItem.Name = "усложненнаяПоМаршрутамToolStripMenuItem";
            this.усложненнаяПоМаршрутамToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.усложненнаяПоМаршрутамToolStripMenuItem.Text = "Усложненная по маршрутам";
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 312);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem перестановкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem простаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem усложненнаяПоМаршрутамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методомГаммированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сПомощьюАналитическихПреобразованийToolStripMenuItem;
    }
}