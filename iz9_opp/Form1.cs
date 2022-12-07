using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iz9_opp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int a = Convert.ToInt32(textBox3.Text);
            int f = Convert.ToInt32(textBox4.Text);
            int k = Convert.ToInt32(textBox7.Text);
            int n = Convert.ToInt32(textBox8.Text);
            double res = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < k; j++)
                {
                    res += (Math.Pow(a, i - 1) * Math.Pow(x, i) + Math.Pow(f, j) * Math.Pow(y, i)) / ((i + 1) * j);
                }
            }
            int ress = Convert.ToInt32(res);
            textBox5.Text = Convert.ToString(ress, 10);
            textBox6.Text = Convert.ToString(ress, 2);
            textBox9.Text = Convert.ToString(ress, 8);
            textBox10.Text = Convert.ToString(ress, 16);
        }
    }
}
