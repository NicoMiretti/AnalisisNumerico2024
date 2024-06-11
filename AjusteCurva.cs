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

namespace AnalisisNumerico2024
{
    public partial class AjusteCurva : Form
    {
        public Graficador graficador { get; set; }
        public AjusteCurva()
        {
            InitializeComponent();
            SetPanelGrafica();
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
        public void Graficar()
        {
            List<double[]> PuntosCargados = new List<double[]>();
            string function = "2.5*x-1"; // y = 2,5x – 1
            SetPanelGrafica();
            graficador.Graficar(PuntosCargados, function);
        }
        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int cantPuntosEntrada = PuntosCargados.Count();
            double sumX = 0;
            foreach (double[] punto in PuntosCargados)
            {
                sumX += punto[0];
            }
            double sumY = 0;
            foreach (double[] punto in PuntosCargados)
            {
                sumX += punto[1];
            }

        }
        private void DeleteLastButton_Click(object sender, EventArgs e)
        {
            panelPuntosIngresados.Controls.RemoveAt(PuntosCargados.Count - 1);
            PuntosCargados.RemoveAt(PuntosCargados.Count - 1);
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            panelPuntosIngresados.Controls.Clear();
            PuntosCargados.Clear();
        }
    }
}
