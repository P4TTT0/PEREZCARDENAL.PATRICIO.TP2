using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public class Carta
    {
        #region --ATRIBUTOS--
        private int numero;
        private EPalos palo;
        private int valor;
        #endregion

        #region --PROPIEDADES--
        public int Numero { get => numero; set => numero = value; }
        public EPalos Palo { get => palo; set => palo = value; }
        public int Valor { get => valor; set => valor = value; }
        #endregion

        #region --CONSTRUCTORES--
        public Carta(int numero, EPalos palo, int valor)
        {
            this.numero = numero;
            this.palo = palo;
            this.valor = valor;
        }
        #endregion
    }
}
