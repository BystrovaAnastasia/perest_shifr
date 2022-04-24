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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            richTextBox1.Text = "";
            textBox5.Text = "";
            String A = textBox4.Text;
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);

            //Рандомизация ключа
            
            int[] perm = Enumerable.Range(1, m).ToArray(); 
            Random r = new Random();
            for (int i = m - 1; i >= 1; i--)
            {
                int j = r.Next(i + 1);
                int temp = perm[j];
                perm[j] = perm[i];
                perm[i] = temp;
            }

            for (int i = 0; i < perm.Length; i++)
            {
                textBox3.Text += perm[i];
            }

            //

            Char[,] prper = new Char[n,m];
            int k = 0;

            if (n*m < A.Length)
            {
                richTextBox1.Text = "!!! Длина шифруемого текста больше колчества элементов в заданной матрице !!!";
            }
            else
            {
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        if (k < A.Length)
                        {
                            prper[i, j] = A[k];
                            k++;
                            richTextBox1.Text += Convert.ToString(prper[i,j]) + " ";
                        }
                        else
                        {
                            prper[i, j] = ' ';
                            richTextBox1.Text += Convert.ToString(prper[i, j]) + " ";
                        }
                    }
                    richTextBox1.Text += "\n";
                }

                for (int d = 1; d <= m; d++)
                {
                    for (int i = 0; i < m; i++)
                    {
                        if (perm[i] == d)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                textBox5.Text += prper[j, i];
                            }
                        }
                        
                    }
                }
            }
        }

        private void усложненнаяПоМаршрутамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            this.Hide();
            if (newForm2.ShowDialog() != DialogResult.OK)
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
