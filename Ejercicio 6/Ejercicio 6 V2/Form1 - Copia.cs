using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1;
        int num2;
        int result;
        int result2;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = Int32.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = Int32.Parse(textBox2.Text);
        }

        private void sum_Click(object sender, EventArgs e)
        {
            result = num1 % num2;
            result2 = num1 / num2;
            MessageBox.Show("resultado :" + result2.ToString() + "\nresto:" + result.ToString());
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}