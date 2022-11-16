using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public class EstadisticasUsuario
    {
        #region --ATRIBUTOS--
        private int id;
        private int partidasGanadas;
        private int partidasPerdidas;
        private int partidasJugadas;
        private float winRate;
        #endregion
        #region --PROPIEDADES--
        public int Id { get => id; set => id = value; }
        public int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }
        public int PartidasPerdidas { get => partidasPerdidas; set => partidasPerdidas = value; }
        public int PartidasJugadas { get => partidasJugadas; set => partidasJugadas = value; }
        public float WinRate { get => winRate; set => winRate = value; }
        #endregion
        #region --METODOS--
        /// <summary>
        /// Metodo que se encarga de actualizar el valor del WINRATE mediante una regla de 3 simple utilizando el valor de las partidas ganadas y las partidas jugadas.
        /// </summary>
        public void ActualizarWinRate()
        {
            this.winRate = (float)(this.partidasGanadas * 100) / this.partidasJugadas;
        }
        #endregion
    }
}
