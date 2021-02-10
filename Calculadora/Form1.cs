using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class calculadora : Form
    {
        private double numeroUno = 0;
        private double numeroDos = 0;
        private char opcion;

        public calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }
        private void boton_AC_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }
        private void boton_signo_Click(object sender, EventArgs e)
        {
            if (!pantalla.Text.Contains(""))
            {
                numeroUno = double.Parse(pantalla.Text) * -1;
                pantalla.Text = numeroUno.ToString();
            }
            else
            {
                pantalla.Text = "-";
            }

        }
        private void boton_porciento_Click(object sender, EventArgs e)
        {
            numeroUno = double.Parse(pantalla.Text);
            pantalla.Text = (numeroUno / 100).ToString();
        }
        private void boton_division_Click(object sender, EventArgs e)
        {
            opcion = 'd';
            numeroUno = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void boton_siete_Click(object sender, EventArgs e)
        {
            pantalla.Text += "7";
            
        }

        private void boton_ocho_Click(object sender, EventArgs e)
        {
            pantalla.Text += "8";
        }

        private void boton_nueve_Click(object sender, EventArgs e)
        {
            pantalla.Text += "9";
        }

        private void boton_multiplicacion_Click(object sender, EventArgs e)
        {
            opcion = 'm';
            numeroUno = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
        private void boton_cuatro_Click(object sender, EventArgs e)
        {
            pantalla.Text += "4";
        }
        private void boton_cinco_Click(object sender, EventArgs e)
        {
            pantalla.Text += "5";
        }

        private void boton_seis_Click(object sender, EventArgs e)
        {
            pantalla.Text += "6";
        }
        private void boton_resta_Click(object sender, EventArgs e)
        {
            opcion = 'r';
            numeroUno = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
        private void boton_uno_Click(object sender, EventArgs e)
        {
            pantalla.Text += "1";
        }

        private void boton_dos_Click(object sender, EventArgs e)
        {
            pantalla.Text += "2";
        }
        private void boton_tres_Click(object sender, EventArgs e)
        {
            pantalla.Text += "3";
        }
        private void boton_suma_Click(object sender, EventArgs e)
        {
            opcion = 's';
            numeroUno = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void boton_cero_Click(object sender, EventArgs e)
        {
            pantalla.Text += "0";
        }

        private void boton_punto_Click(object sender, EventArgs e)
        {
            if (!pantalla.Text.Contains('.'))
            {
                pantalla.Text += ".";
            }
        }

        private void boton_resultado_Click(object sender, EventArgs e)
        {
            double resultado;
            numeroDos = double.Parse(pantalla.Text);
            switch (opcion)
            {
                case 'd':
                    resultado = numeroUno / numeroDos;
                    pantalla.Text = "HOLA";
                    break;
                case 'r':
                    resultado = numeroUno - numeroDos;
                    pantalla.Text = resultado.ToString();
                    break;
                case 's':
                    resultado = numeroUno + numeroDos;
                    pantalla.Text = resultado.ToString();
                    break;
                case 'm':
                    resultado = numeroUno * numeroDos;
                    pantalla.Text = resultado.ToString();
                    break;
            }
        }
    }
}
