﻿namespace Lab2
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.перестановкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.усложненнаяПоМаршрутамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методомГаммированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перестановкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 11;
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
            this.усложненнаяПоМаршрутамToolStripMenuItem.Click += new System.EventHandler(this.усложненнаяПоМаршрутамToolStripMenuItem_Click);
            // 
            // методомГаммированияToolStripMenuItem
            // 
            this.методомГаммированияToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.методомГаммированияToolStripMenuItem.Name = "методомГаммированияToolStripMenuItem";
            this.методомГаммированияToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.методомГаммированияToolStripMenuItem.Text = "Методом гаммирования";
            // 
            // сПомощьюАналитическихПреобразованийToolStripMenuItem
            // 
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem.Name = "сПомощьюАналитическихПреобразованийToolStripMenuItem";
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem.Text = "С помощью аналитических преобразований";
            this.сПомощьюАналитическихПреобразованийToolStripMenuItem.Click += new System.EventHandler(this.сПомощьюАналитическихПреобразованийToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Гаммирование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(223, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Гамма";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(281, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(281, 109);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(151, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(281, 188);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(151, 20);
            this.textBox6.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ASCII коды";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Таблица ASCII символов";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(201, 227);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(231, 13);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://autoit-script.ru/docs/appendix/ascii.htm";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 284);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem перестановкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem простаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem усложненнаяПоМаршрутамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методомГаммированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сПомощьюАналитическихПреобразованийToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}