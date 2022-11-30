using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definimos nuestras variables
            int num1 = Int32.Parse(Teuros.Text);
            //hacemos la conversion a pesetas
            double res = num1 * 166.368;
            Tpesetas.Text = res.ToString();
        }

        private void Beuros_Click(object sender, EventArgs e)
        {
            //definimos nuestras variables
            int num2 = Int32.Parse(Tpesetas.Text);
            //hacemos la conversion a pesetas
            double res = num2 / 166.368;
            Teuros.Text = res.ToString();
        }
    }
}
