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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFormInterno(Form formInterno)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            formInterno.TopLevel = false;
            formInterno.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formInterno);
            this.panelContenedor.Tag = formInterno;
            formInterno.Show();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.AbrirFormInterno(new FORMS_INTERNOS.FormIPerfil());
        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            this.AbrirFormInterno(new FORMS_INTERNOS.FormVisualizarSalas());
        }

        private void buttonCrearSala_Click(object sender, EventArgs e)
        {
            this.AbrirFormInterno(new FORMS_INTERNOS.FormJugar());
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            this.AbrirFormInterno(new FORMS_INTERNOS.FormIPerfil());
        }

        private void buttonEstadisticas_Click(object sender, EventArgs e)
        {
            this.AbrirFormInterno(new FORMS_INTERNOS.FormVisualizarUsuarios());
        }
    }
}
