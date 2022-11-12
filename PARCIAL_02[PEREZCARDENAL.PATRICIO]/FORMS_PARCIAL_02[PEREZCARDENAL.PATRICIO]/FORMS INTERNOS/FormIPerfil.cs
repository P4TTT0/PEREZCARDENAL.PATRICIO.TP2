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
    public partial class FormIPerfil : Form
    {
        public FormIPerfil()
        {
            InitializeComponent();
        }
        ConexionBaseDatos baseDatos = new ConexionBaseDatos();
        EstadisticasUsuario estadisticasUsuario;

        private void FormIPerfil_Load(object sender, EventArgs e)
        {
            this.labelUsuario.Text = FormLogin.UsuarioActual.NombreUsuario;
            this.estadisticasUsuario = this.baseDatos.ObtenerEstadisticasUsuario(FormLogin.UsuarioActual);

            this.labelValorPartidasGanadas.Text = this.estadisticasUsuario.PartidasGanadas.ToString();
            this.labelValorPartidasPerdidas.Text = this.estadisticasUsuario.PartidasPerdidas.ToString();
            this.labelValorPartidasJugadas.Text = this.estadisticasUsuario.PartidasJugadas.ToString();
            this.labelValorWinRate.Text = $"{this.estadisticasUsuario.WinRate} %";
        }
    }
}
