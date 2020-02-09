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

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, .1, 0.05, 0.01 };
            double cantidad = double.Parse(TxtCantidad.Text);
            sbyte n = 0;
            String respuesta = "Respuesta: \n";

            foreach (double denominacion in denominaciones)
            {
                while ( denominacion <= Math.Round(cantidad,2) )
                {
                    n++;
                    cantidad -= denominacion;
                }
                if (n > 0)
                {
                    respuesta += n + (denominacion > 1 ? " Billetes de uno " : " Monedas de ") + denominacion + " \n";
                }
                n = 0;
            }
            LblRespuesta.Text = respuesta;
        }

        private void BtnFibonucci_Click(object sender, EventArgs e)
        {
            int w, x, y, z, num;
            w = 0;
            x = 1;
            LisBox1.Items.Add(w);
            LisBox1.Items.Add(x);
            num = Convert.ToInt32(TxtCantidad.Text);

            for (z = 3; z <= num; z++)
            {
                y = w + x;
                LisBox1.Items.Add(y);
                w = x;
                x = y;
            }

        }

        private void BtnPrimo_Click(object sender, EventArgs e)
        {
            sbyte a, b, E = 0;
            a = sbyte.Parse(TxtCantidad.Text);
            for (b = 1; b <= a; b++)
                {
                if (a % b == 0)
                {
                    E++;
                }
                }
            if(E != 2)
            {
                LblRespuesta.Text = "El numero no es primo";
            }
            else
            {
                LblRespuesta.Text = "El numero es primo";
            }

      
        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            LblRespuesta.Text = "";
            LisBox1.Items.Clear();
            TxtCantidad.Text = "";
        }
    }
}
