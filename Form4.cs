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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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

        private void методомГаммированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            this.Hide();
            if (newForm3.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            richTextBox1.Text = "";
            richTextBox2.Text = "";
            textBox3.Text = "";

            int n = Convert.ToInt32(textBox1.Text);

            int[,] A = new int[n,n];
            

            String Str = textBox2.Text;

            int L = Str.Length;

            int z = L / n;
            int d = L % n;

            if (d != 0)
            {
                z++;
                for (int i = 0; i < 8 - d; i++)
                {
                    Str += "*";
                }
            }

            byte[,] temp = new byte[z, n];
            int[,] C = new int[z, n];

            int s = 0;

            //разбили Str на блоки по n символов

            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp[i, j] = (byte)Str[s];
                    textBox3.Text += temp[i, j] + " ";
                    s++;
                }
            }

            //создали невырожденную мартицу

            int[][] B = new int[1][];
            B[0] = new int[n];


            double det = 1;
            const double EPS = 1E-9;

            while (det != 0)
            {
                Random random = new Random();
                int rand;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        rand = random.Next(0, 100);
                        A[i, j] = rand;
                    }
                }

                for (int i = 0; i < n; ++i)
                {
                    int k = i;
                    for (int j = i + 1; j < n; ++j)
                        if (Math.Abs(A[j, i]) > Math.Abs(A[k, i]))
                            k = j;
                    if (Math.Abs(A[k, i]) < EPS)
                    {
                        det = 0;
                        //break;
                    }
                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    richTextBox1.Text += A[i, j] + " ";
                }
                richTextBox1.Text += "\n";
            }


            for (int r = 0; r < z; r++) {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        C[r, i] += A[i,j]*temp[r,j];
                    }
                }
            }

            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    richTextBox2.Text += Convert.ToString(C[i, j]) + " ";
                }
                richTextBox2.Text += "\n";
            }

        }
    }
}
