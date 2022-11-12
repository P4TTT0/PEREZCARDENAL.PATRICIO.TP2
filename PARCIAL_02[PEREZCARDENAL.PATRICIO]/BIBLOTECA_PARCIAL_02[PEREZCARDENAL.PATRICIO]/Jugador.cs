using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public class Jugador
    {
        #region --ATRIBUTOS--
        private List<Carta> mazo;
        private int puntos;
        private int envido;
        private bool esMano;
        private bool tiroCarta;
        private int cantidadManosGanadas;
        #endregion
        #region --PROPIEDADES--
        public List<Carta> Mazo { get => mazo; set => mazo = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public int Envido { get => envido; set => envido = value; }
        public bool EsMano { get => esMano; set => esMano = value; }
        public bool TiroCarta { get => tiroCarta; set => tiroCarta = value; }
        public int CantidadManosGanadas { get => cantidadManosGanadas; set => cantidadManosGanadas = value; }
        #endregion
    }
}
