using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_.FORMS_INTERNOS
{
    public partial class FormJugar : Form
    {
        public FormJugar()
        {
            InitializeComponent();
        }

        private void buttonCrearSala_Click(object sender, EventArgs e)
        {
            FormCrearSala crearSala = new FormCrearSala();
            if (crearSala.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonVerSalas_Click(object sender, EventArgs e)
        {
            FormVisualizarSalas formSalas = new FormVisualizarSalas();
            formSalas.ShowDialog();
        }
    }
}
