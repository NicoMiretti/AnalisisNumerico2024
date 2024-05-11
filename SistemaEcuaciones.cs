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
            try
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
                    case 1:
                        vectorResultado = MetodoGaussSeidel(dimension, matriz);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            for (int filaDiag = 0; filaDiag < dimension; filaDiag++)
            {
                double coeficienteDiagonal = matriz[filaDiag, filaDiag];


                for (int col = 0; col < dimension + 1; col++)
                {
                    matriz[filaDiag, col] /= coeficienteDiagonal;
                }

                for (int fila = 0; fila < dimension; fila++)
                {
                    if (fila != filaDiag)
                    {
                        double coeficienteCero = matriz[fila, filaDiag];

                        for (int col = 0; col < dimension + 1; col++)
                        {
                            matriz[fila, col] = matriz[fila, col] - (coeficienteCero * matriz[filaDiag, col]);
                        }
                    }
                }
            }

            double[] vectorResultado = new double[dimension];

            for (int fila = 0; fila < dimension; fila++)
            {
                vectorResultado[fila] = matriz[fila, dimension];
            }

            return vectorResultado;
        }

        private static double[] MetodoGaussSeidel(int dimension, double[,] matriz)
        {
            //VARIABLES COMUNES 
            double tolerancia = 0.0001;
            bool esSolucion = false;
            short contador = 0;
            double[] vectorResultado = new double[dimension];
            vectorResultado.Initialize();
            double[] vectorAnterior = new double[dimension];

            while (contador <= 100 && !esSolucion)
            {
                contador++;
                if (contador > 1)
                {
                    vectorResultado.CopyTo(vectorAnterior, 0);
                }
                for (int fila = 0; fila < dimension; fila++)
                {
                    double resultado = matriz[fila, dimension];
                    double coeficienteIncognita = matriz[fila, fila];
                    for (int col = 0; col < dimension; col++)
                    {
                        if (fila != col)
                        {
                            resultado = resultado - (matriz[fila, col] * vectorResultado[col]);
                        }
                    }
                    coeficienteIncognita = resultado / coeficienteIncognita;
                    vectorResultado[fila] = coeficienteIncognita;
                }
                short contadorMismoResultado = 0;
                double errorRelativo = 0;
                for (int i = 0; i < dimension; i++)
                {
                    errorRelativo = Math.Abs((vectorResultado[i] - vectorAnterior[i]) / vectorResultado[i]);
                    if (errorRelativo < tolerancia)
                    {
                        contadorMismoResultado++;
                    }
                }
                esSolucion = contadorMismoResultado == dimension;
            }
            if (contador <= 100)
            {
                return vectorResultado;
            }
            else
            {
                throw new Exception("Se superó la cantidad de iteraciones.");
            }

        }
    }
}
