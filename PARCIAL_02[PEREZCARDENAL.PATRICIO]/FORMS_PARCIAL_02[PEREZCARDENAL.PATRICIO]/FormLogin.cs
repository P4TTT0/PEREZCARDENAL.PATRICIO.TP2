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
using FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_.FORMS_INTERNOS;

namespace FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public partial class FormLogin : Form
    {
        private static Usuario usuarioActual;
        private ConexionEstadisticasUsuario conexionEstadisticasUsuario;
        private ConexionUsuario conexionUsuario;

        public static Usuario UsuarioActual { get => usuarioActual; set => usuarioActual = value; }

        public FormLogin()
        {
            InitializeComponent();
            this.conexionUsuario = new ConexionUsuario();
            this.conexionEstadisticasUsuario = new ConexionEstadisticasUsuario();
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {
            FormLogin.usuarioActual = new Usuario();
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
            Usuario usuarioActual = new Usuario(this.textBoxUsuario.Text, this.textBoxContraseña.Text);
            if(this.conexionUsuario.ComprobarUsuario(usuarioActual))
            {
                usuarioActual.Id = this.conexionUsuario.RetornarIdUsuario(usuarioActual);
                FormMenuPrincipal formMenu = new FormMenuPrincipal();
                FormLogin.usuarioActual = usuarioActual;
                formMenu.Show();
                this.Hide();
            }
            else
            {
                this.ActualizarMensajeInformativo(1);
            }
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario formRegistrar = new FormRegistrarUsuario();

            if (formRegistrar.ShowDialog() == DialogResult.OK)
            {
                if (this.conexionUsuario.Agregar(formRegistrar.NuevoUsuario))
                {
                    this.ActualizarMensajeInformativo(2);
                }
                FormLogin.usuarioActual.Id = this.conexionUsuario.RetornarIdUsuario(formRegistrar.NuevoUsuario);
                this.conexionEstadisticasUsuario.AgregarEstadisticasUsuario(FormLogin.usuarioActual);
            }
        }

        private void ActualizarMensajeInformativo()
        {
            this.pictureBoxError.Visible = false;
            this.labelErrorUsuarioInexistente.Visible = false;
            this.pictureBoxExito.Visible = false;
            this.labelExitoUsuarioRegistrado.Visible = false;
        }

        private void ActualizarMensajeInformativo(int opcion)
        {
            this.ActualizarMensajeInformativo();

            switch(opcion)
            {
                case 1:
                    this.pictureBoxError.Visible = true;
                    this.labelErrorUsuarioInexistente.Visible = true;
                    break;
                case 2:
                    this.pictureBoxExito.Visible = true;
                    this.labelExitoUsuarioRegistrado.Visible = true;
                    break;
            }

        }

        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
            this.ActualizarMensajeInformativo();
        }

        private void textBoxContraseña_Enter(object sender, EventArgs e)
        {
            this.ActualizarMensajeInformativo();
        }

    }
}
