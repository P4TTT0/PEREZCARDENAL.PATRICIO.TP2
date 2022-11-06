using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_;

namespace FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_.FORMS_INTERNOS
{
    public partial class FormCrearSala : Form
    {
        public FormCrearSala()
        {
            InitializeComponent();
        }
   
        ConexionBaseDatos baseDatos = new ConexionBaseDatos();

        private void FormCrearSala_Load(object sender, EventArgs e)
        {
            this.comboBoxCantidadJugadores.Items.Add(2);
        }

        private void buttonCrearSala_Click(object sender, EventArgs e)
        {
            if (this.comboBoxCantidadJugadores.SelectedIndex > -1)
            {
                this.baseDatos.AgregarSala(FormLogin.UsuarioActual, (int)this.comboBoxCantidadJugadores.SelectedItem);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("DEBES SELECCIONAR CANTIDAD DE JUGADORES");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
