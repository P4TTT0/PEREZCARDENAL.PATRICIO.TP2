using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public class ConexionUsuario : IBaseDatos<Usuario>
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public ConexionUsuario()
        {
            this.conexion = new SqlConnection(IBaseDatos<Usuario>.CadenaConexion());
        }

        public List<Usuario> ObtenerLista()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Usuarios";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    Usuario usuario = new Usuario();

                    usuario.Id = (int)(this.lector["Id"]);
                    usuario.NombreUsuario = this.lector[1].ToString();
                    usuario.Contraseña = this.lector[2].ToString();

                    listaUsuarios.Add(usuario);
                }

                this.lector.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return listaUsuarios;
        }
        public bool Agregar(Usuario usuario)
        {
            bool validacion = true;

            try
            {
                string comandoSql = "INSERT INTO Usuarios VALUES (";
                comandoSql += "'" + usuario.NombreUsuario + "'" + "," + "'" + usuario.Contraseña + "'" + ")";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = comandoSql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    validacion = false;
                }
            }
            catch (Exception)
            {
                validacion = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return validacion;
        }

        public int RetornarIdUsuario(Usuario auxUsuario)
        {
            int id = -1;

            foreach (Usuario usuario in this.ObtenerLista())
            {
                if (auxUsuario == usuario)
                {
                    id = usuario.Id;
                    break;
                }
            }

            return id;
        }
        public bool ComprobarUsuario(Usuario auxUsuario)
        {
            bool validacion = false;
            List<Usuario> listaUsuarios = this.ObtenerLista();
            foreach (Usuario usuario in listaUsuarios)
            {
                if (auxUsuario == usuario)
                {
                    validacion = true;
                    break;
                }
            }
            return validacion;
        }

        public bool ComprobarUsuario(string nombreUsuario)
        {
            bool validacion = false;
            List<Usuario> listaUsuarios = this.ObtenerLista();
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario == nombreUsuario)
                {
                    validacion = true;
                    break;
                }
            }
            return validacion;
        }
    }
}
