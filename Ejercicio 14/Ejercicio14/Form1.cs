using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox1.Text);

            bool res = num1 != num2;
            label3.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox1.Text);

            bool res = num1 == num2;
            label3.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox1.Text);

            bool res = num1 < num2;
            label3.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox1.Text);

            bool res = num1 > num2;
            label3.Text = res.ToString();
        }
    }
}
