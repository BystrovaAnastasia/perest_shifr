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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String A = textBox1.Text;

            textBox2.Text = "";

            int[] mar = new int[] { 4,0,2,3,1,5,7,6 };

            int L = A.Length;

            int k = L / 8;
            int d = L % 8;

            if (d != 0)
            {
                k++;

                for (int i = 0; i<8-d; i++)
                {
                    A += "*";
                }
            }

            Char[,] temp = new Char[k, 8];

            int s = 0;

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    temp[i, j] = A[s];
                    s++;
                }
            }

            Char[,] fin = new Char[k, 8];

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    fin[i, j] = temp[i, mar[j]];
                    textBox2.Text += Convert.ToString(fin[i, j]);
                }
            }



        }

        private void простаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            this.Hide();
            if (newForm1.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void методомГаммированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            this.Hide();
            if (newForm3.ShowDialog() != DialogResult.OK)
                Close();
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
