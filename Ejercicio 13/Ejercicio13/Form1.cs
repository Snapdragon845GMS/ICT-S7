using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);//horas normales
            int num2 = Int32.Parse(textBox2.Text);//horas extras
            int num3 = Int32.Parse(textBox3.Text);//paga por hora

            //calculamos horas totales, suponemos 30 dias en un mes y por lo tanto 22 dias lectivos
            int horas_totales = (num1 * num3 * 22) + (num2 * 2 * num3 * 22);
            double res = horas_totales * 0.18;

            //mostramos el resultado
            label3.Text = res.ToString();

        }
    }
}
