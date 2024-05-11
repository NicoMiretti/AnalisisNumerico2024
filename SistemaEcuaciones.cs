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
                    vectorResultado = MetodoGaussJordan(dimension, matriz);
                    break;
                    //case 1:
                    //    vectorResultado = Logica2.MetodoGaussSeidel(matriz, dimension);
                    //    break;
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
        public static double[] MetodoGaussJordan(int dimension, double[,] matriz)
        {
            // Bucle general que recorre cada fila en donde está el coeficiente de la diagonal principal
            for (int filaDiag = 0; filaDiag < dimension; filaDiag++)
            {
                // Paso 2.a: Obtener el coeficiente de la diagonal principal
                double coeficienteDiagonal = matriz[filaDiag, filaDiag];

                // Paso 2.b: Bucle para recorrer las columnas de la fila actual y dividir por el coeficiente de la diagonal principal
                for (int col = 0; col < dimension + 1; col++)
                {
                    matriz[filaDiag, col] /= coeficienteDiagonal;
                }

                // Paso 2.c: Bucle para recorrer nuevamente las filas, salteando la fila del bucle principal
                for (int fila = 0; fila < dimension; fila++)
                {
                    if (fila != filaDiag)
                    {
                        // Paso 2.d: Obtener el coeficiente que queremos hacer cero
                        double coeficienteCero = matriz[fila, filaDiag];

                        // Paso 2.e: Bucle para anular el valor de la posición
                        for (int col = 0; col < dimension + 1; col++)
                        {
                            matriz[fila, col] -= coeficienteCero * matriz[filaDiag, col];
                        }
                    }
                }
            }

            // Instanciamos un vector resultado
            double[] vectorResultado = new double[dimension];

            // Bucle para obtener los valores de los términos independientes
            for (int fila = 0; fila < dimension; fila++)
            {
                vectorResultado[fila] = matriz[fila, dimension];
            }

            return vectorResultado;
        }
    }
}
