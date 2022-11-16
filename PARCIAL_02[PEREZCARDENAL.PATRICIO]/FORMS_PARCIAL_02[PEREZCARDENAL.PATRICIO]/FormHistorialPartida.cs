using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public partial class FormHistorialPartida : Form
    {
        private string historialPartida;
        public FormHistorialPartida()
        {
            InitializeComponent();
        }

        public FormHistorialPartida(string historialPartida) : this()
        {
            this.historialPartida = historialPartida;
        }

        private void FormHistorialPartida_Load(object sender, EventArgs e)
        {
            this.richTextBoxHistorial.Text = this.historialPartida;
        }
    }
}
