using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num1 = rnd.Next();
            int num2 = rnd.Next()
            int sum = num1 + num2;
            MessageBox.Show($"The sum of {num1} and {num2} is {sum}.");
        }
    }
}
