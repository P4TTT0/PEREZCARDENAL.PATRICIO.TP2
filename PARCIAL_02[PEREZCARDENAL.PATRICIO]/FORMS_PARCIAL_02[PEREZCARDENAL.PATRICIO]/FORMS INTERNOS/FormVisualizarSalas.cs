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
        DataTable tablaSalas = new DataTable();
        DataRow filaSala;
        ConexionBaseDatos baseDatos = new ConexionBaseDatos();
        public FormVisualizarSalas()
        {
            InitializeComponent();
        }

        private void FormVisualizarSalas_Load(object sender, EventArgs e)
        {
            this.tablaSalas.Columns.Add("N° SALA");
            this.tablaSalas.Columns.Add("CREADOR");
            this.tablaSalas.Columns.Add("FECHA CREACION");
            this.tablaSalas.Columns.Add("ESTADO");
            this.tablaSalas.Columns.Add("RONDA");

            this.CargarDataGridSalas();
        }

        private void CargarDataGridSalas()
        {
            List<Salas> listaSalas = this.baseDatos.ObtenerListaSalas();

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
            this.dataGridViewSalas.DataSource = this.tablaSalas;
        }
    }
}
