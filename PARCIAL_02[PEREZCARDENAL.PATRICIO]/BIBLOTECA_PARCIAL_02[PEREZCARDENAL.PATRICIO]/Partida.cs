using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public class Partida
    {
        #region--ATRIBUTOS--
        private List<Carta> mazo;
        private int turno;
        private Jugador jugadorUno;
        private Jugador jugadorDos;
        private int ronda;
        private bool esNuevaMano;
        private int puntosQuieroEnvido;
        private int puntosNoQuieroEnvido;
        private int puntosQuieroTruco;
        private int puntosNoQuieroTruco;
        private int quienCanto;
        private const int maxPuntos = 15;
        private bool seCantoFaltaEnvido;
        private bool seCantoTruco;
        #endregion

        #region--PROPIEDADES--
        public List<Carta> Mazo { get => mazo; set => mazo = value; }
        public int Turno { get => turno; set => turno = value; }
        public Jugador JugadorUno { get => jugadorUno; set => jugadorUno = value; }
        public Jugador JugadorDos { get => jugadorDos; set => jugadorDos = value; }
        public int Ronda { get => ronda; set => ronda = value; }
        public bool EsNuevaMano { get => esNuevaMano; set => esNuevaMano = value; }
        public int PuntosQuieroEnvido { get => puntosQuieroEnvido; set => puntosQuieroEnvido = value; }
        public int PuntosNoQuieroEnvido { get => puntosNoQuieroEnvido; set => puntosNoQuieroEnvido = value; }
        public int PuntosQuieroTruco { get => puntosQuieroTruco; set => puntosQuieroTruco = value; }
        public int PuntosNoQuieroTruco { get => puntosNoQuieroTruco; set => puntosNoQuieroTruco = value; }
        public int QuienCanto { get => quienCanto; set => quienCanto = value; }
        public int MaxPuntos { get => maxPuntos; }
        public bool SeCantoFaltaEnvido { get => seCantoFaltaEnvido; set => seCantoFaltaEnvido = value; }
        public bool SeCantoTruco { get => seCantoTruco; set => seCantoTruco = value; }
        #endregion

        #region--CONSTRUCTORES--
        public Partida()
        {
            this.jugadorUno = new Jugador();
            this.jugadorDos = new Jugador();
        }
        #endregion

        #region
        public List<Carta> RepartirCartas(List<Carta> mazo)
        {
            List<Carta> auxMazo = new List<Carta>();
            Random numeroRandom = new Random();
            int indiceRandom;

            for (int i = 0; i < 3; i++)
            {
                indiceRandom = numeroRandom.Next(0, mazo.Count);
                auxMazo.Add(mazo[indiceRandom]);
                mazo.RemoveAt(indiceRandom);
            }

            return auxMazo;
        }

        public void EliminarCartaMazo(List<Carta> mazo, int indice)
        {
            mazo[indice] = null;
        }
        #endregion

        public int CambiarTurno()
        {
            if (this.turno == 1)
            {
                this.turno = 2;
            }
            else
            {
                this.turno = 1;
            }

            return this.turno;
        }

        public int CalcularEnvido(List<Carta> mazo)
        {
            //ENVIDO UNO 1 - 2 || 2 - 1
            //ENVIDO DOS 1 - 3 || 3 - 1
            //ENVIDO TRES 2 - 3 || 3 - 2

            int envido = 0;

            int envidoUno = this.CalcularPosibleEnvido(mazo[0], mazo[1]);
            int envidoDos = this.CalcularPosibleEnvido(mazo[0], mazo[2]);
            int envidoTres = this.CalcularPosibleEnvido(mazo[1], mazo[2]);

            if (envidoUno > envidoDos && envidoUno > envidoTres)
            {
                envido = envidoUno;
            }
            else
            {
                if (envidoDos > envidoTres)
                {
                    envido = envidoDos;
                }
                else
                {
                    envido = envidoTres;
                }
            }

            return envido;
        }

        private int CalcularPosibleEnvido(Carta cartaUno, Carta cartaDos)
        {
            int envido = 0;
            if (cartaUno == cartaDos)
            {
                envido = 20;

                if (cartaUno.Numero < 10)
                {
                    envido += cartaUno.Numero;
                }
                if (cartaDos.Numero < 10)
                {
                    envido += cartaDos.Numero;
                }
            }
            else
            {
   
                if (cartaUno.Numero > 9 && cartaDos.Numero > 9)
                {
                    envido = 0;
                }
                else
                {
                    if (cartaUno.Numero > 9 && cartaDos.Numero < 10)
                    {
                        envido = cartaDos.Numero;
                    }
                    else
                    {
                        if (cartaUno.Numero < 10 && cartaDos.Numero > 9)
                        {
                            envido = cartaUno.Numero;
                        }
                        else
                        {
                            if (cartaUno.Numero > cartaDos.Numero)
                            {
                                envido = cartaUno.Numero;
                            }
                            else
                            {
                                envido = cartaDos.Numero;
                            }
                        }
                    }
                }
                      
            }

            return envido;
        }
    }
}
