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
        Salas auxSala;

        private ConexionSalas conexionSalas;
        public FormVisualizarSalas()
        {
            InitializeComponent();
            this.auxSala = new Salas();
            this.conexionSalas = new ConexionSalas();
            this.auxSala = new Salas();
        }

        private void FormVisualizarSalas_Load(object sender, EventArgs e)
        {
            this.CargarColumnas();
            this.CargarDataGridSalas();
            this.buttonJugar.Enabled = false;
        }

        private void CargarDataGridSalas()
        {
            this.tablaSalas.Dispose();
            this.tablaSalas.Clear();
            this.CargarColumnas();

            List<Salas> listaSalas = this.conexionSalas.ObtenerLista();

            foreach (Salas sala in listaSalas)
            {
                this.filaSala = this.tablaSalas.NewRow();
                this.filaSala[0] = sala.Id;
                this.filaSala[1] = sala.NombreCreador;
                this.filaSala[2] = sala.FechaSalaCreada;
                this.filaSala[3] = sala.EstadoPartida;
                this.filaSala[4] = sala.Ronda;
                this.tablaSalas.Rows.Add(filaSala);
            }
            this.DataGridHilo();
        }

        private void CargarDataGridSalasFiltrado()
        {
            this.tablaSalas.Dispose();
            this.tablaSalas.Clear();
            this.CargarColumnas();

            List<Salas> listaSalas = this.conexionSalas.ObtenerLista();

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
        private void ButtonJugarHilo()
        {
            if (this.buttonJugar.InvokeRequired)
            {
                Action delegado = new Action(this.ButtonJugarHilo);

                this.buttonJugar.Invoke(delegado);
            }
            else
            {
                this.buttonJugar.Enabled = false;
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
            foreach (Salas sala in this.conexionSalas.ObtenerLista())
            {
                if (indiceFilaSeleccionada > -1)
                {
                    if (sala == int.Parse(this.dataGridViewSalas.Rows[indiceFilaSeleccionada].Cells[0].Value.ToString()))
                    {
                        if (sala.EstadoPartida == EEstadoPartida.TERMINADA.ToString())
                        {
                            this.buttonJugar.Enabled = false;
                            break;
                        }
                        else
                        {
                            auxSala = sala;
                            this.buttonJugar.Enabled = true;
                            break;
                        }
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
                this.ButtonJugarHilo();
            }
        }

        private void buttonVerEnJuego_Click(object sender, EventArgs e)
        {
            this.CargarDataGridSalasFiltrado();
        }

        private void buttonVerTodas_Click(object sender, EventArgs e)
        {
            this.CargarDataGridSalas();
        }
    }
}
