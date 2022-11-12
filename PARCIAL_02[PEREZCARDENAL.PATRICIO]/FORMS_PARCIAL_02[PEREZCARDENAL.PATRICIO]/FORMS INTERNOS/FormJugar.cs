using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void FormJugar_Load(object sender, EventArgs e)
        {
            this.labelValorUsuario.Text = FormLogin.UsuarioActual.NombreUsuario;
            Task.Run(() => { this.CambiarHora(); });
        }

        private void AsignarHora()
        {
            if (this.labelValorFecha.InvokeRequired)
            {
                Action delegado = new Action(this.AsignarHora);

                this.labelValorFecha.Invoke(delegado);
            }
            else
            {
                this.labelValorFecha.Text = DateTime.Now.ToString();
            }
        }

        private void CambiarHora()
        {
            while(true)
            {
                this.AsignarHora();
                Thread.Sleep(1000);
            }
        }

        private void buttonCrearSala_Click(object sender, EventArgs e)
        {
            FormCrearSala formCrearSala = new FormCrearSala();
            formCrearSala.ShowDialog();
        }
    }
}
