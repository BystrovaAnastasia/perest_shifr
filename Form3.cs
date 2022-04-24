using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String A = textBox1.Text;
            String G = textBox2.Text;

            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            if (G.Length < A.Length)
            {
                int i = 0;
                while (G.Length != A.Length)
                {
                    G += G[i];
                    i++;
                }
            }

            String[] tempA = new String[A.Length];
            String[] tempG = new String[A.Length];
            byte[] mid = new byte[A.Length];
            Char[] fin = new Char[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                tempA[i] = Convert.ToString((byte)A[i]);
                textBox4.Text += Convert.ToString(tempA[i]) + " ";
                tempG[i] = Convert.ToString((byte)G[i]);
                textBox5.Text += Convert.ToString(tempG[i]) + " ";

                mid[i] = (byte)(int.Parse(tempA[i]) ^ int.Parse(tempG[i]));

                textBox6.Text += Convert.ToString(mid[i]) + " ";

                fin[i] = (char)mid[i];

                textBox3.Text += fin[i];
            }
            
        }

        private void простаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            this.Hide();
            if (newForm1.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void усложненнаяПоМаршрутамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            this.Hide();
            if (newForm2.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void сПомощьюАналитическихПреобразованийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm4 = new Form4();
            this.Hide();
            if (newForm4.ShowDialog() != DialogResult.OK)
                Close();
        }
    }
}
