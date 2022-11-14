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
    public partial class FormVisualizarUsuarios : Form
    {
        DataTable tablaUsuarios;
        DataRow filaUsuario;
        private Usuario auxUsuario;
        private ConexionUsuario conexionUsuario;
        public FormVisualizarUsuarios()
        {
            InitializeComponent();
            this.conexionUsuario = new ConexionUsuario();
            this.auxUsuario = new Usuario();
        }

        private void FormVisualizarUsuarios_Load(object sender, EventArgs e)
        {
            this.CargarColumnas();
            this.CargarDataGrid();
            this.Dock = DockStyle.Fill;
        }

        private void CargarColumnas()
        {
            this.tablaUsuarios = new DataTable();
            this.tablaUsuarios.Columns.Add("N° ID");
            this.tablaUsuarios.Columns.Add("USUARIO");
        }

        private void CargarDataGrid()
        {
            this.tablaUsuarios.Dispose();
            this.CargarColumnas();

            List<Usuario> listaUsuario = this.conexionUsuario.ObtenerLista();

            foreach (Usuario usuario in listaUsuario)
            {
                this.filaUsuario = this.tablaUsuarios.NewRow();
                this.filaUsuario[0] = usuario.Id;
                this.filaUsuario[1] = usuario.NombreUsuario;
                this.tablaUsuarios.Rows.Add(this.filaUsuario);

            }
            this.dataGridViewUsuarios.DataSource = this.tablaUsuarios;
        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
            this.auxUsuario = this.SeleccionarUsuario(indice);
        }

        private Usuario SeleccionarUsuario(int indiceFilaSeleccionada)
        {
            Usuario auxUsuario = null;
            foreach (Usuario usuario in this.conexionUsuario.ObtenerLista())
            {
                if (indiceFilaSeleccionada > -1)
                {
                    if (usuario == int.Parse(this.dataGridViewUsuarios.Rows[indiceFilaSeleccionada].Cells[0].Value.ToString()))
                    {
                        auxUsuario = usuario;
                        break;
                    }
                }
            }

            return auxUsuario;
        }


        private void dataGridViewUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
            this.auxUsuario = this.SeleccionarUsuario(indice);
        }

        private void buttonVerEstadistica_Click(object sender, EventArgs e)
        {
            if (this.auxUsuario is not null)
            {
                FormEstadisticaUsuario formEstadisticas = new FormEstadisticaUsuario(this.auxUsuario);
                formEstadisticas.Show();
            }
        }
    }
}
