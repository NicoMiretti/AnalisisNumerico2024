using Calculus;
using System.Xml;
namespace AnalisisNumerico2024
{
    public partial class RaicesFunciones : Form
    {
        Calculo analizadorFuncion = new Calculo();

        // Variable para almacenar el método seleccionado
        private string metodoSeleccionado;
        public RaicesFunciones()
        {
            InitializeComponent();
        }

        double CalcularXrCerrado(string metodo, double xi, double xd)//Preguntar
        {
            double xr = 0;
            switch (metodo)
            {
                case "Bisección":
                    xr = (xi + xd) / 2.0;
                    break;

                case "Regla Falsa":
                    xr = ((analizadorFuncion.EvaluaFx(xd) * xi - analizadorFuncion.EvaluaFx(xi) * xd) / (analizadorFuncion.EvaluaFx(xd) - analizadorFuncion.EvaluaFx(xi)));
                    break;
            }
            return xr;
        }

        double CalcularXrAbierto(string metodo, string funcion, double xi, double xd, double error)
        {
            double derivada, tolerancia;
            double xr = 0;
            switch (metodo)
            {
                case "Tangente":

                    derivada = analizadorFuncion.Dx(xi);
                    double.TryParse(txtTolerancia.Text, out tolerancia);
                    if (Math.Abs(derivada) < tolerancia || double.IsNaN(derivada))
                    {
                        //txtRaiz.Text = "No encuentra la raíz";
                        //txtConverge.Text = "No, diverge";
                        //txtCantIteraciones.Text = "Superó las iteraciones";
                        //txtErrorRelativ.Text = Math.Round(error, 6).ToString();
                        xr = double.NaN;
                    }
                    else
                    {
                        xr = xi - (analizadorFuncion.EvaluaFx(xi) / derivada);
                    }
                    break;
                case "Secante":
                    xr = ((analizadorFuncion.EvaluaFx(xd) * xi - analizadorFuncion.EvaluaFx(xi) * xd) / (analizadorFuncion.EvaluaFx(xd) - analizadorFuncion.EvaluaFx(xi)));
                    break;
            }
            return xr;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (metodoSeleccionado == "Bisección" || metodoSeleccionado == "Regla Falsa")
            {
                CalcularBiseccionOReglaFalsa();
            }
            else
            {
                CalcularTangenteOSecante();
            }
        }

        private void btnBiseccion_Click(object sender, EventArgs e)
        {
            // Establecer el valor del método seleccionado
            metodoSeleccionado = "Bisección";

            // Actualizar el Label con el nombre del método seleccionado
            lblMetodoSeleccionado.Text = metodoSeleccionado;

            // Habilitar los TextBoxes relevantes y deshabilitar los demás
            txtFuncion.Enabled = true;
            txtXi.Enabled = true;
            txtXd.Enabled = true;
            lblXd.Enabled = true;
            txtTolerancia.Enabled = true;
            txtIteracionesMax.Enabled = true;

        }

        private void btnReglaFalsa_Click(object sender, EventArgs e)
        {
            // Establecer el valor del método seleccionado
            metodoSeleccionado = "Regla Falsa";

            // Actualizar el Label con el nombre del método seleccionado
            lblMetodoSeleccionado.Text = metodoSeleccionado;

            // Habilitar los TextBoxes relevantes y deshabilitar los demás
            txtFuncion.Enabled = true;
            txtXi.Enabled = true;
            txtXd.Enabled = true;
            lblXd.Enabled = true;
            txtTolerancia.Enabled = true;
            txtIteracionesMax.Enabled = true;
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            // Establecer el valor del método seleccionado
            metodoSeleccionado = "Tangente";

            // Actualizar el Label con el nombre del método seleccionado
            lblMetodoSeleccionado.Text = metodoSeleccionado;

            // Habilitar los TextBoxes relevantes y deshabilitar los demás
            txtFuncion.Enabled = true;
            txtXi.Enabled = true;
            txtXd.Enabled = false;
            lblXd.Enabled = false;
            txtTolerancia.Enabled = true;
            txtIteracionesMax.Enabled = true;

            // Limpiar los TextBoxes
            LimpiarTextBoxes(txtXd);
        }

        private void btnSecante_Click(object sender, EventArgs e)
        {
            // Establecer el valor del método seleccionado
            metodoSeleccionado = "Secante";

            // Actualizar el Label con el nombre del método seleccionado
            lblMetodoSeleccionado.Text = metodoSeleccionado;

            // Habilitar los TextBoxes relevantes y deshabilitar los demás
            txtFuncion.Enabled = true;
            txtXi.Enabled = true;
            txtXd.Enabled = true;
            lblXd.Enabled = true;
            txtTolerancia.Enabled = true;
            txtIteracionesMax.Enabled = true;

            // Limpiar los TextBoxes
            LimpiarTextBoxes(txtXd);
        }

        // Método para limpiar los TextBoxes
        private void LimpiarTextBoxes(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }

        // Método para calcular los resultados del método de Bisección o Regla Falsa
        private void CalcularBiseccionOReglaFalsa()
        {
            double xi, xd, tolerancia, iteraciones;
            //Verifico si algun campo esta vacio
            if (string.IsNullOrWhiteSpace(txtFuncion.Text) ||
                string.IsNullOrWhiteSpace(metodoSeleccionado) ||
                !double.TryParse(txtXi.Text, out xi) ||   // Convertir txtXi a double
                !double.TryParse(txtXd.Text, out xd) ||   // Convertir txtXd a double
                !double.TryParse(txtTolerancia.Text, out tolerancia) ||   // Convertir txtTolerancia a double
                !double.TryParse(txtIteracionesMax.Text, out iteraciones)) // Convertir txtIteraciones a double
            {
                MessageBox.Show("Por favor, complete todos los campos de manera correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (analizadorFuncion.Sintaxis(txtFuncion.Text, 'x')) //Evaluo sintaxis correcta
            {
                if (analizadorFuncion.EvaluaFx(xi) * analizadorFuncion.EvaluaFx(xd) > 0) // Evaluo la funcion en el punto
                {
                    MessageBox.Show(string.Format("El intervalo [{0},{1}] no contiene a la raíz. Vuelva a ingresar xi y xd.", xi, xd));
                }
                else
                {
                    if (analizadorFuncion.EvaluaFx(xi) * analizadorFuncion.EvaluaFx(xd) == 0) // Evaluo si alguno es raiz
                    {
                        if (analizadorFuncion.EvaluaFx(xi) == 0)
                        {
                            txtRaiz.Text = xi.ToString();
                            txtConverge.Text = "Si";
                            txtCantIteraciones.Text = "0";
                            txtErrorRelativ.Text = "0";
                        }
                        else
                        {
                            txtRaiz.Text = xd.ToString();
                            txtConverge.Text = "Si";
                            txtCantIteraciones.Text = "0";
                            txtErrorRelativ.Text = "0";
                        }
                    }
                    else
                    {
                        double xrAnterior = 0, xr = 0, error = 0;
                        for (int i = 1; i <= iteraciones; i++)
                        {
                            xr = CalcularXrCerrado(metodoSeleccionado, xi, xd);
                            error = Math.Abs((xr - xrAnterior) / xr);
                            if (Math.Abs(analizadorFuncion.EvaluaFx(xr)) < tolerancia || error < tolerancia)
                            {
                                txtRaiz.Text = Math.Round(xr, 6).ToString();
                                txtConverge.Text = "Si";
                                txtCantIteraciones.Text = i.ToString();
                                txtErrorRelativ.Text = Math.Round(error, 4).ToString();
                                break;
                            }
                            else
                            {
                                if (analizadorFuncion.EvaluaFx(xi) * analizadorFuncion.EvaluaFx(xr) > 0)
                                {
                                    xi = xr;
                                }
                                else
                                {
                                    xd = xr;
                                }
                                xrAnterior = xr;
                            }
                            if (i == iteraciones)
                            {
                                txtRaiz.Text = Math.Round(xr, 6).ToString();
                                txtConverge.Text = "No";
                                txtCantIteraciones.Text = "Superó las iteraciones";
                                txtErrorRelativ.Text = Math.Round(error, 4).ToString();
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("La sintaxis de la función no es correcta. Favor de volver a ingresar.");
            }

        }

        // Método para calcular los resultados del método de Tangente o Secante
        private void CalcularTangenteOSecante()
        {
            double xi, tolerancia, iteraciones;
            double xd = 0;
            //Verifico si algun campo esta vacio
            if (string.IsNullOrWhiteSpace(txtFuncion.Text) ||
                string.IsNullOrWhiteSpace(metodoSeleccionado) ||
                !double.TryParse(txtXi.Text, out xi) ||   // Convertir txtXi a double
                !double.TryParse(txtTolerancia.Text, out tolerancia) ||   // Convertir txtTolerancia a double
                !double.TryParse(txtIteracionesMax.Text, out iteraciones)) // Convertir txtIteraciones a double
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (metodoSeleccionado != "Tangente" && !double.TryParse(txtXd.Text, out xd))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (analizadorFuncion.Sintaxis(txtFuncion.Text, 'x')) //Evaluo sintaxis correcta
            {
                if (Math.Abs(analizadorFuncion.EvaluaFx(xi)) < tolerancia)
                {
                    txtRaiz.Text = Math.Round(xi, 6).ToString();
                    txtConverge.Text = "Si";
                    txtCantIteraciones.Text = "0";
                    txtErrorRelativ.Text = "0";
                }
                else
                {
                    if (metodoSeleccionado == "Secante" && Math.Abs(analizadorFuncion.EvaluaFx(xi)) < tolerancia)
                    {
                        txtRaiz.Text = Math.Round(xi, 6).ToString();
                        txtConverge.Text = "Si";
                        txtCantIteraciones.Text = "0";
                        txtErrorRelativ.Text = "0";
                    }
                }
                double xrAnterior = 0, xr = 0, error = 0;

                for (int i = 1; i <= iteraciones; i++)
                {
                    xr = CalcularXrAbierto(metodoSeleccionado, txtFuncion.Text, xi, xd, error);
                    if (double.IsNaN(xr))
                    {
                        txtRaiz.Text = "No se encuentra";
                        txtConverge.Text = "No, diverge";
                        txtCantIteraciones.Text = i.ToString();
                        txtErrorRelativ.Text = Math.Round(error, 4).ToString();
                        break;
                    }
                    error = Math.Abs((xr - xrAnterior) / xr);
                    if (Math.Abs(analizadorFuncion.EvaluaFx(xr)) < tolerancia || error < tolerancia)
                    {
                        txtRaiz.Text = Math.Round(xr, 6).ToString();
                        txtConverge.Text = "Si"; //Preguntar
                        txtCantIteraciones.Text = i.ToString();
                        //modificar
                        txtErrorRelativ.Text = Math.Round(error, 4).ToString();
                        break;
                    }
                    else
                    {
                        if (metodoSeleccionado == "Tangente")
                        {
                            xi = xr;
                        }
                        else
                        {
                            xi = xd;
                            xd = xr;
                        }
                        xrAnterior = xr;
                    }
                    if (i == iteraciones)
                    {
                        txtRaiz.Text = Math.Round(xr, 6).ToString();
                        txtConverge.Text = "Si";
                        txtCantIteraciones.Text = "Superó las iteraciones";
                        txtErrorRelativ.Text = Math.Round(error, 4).ToString();
                    }
                }
            }

            else
            {
                MessageBox.Show("La sintaxis de la función no es correcta. Favor de volver a ingresar.");
            }
        }

        private void txtErrorRelativ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}