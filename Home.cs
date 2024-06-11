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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnRaices_Click(object sender, EventArgs e)
        {
            RaicesFunciones raicesFunciones = new RaicesFunciones();
            raicesFunciones.Show();
        }

        private void btnSistemaEcuaciones_Click(object sender, EventArgs e)
        {
            SistemaEcuaciones sistemaEcuaciones = new SistemaEcuaciones();
            sistemaEcuaciones.Show();
        }

        private void btnRegresionLineal_Click(object sender, EventArgs e)
        {
            AjusteCurva ajusteCurva = new AjusteCurva();
            ajusteCurva.Show();
        }

        private void btnIntegracionNumerica_Click(object sender, EventArgs e)
        {
            IntegracionNumerica integracionNumerica = new IntegracionNumerica();
            integracionNumerica.Show();
        }
    }
}
