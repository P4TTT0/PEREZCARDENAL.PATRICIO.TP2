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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        ConexionBaseDatos baseDatos = new ConexionBaseDatos();

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.textBoxContraseña.UseSystemPasswordChar = true;
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

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            if(this.baseDatos.ComprobarUsuario(new Usuario(this.textBoxUsuario.Text, this.textBoxContraseña.Text)))
            {
                MessageBox.Show("CONECTADO");
            }
            else
            {
                MessageBox.Show("Usuario Inexsistente");
            }


        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario formRegistrar = new FormRegistrarUsuario();

            if (formRegistrar.ShowDialog() == DialogResult.OK)
            {
                if (this.baseDatos.AgregarUsuario(formRegistrar.NuevoUsuario))
                {
                    MessageBox.Show("USUARIO AGREGADO");
                }
            }
        }
    }
}
