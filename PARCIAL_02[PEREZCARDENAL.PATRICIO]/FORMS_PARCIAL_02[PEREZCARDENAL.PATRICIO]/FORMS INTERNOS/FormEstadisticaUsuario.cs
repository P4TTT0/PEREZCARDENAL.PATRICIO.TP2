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
    public partial class FormEstadisticaUsuario : Form
    {
        private EstadisticasUsuario estadisticasUsuario;
        private Usuario usuario;
        private ConexionEstadisticasUsuario conexionEstadisticasUsuario;
        public FormEstadisticaUsuario()
        {
            InitializeComponent();
            this.conexionEstadisticasUsuario = new ConexionEstadisticasUsuario();
            this.estadisticasUsuario = new EstadisticasUsuario();
        }
        public FormEstadisticaUsuario(Usuario usuario) : this()
        {
            this.usuario = usuario;
        }


        private void FormEstadisticaUsuario_Load(object sender, EventArgs e)
        {
            this.estadisticasUsuario = this.conexionEstadisticasUsuario.ObtenerEstadisticasUsuario(this.usuario.Id);

            this.labelUsuario.Text = this.usuario.NombreUsuario;
            this.labelId.Text = this.usuario.Id.ToString();

            this.labelValorPartidasGanadas.Text = this.estadisticasUsuario.PartidasGanadas.ToString();
            this.labelValorPartidasPerdidas.Text = this.estadisticasUsuario.PartidasPerdidas.ToString();
            this.labelValorPartidasJugadas.Text = this.estadisticasUsuario.PartidasJugadas.ToString();
            this.labelValorWinRate.Text = $"{this.estadisticasUsuario.WinRate} %";
        }
    }
}
