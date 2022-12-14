using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_ 
{
    public class Salas
    {
        #region--ATRIBUTOS--
        private int id;
        private string nombreCreador;
        private DateTime fechaSalaCreada;
        private string estadoPartida;
        private int ronda;
        #endregion

        #region--PROPIEDADES--
        public int Id { get => id; set => id = value; }
        public string NombreCreador { get => nombreCreador; set => nombreCreador = value; }
        public DateTime FechaSalaCreada { get => fechaSalaCreada; set => fechaSalaCreada = value; }
        public string EstadoPartida { get => estadoPartida; set => estadoPartida = value; }
        public int Ronda { get => ronda; set => ronda = value; }
        #endregion

        #region--CONSTRUCTORES--
        #endregion

        #region--METODOS--  
        /// <summary>
        /// Sobrecarga del operador == para comparar una el ID de una sala con una ID pasada por parametro
        /// </summary>
        /// <param name="salaUno"></param>
        /// <param name="id"></param>
        /// <returns>TRUE: Si la el id de la sala es igual al id pasado por parametro || FALSE: Si la id de la sala no es igual al id pasado por parametro</returns>
        public static bool operator ==(Salas salaUno, int id)
        {
            bool validacion = false;

            if (salaUno is not null && id > -1)
            {
                validacion = salaUno.id == id;
            }

            return validacion;
        }

        public static bool operator !=(Salas salaUno, int id)
        {
            return !(salaUno == id);
        }

        public override bool Equals(object obj)
        {
            bool validacion = false;
            if (obj is Salas)
            {
                validacion = this == ((Salas)obj);
            }

            return validacion;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
