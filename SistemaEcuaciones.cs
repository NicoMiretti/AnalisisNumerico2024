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
    public partial class SistemaEcuaciones : Form
    {
        public SistemaEcuaciones()
        {
            InitializeComponent();
        }

        #region GENERACION MATRIZ
        //Método para generar matrix 
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDimension.Text, out int dimension))
            {
                MessageBox.Show("Indique la dimension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dimension > 6)
            {
                MessageBox.Show("La dimensión máxima es 8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dimension = int.Parse(txtDimension.Text);
                int puntoX = 30;
                int puntoY = 30;

                groupBoxMatriz.Controls.Clear();

                for (int fila = 0; fila < dimension; fila++)
                {
                    for (int col = 0; col < dimension + 1; col++)
                    {
                        string nombre = $"({fila},{col})";
                        TextBox textBox = new TextBox();
                        textBox.Name = nombre;
                        ToolTip toolTip = new ToolTip();
                        toolTip.SetToolTip(textBox, nombre);
                        textBox.Location = new Point(puntoX, puntoY);
                        textBox.Size = new Size(100, 30);
                        if (col == dimension)
                        {
                            textBox.BackColor = Color.LightGray;
                        }
                        groupBoxMatriz.Controls.Add(textBox);
                        groupBoxMatriz.Show();
                        puntoX += 110;
                    }

                    puntoX = 30;
                    puntoY += 30;
                }
            }
        }
        #endregion

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dimension = int.Parse(txtDimension.Text);
            double[,] matriz = GuardarMatriz(dimension);
            MessageBox.Show("Matriz cargada con exito");
            double[] vectorResultado = new double[dimension];
            switch (cmbBox.SelectedIndex)
            {
                case 0:
                    vectorResultado = Logica2.MetodoGaussJordan(dimension, matriz);
                    break;
                case 1:
                    vectorResultado = Logica2.MetodoGaussSeidel(matriz, dimension);
                break;
            }
            string Resultados = "";
            if (vectorResultado != null)
            {
                for (int i = 0; i < vectorResultado.Length; i++)
                {
                    Resultados += $"X{i + 1} = {vectorResultado[i]}\n";
                }
            }
            else
            {
                Resultados = "Se pasó de iteraciones.";
            }
            MessageBox.Show(Resultados);
        }

        public double[,] GuardarMatriz(int dimension)
        {
            double[,] Matriz = new double[dimension, dimension + 1];
            for (int fila = 0; fila < dimension; fila++)
            {
                for (int col = 0; col < dimension + 1; col++)
                {
                    Control textBox = groupBoxMatriz.Controls.Find($"({fila},{col})", true).First();
                    if (!double.TryParse((textBox as TextBox).Text, out double numero))
                    {
                        return null;
                    }
                    Matriz[fila, col] = numero;
                }
            }
            return Matriz;
        }
    }
}
