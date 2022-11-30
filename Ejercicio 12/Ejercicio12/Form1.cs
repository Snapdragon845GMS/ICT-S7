using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bcalcular_Click(object sender, EventArgs e)
        {
            //sumamos los tres productos
            int num1 = Int32.Parse(B1.Text);
            int num2 = Int32.Parse(B2.Text);
            int num3 = Int32.Parse(B3.Text);

            //el total a pagar sin iva
            int res = num1 + num2 + num3;
            //con iva
            double res_iva = (res * 0.21) + res;
            //lo ostramos en su Box adecuado
            Bsi.Text = res.ToString();
            Bci.Text = res_iva.ToString();

        }
    }
}
