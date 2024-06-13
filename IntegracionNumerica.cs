using Calculus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AnalisisNumerico2024
{
    public partial class IntegracionNumerica : Form
    {
        public IntegracionNumerica()
        {
            InitializeComponent();

            Intervalo.Visible = false;
            IntervaloLabel.Visible = false;
        }

        double CalcularIntegralTrapeciosSimple(string funcion, double xi, double xd)
        {
            Calculo Funcion = new Calculo();

            if (Funcion.Sintaxis(funcion, 'x'))
            {
                return ((Funcion.EvaluaFx(xi) + Funcion.EvaluaFx(xd)) * (xd - xi)) / 2;
            }
            else
            {
                throw new Exception("Función Mal Ingresada");
            }

        }

        private double CalcularIntegralTrapeciosMultiples(string funcion, double xi, double xd, int n)
        {
            Calculo Funcion = new Calculo();

            if (Funcion.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / n;
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += Funcion.EvaluaFx(xi + (h * i));
                }
                return (h / 2) * (Funcion.EvaluaFx(xi) + 2 * sum + Funcion.EvaluaFx(xd));
            }
            else
            {
                throw new Exception("Función Mal Ingresada"); ;
            }
        }

        private double CalcularIntegralSimpson1_3Simple(string funcion, double xi, double xd)
        {
            Calculo Funcion = new Calculo();

            if (Funcion.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / 2;
                return (h / 3) * (Funcion.EvaluaFx(xi) + 4 * Funcion.EvaluaFx(xi + h) + Funcion.EvaluaFx(xd));
            }
            else
            {
                throw new Exception("Función Mal Ingresada");
            }
        }

        private double CalcularIntegralSimpson1_3Multiple(string funcion, double xi, double xd, int n)

        {
            Calculo Funcion = new Calculo();

            if (Funcion.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / n;
                double sumPares = 0, sumImpares = 0;

                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumPares += Funcion.EvaluaFx(xi + (h * i));
                    }
                    else
                    {
                        sumImpares += Funcion.EvaluaFx(xi + (h * i));
                    }

                }

                return (h / 3) * (Funcion.EvaluaFx(xi) + 4 * sumImpares + 2 * sumPares + Funcion.EvaluaFx(xd));
            }
            else
            {
                throw new Exception("Función Mal Ingresada");
            }
        }

        private double CalcularIntegralSimpson3_8(string funcion, double xi, double xd)
        {
            Calculo Funcion = new Calculo();

            if (Funcion.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / 3;
                return (3 * h / 8) * (Funcion.EvaluaFx(xi) + 3 * Funcion.EvaluaFx(xi + h) + 3 * Funcion.EvaluaFx(xi + (2 * h)) + Funcion.EvaluaFx(xd));
            }
            else
                throw new Exception("Función Mal Ingresada");
        }


        private double CalcularIntegralAmbosMetodosSimpson(string funcion, double xi, double xd, int n)
        {
            Calculo Funcion = new Calculo();

            if (Funcion.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / n;
                //double sumPares = 0, sumImpares = 0;
                double resultado = 0;
                bool simpson3_8Hecho = false;

                for (int i = 0; i < n; i++)
                {
                    if (n % 2 != 0 && !simpson3_8Hecho)
                    {
                        double nuevoXi = xi + h * (n - 3);
                        resultado = CalcularIntegralSimpson3_8(funcion, nuevoXi, xd);
                        n -= 3;
                        simpson3_8Hecho = true;
                    }
                    if (i % 2 == 0)
                    {
                        resultado += CalcularIntegralSimpson1_3Multiple(funcion, xi, xi + n * h, n);
                    }
                }
                return resultado;
            }
            throw new Exception("Función Mal Ingresada");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void IngresarFuncion_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 3 || comboBox1.SelectedIndex == 4)
            {
                Intervalo.Visible = true;
                IntervaloLabel.Visible = true;
                Intervalo.Enabled = true;
            }
            else
            {
                Intervalo.Visible = false;
                IntervaloLabel.Visible = false;
                Intervalo.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            string funcion = IngresarFuncion.Text;
            double xi = Convert.ToDouble(TextBoxXi.Text);
            double xd = Convert.ToDouble(TextBoxXd.Text);
            int intervalos = Intervalo.Text != "" ? Convert.ToInt32(Intervalo.Text) : 0  ;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    resultado = CalcularIntegralTrapeciosSimple(funcion, xi, xd);

                    break;
                case 1:
                    resultado = CalcularIntegralTrapeciosMultiples(funcion, xi, xd, intervalos);
                    break;
                case 2:
                    resultado = CalcularIntegralSimpson1_3Simple(funcion, xi, xd);

                    break;
                case 3:
                    resultado = CalcularIntegralSimpson1_3Multiple(funcion, xi, xd, intervalos);

                    break;
                case 4:
                    resultado = CalcularIntegralAmbosMetodosSimpson(funcion, xi, xd,intervalos);
                    break;
                default:
                    break;
            }
            resultado = Math.Round(resultado, 5);
            txtResultado.Text = resultado.ToString();
        }
    }
}
