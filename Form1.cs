using Calculus;

namespace AnalisisNumerico2024.Unidad1
{
    public partial class Unidad1 : Form
    {
        Calculo analizadorFuncion = new Calculo();

        public void Prueba()
        {

            string function = input
            double xi = 1;
            double xd = 5;
            double tolerancia = 0.0001;
            int iteraciones = 100;


            if (analizadorFuncion.Sintaxis(function, 'x'))
            {
                if (analizadorFuncion.EvaluaFx(xi) * analizadorFuncion.EvaluaFx(xd) > 0)
                {
                    MessageBox.Show("error varialble");
                }
                else
                {
                    var derivada = analizadorFuncion.Dx(xi);

                    if (derivada < tolerancia || double.IsNaN(derivada))
                    {
                        MessageBox.Show("error tolerancia");
                    }


                    for (int i = 0; i <= iteraciones; i++)
                    {
                        if (Math.Abs(analizadorFuncion.EvaluaFx(xi)) < tolerancia)
                        {
                            MessageBox.Show("Raiz es 0");
                        }

                        else
                        {
                            MessageBox.Show("La sintasis es incorrecta");
                        }

                    }
                }
        }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }


}