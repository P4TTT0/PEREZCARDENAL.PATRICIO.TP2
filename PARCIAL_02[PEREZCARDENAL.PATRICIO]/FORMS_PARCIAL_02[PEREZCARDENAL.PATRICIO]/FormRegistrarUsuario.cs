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

namespace FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public partial class FormRegistrarUsuario : Form
    {
        Usuario nuevoUsuario;
        ConexionUsuario conexionUsuario;
        public FormRegistrarUsuario()
        {
            InitializeComponent();
            this.nuevoUsuario = new Usuario();
            this.conexionUsuario = new ConexionUsuario();
        }


        public Usuario NuevoUsuario { get => nuevoUsuario; }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            if (this.textBoxUsuario.Text != "" && this.textBoxUsuario.Text != "")
            {
                this.nuevoUsuario.NombreUsuario = this.textBoxUsuario.Text;
                this.nuevoUsuario.Contraseña = this.textBoxContraseña.Text;

                if (this.conexionUsuario.ComprobarUsuario(this.nuevoUsuario))
                {
                    MessageBox.Show("USUARIO EXISTENTE");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("CAMPOS VACIOS!");
            }
        }

        private void buttonMostrarContraseña_Click(object sender, EventArgs e)
        {
            if (this.textBoxContraseña.UseSystemPasswordChar)
            {
                this.textBoxContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                this.textBoxContraseña.UseSystemPasswordChar = true;
            }
        }

        private void FormRegistrarUsuario_Load(object sender, EventArgs e)
        {
            this.textBoxContraseña.UseSystemPasswordChar = true;
        }
    }
}
