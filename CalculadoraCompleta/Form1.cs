using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCompleta
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
    }

    public partial class Form1 : Form
    {
        double cantidad1 = 0;
        double cantidad2 = 0;
        Operacion operador = Operacion.NoDefinida;
        public Form1()
        {
            InitializeComponent();
        }

        private void LeerNumero(string numero)
        {
            if (ResultadosFin.Text == "0" && ResultadosFin.Text != null)
            {
                ResultadosFin.Text = numero;
            }
            else
            {
                ResultadosFin.Text += numero;
            }
        }

        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case Operacion.Suma:
                    resultado = cantidad1 + cantidad2;
                    break;
                case Operacion.Resta:
                    resultado = cantidad1 - cantidad2;
                    break;
                case Operacion.Division:
                    if (cantidad2 == 0)
                    {
                        MessageBox.Show("dentro de 0 no se divide");
                        resultado = 0;

                    }
                    else
                    {
                        resultado = cantidad1 / cantidad2;
                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = cantidad1 * cantidad2;
                    break;
            }

            return resultado;
        }
            
      
    

    private void botnCero_Click(object sender, EventArgs e)
        {
            if (ResultadosFin.Text == "0")
            {
                return;
            }
            else
            {
                ResultadosFin.Text += "0";
            }
        }

        private void botnUno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void botnDos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void botnTres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void botnCuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void botnCinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void botnSeis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void botnSiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void botnOcho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void botnNueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void ObtnerValor(string operador)
        {
            cantidad1 = Convert.ToDouble(ResultadosFin.Text);
            lablHistorial.Text = ResultadosFin.Text + operador;
            ResultadosFin.Text = "0";
        }

        private void botnSuma_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtnerValor("+");
            
        }

        private void botnIgual_Click(object sender, EventArgs e)
        {
            if (cantidad2 == 0)
            {
                cantidad2 = Convert.ToDouble(ResultadosFin.Text);
                lablHistorial.Text += cantidad2 + "=";
                double resultado = EjecutarOperacion();
                cantidad1 = 0;
                cantidad2 = 0;
                ResultadosFin.Text = Convert.ToString(resultado);
            }
        }

        private void botnResta_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtnerValor("-");
        }

        private void botnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtnerValor("*");
        }

        private void botnDivision_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtnerValor("/");
        }

        private void botnEliminacion_Click(object sender, EventArgs e)
        {
            ResultadosFin.Text = "0";
            lablHistorial.Text = "";
        }

        private void botnBorrador_Click(object sender, EventArgs e)
        {
            if (ResultadosFin.Text.Length > 1)
            {
                string txtResultado = ResultadosFin.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);
                
                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    ResultadosFin.Text = "0";
                }
                else
                {
                    ResultadosFin.Text = txtResultado;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ResultadosFin.Text += ".";
        }
    }
}
