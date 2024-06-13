using Analisis_Numerico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnalisisNumerico2024
{
    public partial class AjusteCurva : Form
    {
        public Graficador graficador { get; set; }
        public AjusteCurva()
        {
            InitializeComponent();
            SetPanelGrafica();
            SistemaEcuaciones sistemaEcuaciones = new SistemaEcuaciones();
        }
        public void SetPanelGrafica()
        {
            panelGrafica.Controls.Clear();
            this.graficador = new Graficador();
            panelGrafica.Controls.Add(graficador);
            graficador.Dock = DockStyle.Fill;
        }
        public List<double[]> PuntosCargados { get; set; } = new List<double[]>();
        public void CargarPunto(double x, double y)
        {
            double[] punto = new double[2] { x, y };
            PuntosCargados.Add(punto);
        }

        private void CargarButton_Click_1(object sender, EventArgs e)
        {


            double x, y;
            if (string.IsNullOrWhiteSpace(txtX.Text) ||
               string.IsNullOrWhiteSpace(txtY.Text) ||
               !double.TryParse(txtX.Text, out x) ||   // Convertir txtX a double
               !double.TryParse(txtY.Text, out y))
            {
                MessageBox.Show("Por favor, complete todos los campos de manera correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                CargarPunto(x, y);
                Label puntoIngresado = new Label();
                puntoIngresado.Text = $"({txtX.Text} " + "," + $" {txtY.Text})";
                int cantElementos = PuntosCargados.Count();
                int puntoY = (cantElementos - 1) * 17;
                puntoIngresado.Location = new Point(0, puntoY);
                puntoIngresado.Size = new Size(100, 16);
                puntoIngresado.Font = new Font("Arial", 11);
                panelPuntosIngresados.Controls.Add(puntoIngresado);
                panelPuntosIngresados.Show();
                txtX.Clear();
                txtY.Clear();
            }
        }
        private void CalcularButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbMetodo.SelectedItem.ToString() == "Regresión Polinomial")
                {
                    RegresionPolinomial();
                }
                else if (cmbMetodo.SelectedItem.ToString() == "Regresión Lineal")
                {
                    RegresionLineal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");

            }

        }
        public void RegresionLineal()
        {
            double tolerancia = 0;
            if (string.IsNullOrWhiteSpace(txtTolerancia.Text) ||
               !double.TryParse(txtTolerancia.Text, out tolerancia))
            {
                MessageBox.Show("Por favor, complete todos los campos de manera correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n = PuntosCargados.Count();
            double sumX = 0;
            foreach (double[] punto in PuntosCargados)
            {
                sumX += punto[0];
            }
            double sumY = 0;
            foreach (double[] punto in PuntosCargados)
            {
                sumY += punto[1];
            }
            double sumXY = 0;
            foreach (double[] punto in PuntosCargados)
            {
                sumXY += punto[0] * punto[1];
            }
            double sumX2 = 0;
            foreach (double[] punto in PuntosCargados)
            {
                sumX2 += punto[0] * punto[0];
            }
            double a1 = (n * sumXY - sumX * sumY) / (n * sumX2 - ((sumX) * (sumX)));
            double a0 = (sumY / n) - a1 * (sumX / n);
            double St = 0;
            double Sr = 0;
            foreach (double[] punto in PuntosCargados)
            {
                St += Math.Pow(sumY / n - punto[1], 2);
                Sr += Math.Pow(a1 * punto[0] + a0 - punto[1], 2);
            }
            double r = Math.Sqrt(((St - Sr) / St)) * 100;
            FuncionObtenida.Text = $"y = ({Math.Round(a1, 3)})x +  ({Math.Round(a0, 3)})";
            Correccion.Text = $"{Math.Round((r), 2)}%";
            if (Math.Round(r, 2) > tolerancia)
            {
                EfectividadAjuste.Text = "El ajuste es aceptable.";
            }
            else
            {
                EfectividadAjuste.Text = "El ajuste no es aceptable.";
            }
            graficador.Graficar(PuntosCargados, FuncionObtenida.Text);
        }
        public void RegresionPolinomial()
        {
            double tolerancia = 0;
            if (string.IsNullOrWhiteSpace(txtTolerancia.Text) ||
               !double.TryParse(txtTolerancia.Text, out tolerancia))
            {
                MessageBox.Show("Por favor, complete todos los campos de manera correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int grado = 0;
            if (string.IsNullOrWhiteSpace(txtGrado.Text) ||
                !int.TryParse(txtGrado.Text, out grado))
            {
                if (grado < 2 || grado > 10)
                {
                    MessageBox.Show("Por favor, el grado debe estar entre 2 y 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            double[,] matriz = GenerarMatrizPolinomial(grado, PuntosCargados);
            double[] vectorResultado = SistemaEcuaciones.MetodoGaussJordan(grado + 1, matriz);
            string funcion = string.Empty;
            string signo = string.Empty;
            for (int i = 0; i < vectorResultado.Count(); i++)
            {
                double ai = Math.Round(vectorResultado[i], 4);
                if (i == 0 && ai != 0)
                {
                    funcion = $"{ai}";
                }
                else if (i == 1 && ai != 0)
                {
                    funcion = $"{ai}x {signo}" + funcion;
                }
                else
                {
                    if (ai != 0)
                    {
                        funcion = $"{ai}x^{i} {signo}" + funcion;
                    }
                }
                signo = ai > 0 ? "+" : string.Empty;
            }
            double sumY = 0;
            foreach (double[] punto2 in PuntosCargados)
            {
                sumY += punto2[1];
            }
            int n = PuntosCargados.Count();
            double x = 0, y = 0;
            double Sr = 0, St = 0;
            foreach (double[] punto in PuntosCargados)
            {
                x = punto[0];
                y = punto[1];
                double suma = 0;
                for (int i = 0; i < vectorResultado.Count(); i++)
                {
                    suma += vectorResultado[i] * Math.Pow(x, i);
                }
                Sr += Math.Pow(suma - y, 2);
                St += Math.Pow(sumY / n - y, 2);
            }
            double r = Math.Sqrt(((St - Sr) / St)) * 100;
            FuncionObtenida.Text = $"{funcion}";
            Correccion.Text = $"{Math.Round(r, 4)}%";
            if (Math.Round((r * 10), 2) > tolerancia)
            {
                EfectividadAjuste.Text = "El ajuste es aceptable.";
            }
            else
            {
                EfectividadAjuste.Text = "El ajuste no es aceptable.";
            }
            graficador.Graficar(PuntosCargados, FuncionObtenida.Text);
        }
        public double[,] GenerarMatrizPolinomial(int grado, List<double[]> puntosCargados)
        {
            int dimension = grado + 1;
            double[,] matriz = new double[dimension, dimension + 1];
            double x = 0, y = 0;
            foreach (double[] punto in puntosCargados)
            {
                x = punto[0];
                y = punto[1];
                for (int fila = 0; fila < dimension; fila++)
                {
                    for (int col = 0; col < dimension; col++)
                    {
                        matriz[fila, col] += Math.Pow(x, fila + col);
                    }
                    matriz[fila, dimension] += y * Math.Pow(x, fila);
                }
            }
            return matriz;
        }
        public void DeleteLastButton_Click(object sender, EventArgs e)
        {
            panelPuntosIngresados.Controls.RemoveAt(PuntosCargados.Count - 1);
            PuntosCargados.RemoveAt(PuntosCargados.Count - 1);
        }

        public void DeleteAllButton_Click(object sender, EventArgs e)
        {
            panelPuntosIngresados.Controls.Clear();
            PuntosCargados.Clear();
        }

        public void cmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodo.SelectedItem != null && cmbMetodo.SelectedItem.ToString() == "Regresión Polinomial")
            {
                txtGrado.Visible = true;
                lblGrado.Visible = true;
            }
            else
            {
                txtGrado.Visible = false;
                lblGrado.Visible = false;
            }
        }
    }
}
