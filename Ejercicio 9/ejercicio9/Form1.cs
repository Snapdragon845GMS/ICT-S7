using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            //leemos las variables iniciales
            int num1 = Int32.Parse(Tnum1.Text);
            int num2 = Int32.Parse(Tnum2.Text);

            //sumamos los numeros
            int res1 = num1 + num2;

            //mostramos el resultado por pantalla
            Bres.Text = res1.ToString();
        }
        private void restar_Click(object sender, EventArgs e)
        {
            //leemos las variables iniciales
            int num1 = Int32.Parse(Tnum1.Text);
            int num2 = Int32.Parse(Tnum2.Text);

            //sumamos los numeros
            int res2 = num1 - num2;

            //mostramos el resultado por pantalla
            Bres.Text = res2.ToString();
        }

        private void mult_Click_1(object sender, EventArgs e)
        {
            //leemos las variables iniciales
            int num1 = Int32.Parse(Tnum1.Text);
            int num2 = Int32.Parse(Tnum2.Text);

            //sumamos los numeros
            int res3 = num1 * num2;

            //mostramos el resultado por pantalla
            Bres.Text = res3.ToString();
        }

        private void div_Click_1(object sender, EventArgs e)
        {
            //leemos las variables iniciales
            int num1 = Int32.Parse(Tnum1.Text);
            int num2 = Int32.Parse(Tnum2.Text);

            //sumamos los numeros
            int res4 = num1 / num2;

            //mostramos el resultado por pantalla
            Bres.Text = res4.ToString();
        }

        private void resto_Click_1(object sender, EventArgs e)
        {
            //leemos las variables iniciales
            int num1 = Int32.Parse(Tnum1.Text);
            int num2 = Int32.Parse(Tnum2.Text);

            //sumamos los numeros
            int res5 = num1 % num2;

            //mostramos el resultado por pantalla
            Bres.Text = res5.ToString();
        }
    }
}