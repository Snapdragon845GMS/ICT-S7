using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Boperar_Click(object sender, EventArgs e)
        {
            //leemos las variables iniciales
            int num1 = Int32.Parse(Tnum1.Text);
            int num2 = Int32.Parse(Tnum2.Text);
            int num3 = Int32.Parse(Tnum3.Text);

            //operamos con las variables
            int sum = num1 + num2 + num3;
            int mult = num1 * num2 * num3;

            //mostramos cada operacion en su label
            Lsuma.Text = sum.ToString();
            Lmultiplicacion.Text = mult.ToString();
        
        }
    }
}
