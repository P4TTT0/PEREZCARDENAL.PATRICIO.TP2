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
    public partial class FormVisualizarSalas : Form
    {
        DataTable tablaSalas;
        DataRow filaSala;
        ConexionBaseDatos baseDatos = new ConexionBaseDatos();
        Salas auxSala;
        FormMenuPrincipal menu;
        public FormVisualizarSalas()
        {
            InitializeComponent();
        }

        public FormVisualizarSalas(FormMenuPrincipal formMenu) : this()
        {
            InitializeComponent();
            this.menu = formMenu;
        }

        private void FormVisualizarSalas_Load(object sender, EventArgs e)
        {
            this.CargarColumnas();
            this.CargarDataGridSalas();
        }

        private void CargarDataGridSalas()
        {
            this.tablaSalas.Dispose();
            this.CargarColumnas();

            List<Salas> listaSalas = this.baseDatos.ObtenerListaSalas();

            foreach (Salas sala in listaSalas)
            {
                if (sala.NombreCreador == FormLogin.UsuarioActual.NombreUsuario && sala.EstadoPartida == EEstadoPartida.EN_JUEGO.ToString())
                {
                    this.filaSala = this.tablaSalas.NewRow();
                    this.filaSala[0] = sala.Id;
                    this.filaSala[1] = sala.NombreCreador;
                    this.filaSala[2] = sala.FechaSalaCreada;
                    this.filaSala[3] = sala.EstadoPartida;
                    this.filaSala[4] = sala.Ronda;
                    this.tablaSalas.Rows.Add(filaSala);
                }
            }
            this.DataGridHilo();
        }

        private void DataGridHilo()
        {
            if (this.dataGridViewSalas.InvokeRequired)
            {
                Action delegado = new Action(this.DataGridHilo);

                this.dataGridViewSalas.Invoke(delegado);
            }
            else
            {
                this.dataGridViewSalas.DataSource = this.tablaSalas;
            }
        }

        private void CargarColumnas()
        {
            this.tablaSalas = new DataTable();
            this.tablaSalas.Columns.Add("N° SALA");
            this.tablaSalas.Columns.Add("CREADOR");
            this.tablaSalas.Columns.Add("FECHA CREACION");
            this.tablaSalas.Columns.Add("ESTADO");
            this.tablaSalas.Columns.Add("RONDA");
        }

        private Salas SeleccionarSala(int indiceFilaSeleccionada)
        {
            Salas auxSala = null;
            foreach (Salas sala in this.baseDatos.ObtenerListaSalas())
            {
                if (indiceFilaSeleccionada > -1)
                {
                    if (sala == int.Parse(this.dataGridViewSalas.Rows[indiceFilaSeleccionada].Cells[0].Value.ToString()))
                    {
                        auxSala = sala;
                        break;
                    }
                } 
            }

            return auxSala;
        }

        private void dataGridViewSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
            this.auxSala = this.SeleccionarSala(indice);
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            if (this.auxSala is not null)
            {
               Task.Run(() => this.AbrirSala(this.auxSala));
            }
        }

        private void AbrirSala(Salas sala)
        {
            FormPartida formPartida = new FormPartida(sala);
            if (formPartida.ShowDialog() == DialogResult.OK)
            {
                this.CargarDataGridSalas();
            }
        }
    }
}
