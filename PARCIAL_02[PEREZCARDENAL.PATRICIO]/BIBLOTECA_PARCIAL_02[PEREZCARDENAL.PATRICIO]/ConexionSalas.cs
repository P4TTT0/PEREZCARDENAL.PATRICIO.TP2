using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public class ConexionSalas : IBaseDatos<Salas>
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public ConexionSalas()
        {
            this.conexion = new SqlConnection(IBaseDatos<Usuario>.CadenaConexion());
        }

        public List<Salas> ObtenerLista()
        {
            List<Salas> listaSalas = new List<Salas>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Salas";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    Salas sala = new Salas();

                    sala.Id = (int)(this.lector[0]);
                    sala.NombreCreador = this.lector[1].ToString();
                    sala.FechaSalaCreada = (DateTime)this.lector[2];
                    sala.EstadoPartida = this.lector[3].ToString();
                    sala.Ronda = (int)this.lector[4];

                    listaSalas.Add(sala);
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

            return listaSalas;
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

        public bool AgregarSala(Usuario usuario, int cantidadJugadores)
        {
            bool validacion = true;

            try
            {
                string comandoSql = "INSERT INTO Salas VALUES (";
                comandoSql += "'" + usuario.NombreUsuario + "'" + "," + "'" + DateTime.Now + "'" + "," + "'" + EEstadoPartida.SIN_COMENZAR.ToString() + "'" + "," + 1 + ")";

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
    }
}
