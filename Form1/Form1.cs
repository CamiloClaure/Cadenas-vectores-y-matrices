using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] n = new int[5, 3];
            int dP = 1, dS = 1, D = 1, dP1 = 1, dP2 = 1, dS1 = 1, dS2 = 1;
            n[0, 0] = int.Parse(textBox1.Text);
            n[0, 1] = int.Parse(textBox2.Text);
            n[0, 2] = int.Parse(textBox3.Text);
            n[3, 0] = int.Parse(textBox1.Text);
            n[3, 1] = int.Parse(textBox2.Text);
            n[3, 2] = int.Parse(textBox3.Text);
            n[1, 0] = int.Parse(textBox4.Text);
            n[1, 1] = int.Parse(textBox5.Text);
            n[1, 2] = int.Parse(textBox6.Text);
            n[4, 0] = int.Parse(textBox4.Text);
            n[4, 1] = int.Parse(textBox5.Text);
            n[4, 2] = int.Parse(textBox6.Text);
            n[2, 0] = int.Parse(textBox7.Text);
            n[2, 1] = int.Parse(textBox8.Text);
            n[2, 2] = int.Parse(textBox9.Text);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        dP = dP * n[i, j];

                    }
                    else if (i - j == 1)
                    {
                        dP1 = dP1 * n[i, j];
                    }
                    else if (i - j == 2)
                    {
                        dP2 = dP2 * n[i, j];

                    }

                }
                Console.WriteLine(dP);
             


            }
        }
    }
}
