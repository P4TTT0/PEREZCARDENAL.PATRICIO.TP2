using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public class ConexionEstadisticasUsuario : IBaseDatos<EstadisticasUsuario>
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector; 
        public ConexionEstadisticasUsuario()
        {
            this.conexion = new SqlConnection(IBaseDatos<Usuario>.CadenaConexion());
        }
        public List<EstadisticasUsuario> ObtenerLista()
        {
            List<EstadisticasUsuario> listaUsuarios = new List<EstadisticasUsuario>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM EstadisticasUsuarios";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    EstadisticasUsuario estadisticasUsuario = new EstadisticasUsuario();

                    estadisticasUsuario.Id = (int)this.lector[0];
                    estadisticasUsuario.PartidasGanadas = (int)this.lector[1];
                    estadisticasUsuario.PartidasPerdidas = (int)this.lector[2];
                    estadisticasUsuario.PartidasJugadas = (int)this.lector[3];
                    estadisticasUsuario.WinRate = (float)((double)this.lector[4]);

                    listaUsuarios.Add(estadisticasUsuario);
                }

                this.lector.Close();
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

            return listaUsuarios;
        }

        public EstadisticasUsuario ObtenerEstadisticasUsuario(int id)
        {
            EstadisticasUsuario estadisticas = new EstadisticasUsuario();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = $"SELECT * FROM EstadisticasUsuarios WHERE IdUsuario = {id}";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                this.lector.Read();

                estadisticas.Id = (int)(this.lector[0]);
                estadisticas.PartidasGanadas = (int)this.lector[1];
                estadisticas.PartidasPerdidas = (int)this.lector[2];
                estadisticas.PartidasJugadas = (int)this.lector[3];
                estadisticas.WinRate = float.Parse(this.lector[4].ToString());

                this.lector.Close();
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
                comandoSql += "'" + auxUsuario.Id + "'" + "," + 0 + "," + 0 + "," + 0 + "," + 0 + ")";

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

        public bool ModificarEstadisticasUsuario(EstadisticasUsuario estadisticasUsuario)
        {
            bool validacion = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@IdUsuario", estadisticasUsuario.Id);
                this.comando.Parameters.AddWithValue("@PartidasGanadas", estadisticasUsuario.PartidasGanadas);
                this.comando.Parameters.AddWithValue("@PartidasPerdidas", estadisticasUsuario.PartidasPerdidas);
                this.comando.Parameters.AddWithValue("@PartidasJugadas", estadisticasUsuario.PartidasJugadas);
                this.comando.Parameters.AddWithValue("@WinRate", estadisticasUsuario.WinRate);

                string comandoSql = "UPDATE EstadisticasUsuarios ";
                comandoSql += "SET PartidasGanadas = @PartidasGanadas, PartidasPerdidas = @PartidasPerdidas, PartidasJugadas = @PartidasJugadas, WinRate = @WinRate ";
                comandoSql += "WHERE IdUsuario = @IdUsuario";

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
    }
}
