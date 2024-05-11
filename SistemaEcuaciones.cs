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

        //Metodo gaus-seidel

        private void metodo(object sender, EventArgs e)
        {
            //VARIABLES COMUNES 
            double tolerancia = 0.0001;
            bool esSolucion = false;
            short contador = 0;
            short dimension = short.Parse(txtDimension.Text);
            //revisar
            // vectorResultado [dimension];
            // vectorResultado.INI

            string metodoSeleccionado = cmbBox.SelectedItem.ToString();

            if (metodoSeleccionado == "Gauss-Jordan")
            {

            }
            else if (metodoSeleccionado == "Gauss-Seidel")
            {
                while (contador <= 100 && !esSolucion)
                {
                    contador++;
                    if (contador > 1)
                    {
                        vectorResultado.CopyTo(vectoranterior, 0);
                    }
                    for (int row = 0; row < dimension; row++)
                    {
                        //resultado = groupBoxMatriz[row, dimension];
                        // coeficienteIncognita = groupBoxMatriz
                        for (int col = 0; col < dimension; col++)
                        {
                            if (row != col)
                            {
                                //resultado = resultado - (matriz[row, col] * vectorResultado[col]);
                            }
                        }
                        //coeficienteIncognita = resultado / coeficienteIncognita;
                        //vectorResultado[row] = coeficienteIncognita;
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
                    esSolucion = contadorMismoResultado == 0;
                }
                if (contador <= 100)
                {
                    return vectorResultado;
                }
                else
                {
                    MessageBox.Show("Se supero la cantidad de iteraciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }



    }
}
