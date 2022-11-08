using System;
using BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_;

namespace PROGRAM_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    class Program
    {
        static void Main(string[] args)
        {
            Carta cartaAux;
            int valor = 0; 

            foreach (EPalos palo in Enum.GetValues(typeof(EPalos)))
            {
                valor = 0;
                for (int i = 4; i < 13; i++)
                {
                    valor++;
                    if (i != 7)
                    {
                        cartaAux = new Carta(i, palo, valor);
                        JSON.SerializarJSON(cartaAux);
                    }
                    else
                    {
                        i = 9;
                    }         
                }

                valor = 8;
                for (int j = 2; j < 4; j++)
                {
                    valor++;
                    cartaAux = new Carta(j, palo, valor);
                    JSON.SerializarJSON(cartaAux);
                }

                switch (palo)
                {
                    case EPalos.ESPADA:
                        cartaAux = new Carta(7, palo, 12);
                        JSON.SerializarJSON(cartaAux);
                        break;
                    case EPalos.ORO:
                        cartaAux = new Carta(7, palo, 11);
                        JSON.SerializarJSON(cartaAux);
                        break;
                    default:
                        cartaAux = new Carta(7, palo, 4);
                        JSON.SerializarJSON(cartaAux);
                        break;
                }

                switch (palo)
                {
                    case EPalos.ESPADA:
                        cartaAux = new Carta(1, palo, 14);
                        JSON.SerializarJSON(cartaAux);
                        break;
                    case EPalos.BASTO:
                        cartaAux = new Carta(1, palo, 13);
                        JSON.SerializarJSON(cartaAux);
                        break;
                    default:
                        cartaAux = new Carta(1, palo, 8);
                        JSON.SerializarJSON(cartaAux);
                        break;
                }
            }
        }
    }
}
