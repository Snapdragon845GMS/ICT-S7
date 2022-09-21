using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo. Este es mi primer programa en C#");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo. Este es mi primer programa en C#");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
