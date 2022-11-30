using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bcalcular_Click(object sender, EventArgs e)
        {
            
            int num1 = Int32.Parse(Tinicial.Text);
            int num2 = Int32.Parse(Tporcentaje.Text);
            
            int por = (num1 * num2) / 100;
            int res = por + num1;
            
            Lfinal.Text = res.ToString();
        }
    }
}
