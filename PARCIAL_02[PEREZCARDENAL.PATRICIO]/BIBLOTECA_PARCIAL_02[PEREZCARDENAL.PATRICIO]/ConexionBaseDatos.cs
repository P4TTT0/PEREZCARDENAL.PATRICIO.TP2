using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public class ConexionBaseDatos
    {
        #region --ATRIBUTOS--
        private static string cadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        #endregion

        #region --CONSTRUCTORES--
        static ConexionBaseDatos()
        {
            ConexionBaseDatos.cadenaConexion = @"Data Source=DESKTOP-D2JIHPC;Initial Catalog=BaseDatosTruco;Integrated Security=True";
        }

        public ConexionBaseDatos()
        {
            this.conexion = new SqlConnection(ConexionBaseDatos.cadenaConexion);
        }
        #endregion

        #region --METODODOS--
        public bool ProbarConexion()
        {
            bool validacion = true;

            try
            {
                this.conexion.Open();
            }
            catch(Exception)
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

        public List<Usuario> ObtenerListaUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Usuarios";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario usuario = new Usuario();

                    usuario.NombreUsuario = lector[1].ToString();
                    usuario.Contraseña = lector[2].ToString();

                    listaUsuarios.Add(usuario);
                }

                lector.Close();
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

        public bool AgregarUsuario(Usuario usuario)
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

        public bool ComprobarUsuario(Usuario auxUsuario)
        {
            bool validacion = false;
            List<Usuario> listaUsuarios = this.ObtenerListaUsuarios();
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
        #endregion
    }
}
