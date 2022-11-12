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

                    usuario.Id = (int)(lector["Id"]);
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

        public EstadisticasUsuario ObtenerEstadisticasUsuario(Usuario usuario)
        {
            EstadisticasUsuario estadisticas = new EstadisticasUsuario();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = $"SELECT * FROM EstadisticasUsuarios WHERE IdUsuario = {usuario.Id}";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                lector.Read();

                estadisticas.Id = (int)(lector[0]);
                estadisticas.PartidasGanadas = (int)lector[1];
                estadisticas.PartidasPerdidas = (int)lector[2];
                estadisticas.PartidasJugadas = (int)lector[3];
                estadisticas.WinRate = float.Parse(lector[4].ToString());

                lector.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return estadisticas;
        }

        public bool AgregarEstadisticasUsuario(Usuario auxUsuario)
        {
            bool validacion = true;

            try
            {
                string comandoSql = "INSERT INTO EstadisticasUsuarios VALUES (";
                comandoSql += "'" + this.RetornarIdUsuario(auxUsuario) + "'" + "," + 0 + "," + 0 + "," + 0 + "," + 0 + ")";

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
            catch
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

        public List<Salas> ObtenerListaSalas()
        {
            List<Salas> listaSalas = new List<Salas>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Salas";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Salas sala = new Salas();

                    sala.Id = (int)(lector[0]);
                    sala.NombreCreador = lector[1].ToString();
                    sala.FechaSalaCreada = (DateTime)lector[2];
                    sala.EstadoPartida = lector[3].ToString();
                    sala.Ronda = (int)lector[4];

                    listaSalas.Add(sala);
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

            return listaSalas;
        }

        public bool AgregarSala(Usuario usuario, int cantidadJugadores)
        {
            bool validacion = true;

            try
            {
                string comandoSql = "INSERT INTO Salas VALUES (";
                comandoSql += "'" + usuario.NombreUsuario + "'" + "," + "'" + DateTime.Now + "'" + "," + "'" + EEstadoPartida.EN_JUEGO.ToString() + "'" + "," + 1 + ")";

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

        public bool ModificarSala(Salas sala)
        {
            bool validacion = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Id", sala.Id);
                this.comando.Parameters.AddWithValue("@EstadoPartida", sala.EstadoPartida);
                this.comando.Parameters.AddWithValue("@Ronda", sala.Ronda);

                string comandoSql = "UPDATE Salas ";
                comandoSql += "SET EstadoPartida = @EstadoPartida, Ronda = @Ronda ";
                comandoSql += "WHERE Id = @Id";

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
            catch (Exception e)
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

        public int RetornarIdUsuario(Usuario auxUsuario)
        {
            int id = -1;
            List<Usuario> listaUsuarios = this.ObtenerListaUsuarios();
            foreach (Usuario usuario in listaUsuarios)
            {
                if (auxUsuario == usuario)
                {
                    id = usuario.Id;
                    break;
                }
            }
            return id;
        }
        #endregion
    }
}
