using BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_.FORMS_INTERNOS
{
    public partial class FormPartida : Form
    {
        private Salas sala;
        private Partida partida;
        private List<Carta> mazo;
        private Carta cartaTiradaJugadorUno;
        private Carta cartaTiradaJugadorDos;
        private delegate bool DelegadoQuieroEnvido(object sender, EventArgs e);
        private event DelegadoQuieroEnvido quieroEnvido;
        private bool banderaQuienCanto;

        private StringBuilder historialPartida;
        private EstadisticasUsuario estadisticasUsuario;

        private ConexionSalas conexionSalas;
        private ConexionEstadisticasUsuario conexionEstadisticasUsuario;
        public FormPartida()
        {
            InitializeComponent();
        }

        public FormPartida(Salas sala) : this()
        {
            this.sala = sala;
            this.partida = new Partida();
            this.historialPartida = new StringBuilder();
            this.conexionEstadisticasUsuario = new ConexionEstadisticasUsuario();
            this.conexionSalas = new ConexionSalas();
            this.estadisticasUsuario = new EstadisticasUsuario();
            this.quieroEnvido += this.EventoQuieroEnvido;
        }

        private void FormPartida_Load(object sender, EventArgs e)
        {

            this.mazo = JSON.DeserializarJSON();
            this.partida.Ronda = 1;
            this.partida.Turno = 1;
            this.banderaQuienCanto = true;
            this.partida.PuntosNoQuieroEnvido = 1;
            this.partida.PuntosNoQuieroTruco = 1;
            this.CambiarRonda();
            this.labelNumeroSala.Text = $"SALA {this.sala.Id}";

            this.estadisticasUsuario = this.conexionEstadisticasUsuario.ObtenerEstadisticasUsuario(FormLogin.UsuarioActual.Id);
        }

        private void MostrarCartas(List<Carta> mazo)
        {
            try
            {
                this.labelNumeroCarta1.Text = mazo[0].Numero.ToString();
                this.pictureBoxCarta1.Image = Image.FromFile(@$"..\..\..\Resources\{mazo[0].Palo.ToString()}_PALO.png");
                this.labelNumeroCarta1.Visible = true;
                this.pictureBoxCarta1.Visible = true;
            }
            catch (Exception)
            {
                this.labelNumeroCarta1.Text = null;
                this.labelNumeroCarta1.Visible = false;
                this.pictureBoxCarta1.Image = null;
                this.pictureBoxCarta1.Visible = false;
            }

            try
            {
                this.labelNumeroCarta2.Text = mazo[1].Numero.ToString();
                this.pictureBoxCarta2.Image = Image.FromFile(@$"..\..\..\Resources\{mazo[1].Palo.ToString()}_PALO.png");
                this.labelNumeroCarta2.Visible = true;
                this.pictureBoxCarta2.Visible = true;
            }
            catch (Exception)
            {
                this.labelNumeroCarta2.Text = null;
                this.labelNumeroCarta2.Visible = false;
                this.pictureBoxCarta2.Image = null;
                this.pictureBoxCarta2.Visible = false;
            }

            try
            {
                this.labelNumeroCarta3.Text = mazo[2].Numero.ToString();
                this.pictureBoxCarta3.Image = Image.FromFile(@$"..\..\..\Resources\{mazo[2].Palo.ToString()}_PALO.png");
                this.labelNumeroCarta3.Visible = true;
                this.pictureBoxCarta3.Visible = true;
            }
            catch (Exception)
            {
                this.labelNumeroCarta3.Text = null;
                this.labelNumeroCarta3.Visible = false;
                this.pictureBoxCarta3.Image = null;
                this.pictureBoxCarta3.Visible = false;
            }
        }

        private void pictureBoxCarta1_DoubleClick(object sender, EventArgs e)
        {  
            if (this.partida.Turno == 1)
            {
                this.labelMovimientoPartida.Text = $"Jugador 1 lanzo la carta: {this.partida.JugadorUno.Mazo[0].Numero} de {this.partida.JugadorUno.Mazo[0].Palo}";
                this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                this.partida.JugadorUno.TiroCarta = true;
                this.cartaTiradaJugadorUno = this.partida.JugadorUno.Mazo[0];

                this.labelCartaJugadorUno.Text = this.partida.JugadorUno.Mazo[0].Numero.ToString();
                this.pictureBoxCartaJugadorUno.Image = Image.FromFile(@$"..\..\..\Resources\{this.partida.JugadorUno.Mazo[0].Palo}_PALO.png");
                this.partida.EliminarCartaMazo(this.partida.JugadorUno.Mazo, 0);
                this.labelCartaJugadorUno.Visible = true;
            }
            else
            {
                this.labelMovimientoPartida.Text = $"Jugador 2 lanzo la carta: {this.partida.JugadorDos.Mazo[0].Numero} de {this.partida.JugadorDos.Mazo[0].Palo}";
                this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                this.partida.JugadorDos.TiroCarta = true;
                this.cartaTiradaJugadorDos = this.partida.JugadorDos.Mazo[0];

                this.labelCartaJugadorDos.Text = this.partida.JugadorDos.Mazo[0].Numero.ToString();
                this.pictureBoxCartaJugadorDos.Image = Image.FromFile(@$"..\..\..\Resources\{this.partida.JugadorDos.Mazo[0].Palo}_PALO.png");
                this.partida.EliminarCartaMazo(this.partida.JugadorDos.Mazo, 0);
                this.labelCartaJugadorDos.Visible = true;
            }
            this.CambiarMano();
        }

        private void pictureBoxCarta2_DoubleClick(object sender, EventArgs e)
        {
            if (this.partida.Turno == 1)
            {
                this.labelMovimientoPartida.Text = $"Jugador 1 lanzo la carta: {this.partida.JugadorUno.Mazo[1].Numero} de {this.partida.JugadorUno.Mazo[1].Palo}";
                this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                this.partida.JugadorUno.TiroCarta = true;
                this.cartaTiradaJugadorUno = this.partida.JugadorUno.Mazo[1];

                this.labelCartaJugadorUno.Text = this.partida.JugadorUno.Mazo[1].Numero.ToString();
                this.pictureBoxCartaJugadorUno.Image = Image.FromFile(@$"..\..\..\Resources\{this.partida.JugadorUno.Mazo[1].Palo}_PALO.png");
                this.partida.EliminarCartaMazo(this.partida.JugadorUno.Mazo, 1);
                this.labelCartaJugadorUno.Visible = true;
            }
            else
            {
                this.labelMovimientoPartida.Text = $"Jugador 2 lanzo la carta: {this.partida.JugadorDos.Mazo[1].Numero} de {this.partida.JugadorDos.Mazo[1].Palo}";
                this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                this.partida.JugadorDos.TiroCarta = true;
                this.cartaTiradaJugadorDos = this.partida.JugadorDos.Mazo[1];

                this.labelCartaJugadorDos.Text = this.partida.JugadorDos.Mazo[1].Numero.ToString();
                this.pictureBoxCartaJugadorDos.Image = Image.FromFile(@$"..\..\..\Resources\{this.partida.JugadorDos.Mazo[1].Palo}_PALO.png");
                this.partida.EliminarCartaMazo(this.partida.JugadorDos.Mazo, 1);
                this.labelCartaJugadorDos.Visible = true;
            }
            this.CambiarMano();
        }

        private void pictureBoxCarta3_DoubleClick(object sender, EventArgs e)
        {
            if (this.partida.Turno == 1)
            {
                this.labelMovimientoPartida.Text = $"Jugador 1 lanzo la carta: {this.partida.JugadorUno.Mazo[2].Numero} de {this.partida.JugadorUno.Mazo[2].Palo}";
                this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                this.partida.JugadorUno.TiroCarta = true;
                this.cartaTiradaJugadorUno = this.partida.JugadorUno.Mazo[2];

                this.labelCartaJugadorUno.Text = this.partida.JugadorUno.Mazo[2].Numero.ToString();
                this.pictureBoxCartaJugadorUno.Image = Image.FromFile(@$"..\..\..\Resources\{this.partida.JugadorUno.Mazo[2].Palo}_PALO.png");
                this.partida.EliminarCartaMazo(this.partida.JugadorUno.Mazo, 2);
                this.labelCartaJugadorUno.Visible = true;
            }
            else
            {
                this.labelMovimientoPartida.Text = $"Jugador 2 lanzo la carta: {this.partida.JugadorDos.Mazo[2].Numero} de {this.partida.JugadorDos.Mazo[2].Palo}";
                this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                this.partida.JugadorDos.TiroCarta = true;
                this.cartaTiradaJugadorDos = this.partida.JugadorDos.Mazo[2];

                this.labelCartaJugadorDos.Text = this.partida.JugadorDos.Mazo[2].Numero.ToString();
                this.pictureBoxCartaJugadorDos.Image = Image.FromFile(@$"..\..\..\Resources\{this.partida.JugadorDos.Mazo[2].Palo}_PALO.png");
                this.partida.EliminarCartaMazo(this.partida.JugadorDos.Mazo, 2);
                this.labelCartaJugadorDos.Visible = true;
            }
            this.CambiarMano();
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.DestaparCartas();
        }

        private void TaparCartas()
        {
            this.labelCambioTurno.Visible = true;
            this.pictureBoxTaparCartas.Visible = true;
            this.buttonAceptar.Visible = true;

            this.labelCambioTurno.Text = $"¡Cambio de turno a JUGADOR {this.partida.Turno}";
        }

        private void DestaparCartas()
        {
            this.labelCambioTurno.Visible = false;
            this.pictureBoxTaparCartas.Visible = false;
            this.buttonAceptar.Visible = false;
        }

        private void CambiarRonda()
        {
            this.pictureBoxCarta1.Enabled = true;
            this.pictureBoxCarta2.Enabled = true;
            this.pictureBoxCarta3.Enabled = true;

            this.buttonEnvido.Visible = true;
            this.buttonRealEnvido.Visible = true;
            this.buttonFaltaEnvido.Visible = true;

            this.labelNumeroRonda.Text = this.partida.Ronda.ToString();

            if (this.partida.JugadorUno.EsMano)
            {
                this.partida.Turno = 2;
                this.partida.JugadorUno.EsMano = false;
                this.partida.JugadorDos.EsMano = true;
                this.TaparCartas();
            }
            else
            {
                this.partida.Turno = 1;
                this.partida.JugadorUno.EsMano = true;
                this.partida.JugadorDos.EsMano = false;
                this.TaparCartas();
            }
            this.buttonEnvido.Visible = true;
            this.buttonFaltaEnvido.Visible = true;
            this.buttonRealEnvido.Visible = true;
            //REINICIAMOS LAS CARTAS EN MESA
            this.labelCartaJugadorUno.Visible = false;
            this.labelCartaJugadorDos.Visible = false;
            this.pictureBoxCartaJugadorUno.Image = null;
            this.pictureBoxCartaJugadorDos.Image = null;
            //MEZCLAMOS CARTAS
            this.mazo = this.mazo = JSON.DeserializarJSON();
            //REINICIAMOS CONTADOR DE MANOS GANADAS
            this.partida.JugadorUno.CantidadManosGanadas = 0;
            this.partida.JugadorDos.CantidadManosGanadas = 0;
            //AUMENTAMOS EL CONTADOR DE RONDA
            this.partida.Ronda++;
            //REPARTIMOS CARTAS
            this.partida.JugadorUno.Mazo = null;
            this.partida.JugadorUno.Mazo = this.partida.RepartirCartas(this.mazo);
            this.partida.JugadorDos.Mazo = null;
            this.partida.JugadorDos.Mazo = this.partida.RepartirCartas(this.mazo);
            //MOSTRAMOS LAS CARTAS
            if (this.partida.Turno == 1)
            {
                this.MostrarCartas(this.partida.JugadorUno.Mazo);
            }
            else
            {
                this.MostrarCartas(this.partida.JugadorDos.Mazo);
            }
            //CALCULAMOS ENVIDO
            this.partida.JugadorUno.Envido = this.partida.CalcularEnvido(this.partida.JugadorUno.Mazo);
            this.partida.JugadorDos.Envido = this.partida.CalcularEnvido(this.partida.JugadorDos.Mazo);
            //COMPROBAMOS VICTORIA
            this.ComprobarVictoria();

            this.buttonTruco.Text = "TRUCO";
            this.partida.PuntosNoQuieroTruco = 1;
            this.partida.PuntosQuieroTruco = 1;
            this.partida.PuntosNoQuieroEnvido = 1;
            this.buttonTruco.Visible = true;

            this.partida.SeCantoFaltaEnvido = false;
            this.partida.SeCantoTruco = false;

            this.ActualizarInterfazGrafica();
        }

        private void CambiarMano()
        {
            this.partida.CambiarTurno(); 
            this.TaparCartas();

            if (this.partida.JugadorUno.TiroCarta && this.partida.JugadorDos.TiroCarta)
            {
                this.buttonEnvido.Visible = false;
                this.buttonFaltaEnvido.Visible = false;
                this.buttonRealEnvido.Visible = false;

                if (this.cartaTiradaJugadorUno.Valor > this.cartaTiradaJugadorDos.Valor)
                {
                    this.partida.JugadorUno.CantidadManosGanadas++;
                    if (this.partida.Turno == 2)
                    {
                        this.partida.CambiarTurno();
                        this.TaparCartas();
                        this.MostrarCartas(this.partida.JugadorUno.Mazo);
                    }
                    else
                    {
                        this.TaparCartas();
                        this.MostrarCartas(this.partida.JugadorUno.Mazo);
                    }
                    if (this.partida.JugadorUno.CantidadManosGanadas == 2)
                    {
                        this.partida.JugadorUno.Puntos += this.partida.PuntosQuieroTruco;
                        this.labelMovimientoPartida.Text = $"Jugador 1 GANO la RONDA";
                        this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                        this.CambiarRonda();
                    }
                }
                else
                {
                    this.partida.JugadorDos.CantidadManosGanadas++;
                    if (this.partida.Turno == 1)
                    {
                        this.partida.CambiarTurno();
                        this.TaparCartas();
                        this.MostrarCartas(this.partida.JugadorDos.Mazo);
                    }
                    else
                    {
                        this.TaparCartas();
                        this.MostrarCartas(this.partida.JugadorDos.Mazo);
                    }
                    if (this.partida.JugadorDos.CantidadManosGanadas == 2)
                    {   
                        this.partida.JugadorDos.Puntos += this.partida.PuntosQuieroTruco;
                        this.labelMovimientoPartida.Text = $"Jugador 2 GANO la RONDA";
                        this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                        this.CambiarRonda();
                    }
                }
                this.partida.JugadorUno.TiroCarta = false;
                this.partida.JugadorDos.TiroCarta = false;
            }
            else
            {
                if (this.partida.Turno == 1)
                {
                    this.MostrarCartas(this.partida.JugadorUno.Mazo);
                }
                else
                {
                    this.MostrarCartas(this.partida.JugadorDos.Mazo);
                }
            }
            this.labelTurnoJugador.Text = $"JUGADOR: {this.partida.Turno}";

            //EVALUAMOS QUIEN ES MANO PARA MOSTRARLE EL BOTON DEL TRUCO O NO.
            this.MostrarBotonTruco();
        }

        private void ActualizarInterfazGrafica()
        {;
            this.labelPuntosJugadorUno.Text = this.partida.JugadorUno.Puntos.ToString();
            this.labelPuntoJugadorDos.Text = this.partida.JugadorDos.Puntos.ToString();
            this.labelTurnoJugador.Text = $"JUGADOR: {this.partida.Turno}";
        }

        private void Envido()
        { 
            this.partida.CambiarTurno();
            this.TaparCartas();
            this.labelTurnoJugador.Text = $"JUGADOR: {this.partida.Turno}";

            if (this.partida.Turno == 1)
            {
                this.MostrarCartas(this.partida.JugadorUno.Mazo);
            }
            else
            {
                this.MostrarCartas(this.partida.JugadorDos.Mazo);
            }

            this.pictureBoxCarta1.Enabled = false;
            this.pictureBoxCarta2.Enabled = false;
            this.pictureBoxCarta3.Enabled = false;

            this.buttonTruco.Visible = false;

            this.buttonQuiero.Visible = true;
            this.buttonNoQuiero.Visible = true;
        }

        private void buttonQuiero_Click(object sender, EventArgs e)
        {
            if (this.partida.SeCantoTruco)
            {
                this.labelMovimientoPartida.Text = $"Jugador {this.partida.Turno} dijo QUIERO";
                this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                this.partida.PuntosQuieroEnvido = 0;
                this.partida.PuntosNoQuieroEnvido = 1;
            }
            else
            {
                if (this.quieroEnvido(sender, e))
                {
                    this.labelMovimientoPartida.Text = $"Jugador 1 GANO el envido con {this.partida.JugadorUno.Envido} PUNTOS";
                    this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                }
                else
                {
                    this.labelMovimientoPartida.Text = $"Jugador 2 GANO el envido con {this.partida.JugadorDos.Envido} PUNTOS";
                    this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                }
                this.partida.PuntosNoQuieroEnvido = 0;
            }

            if (this.partida.QuienCanto == 1)
            {
                this.partida.Turno = 1;
                this.TaparCartas();
                this.MostrarCartas(this.partida.JugadorUno.Mazo);
                this.labelTurnoJugador.Text = $"JUGADOR: {this.partida.Turno}";
            }
            else
            {
                this.partida.Turno = 2;
                this.TaparCartas();
                this.MostrarCartas(this.partida.JugadorDos.Mazo);
                this.labelTurnoJugador.Text = $"JUGADOR: {this.partida.Turno}";
            }

            this.pictureBoxCarta1.Enabled = true;
            this.pictureBoxCarta2.Enabled = true;
            this.pictureBoxCarta3.Enabled = true;

            this.buttonEnvido.Visible = false;
            this.buttonRealEnvido.Visible = false;
            this.buttonFaltaEnvido.Visible = false;
            this.buttonQuiero.Visible = false;
            this.buttonNoQuiero.Visible = false;

            this.MostrarBotonTruco();

            this.banderaQuienCanto = true;
        }

        private bool EventoQuieroEnvido(object sender, EventArgs e)
        {
            bool ganoJugadorUno = false;

            if (this.partida.JugadorUno.Envido > this.partida.JugadorDos.Envido)
            {    
                if (this.partida.SeCantoFaltaEnvido)
                {
                    this.partida.JugadorUno.Puntos += this.partida.MaxPuntos - this.partida.JugadorDos.Puntos;
                }
                else
                {
                    this.partida.JugadorUno.Puntos += this.partida.PuntosQuieroEnvido;
                }
                ganoJugadorUno = true;
            }
            else
            {
                if (this.partida.JugadorUno.Envido < this.partida.JugadorDos.Envido)
                {
                    if (this.partida.SeCantoFaltaEnvido)
                    {
                        this.partida.JugadorDos.Puntos += this.partida.MaxPuntos - this.partida.JugadorUno.Puntos;
                    }
                    else
                    {
                        this.partida.JugadorDos.Puntos += this.partida.PuntosQuieroEnvido;
                    }
                    ganoJugadorUno = false;
                }
                else
                {
                    if (this.partida.JugadorUno.EsMano)
                    {
                        if (this.partida.SeCantoFaltaEnvido)
                        {
                            this.partida.JugadorUno.Puntos += this.partida.MaxPuntos - this.partida.JugadorDos.Puntos;
                        }
                        else
                        {
                            this.partida.JugadorUno.Puntos += this.partida.PuntosQuieroEnvido;
                        }
                        ganoJugadorUno = true;
                    }
                    else
                    {
                        if (this.partida.SeCantoFaltaEnvido)
                        {
                            this.partida.JugadorDos.Puntos += this.partida.MaxPuntos - this.partida.JugadorUno.Puntos;
                        }
                        else
                        {
                            this.partida.JugadorDos.Puntos += this.partida.PuntosQuieroEnvido;
                        }
                        ganoJugadorUno = false;
                    }
                }
            }

            return ganoJugadorUno;
        }
        private void QuienCanto()
        {
            if (this.banderaQuienCanto)
            {
                if (this.partida.Turno == 1)
                {
                    this.partida.QuienCanto = 1;

                }
                else
                {
                    this.partida.QuienCanto = 2;
                }
                banderaQuienCanto = false;
            }
        }

        private void buttonEnvido_Click(object sender, EventArgs e)
        {
            this.labelMovimientoPartida.Text = $"Jugador {this.partida.Turno} cantó ENVIDO";
            this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
            this.QuienCanto();
            if (this.partida.PuntosQuieroEnvido != 0)
            {
                this.partida.PuntosNoQuieroEnvido = this.partida.PuntosQuieroEnvido;
            }
            this.partida.PuntosQuieroEnvido += 2;
            if (this.partida.PuntosQuieroEnvido > 2)
            {
                this.buttonEnvido.Visible = false;
            }
            this.Envido(); 
        }

        private void buttonRealEnvido_Click(object sender, EventArgs e)
        {
            this.labelMovimientoPartida.Text = $"Jugador {this.partida.Turno} cantó REAL ENVIDO";
            this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
            this.QuienCanto();
            if (this.partida.PuntosQuieroEnvido != 0)
            {
                this.partida.PuntosNoQuieroEnvido = this.partida.PuntosQuieroEnvido;
            }
            this.partida.PuntosQuieroEnvido += 3;
            this.Envido();
            this.buttonEnvido.Visible = false;
            this.buttonRealEnvido.Visible = false;
        }

        private void buttonFaltaEnvido_Click(object sender, EventArgs e)
        {
            this.labelMovimientoPartida.Text = $"Jugador {this.partida.Turno} cantó FALTA ENVIDO";
            this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
            this.QuienCanto();
            this.partida.SeCantoFaltaEnvido = true;
            if (this.partida.PuntosQuieroEnvido != 0)
            {
                this.partida.PuntosNoQuieroEnvido = this.partida.PuntosQuieroEnvido;
            }
            this.Envido();
            this.buttonEnvido.Visible = false;
            this.buttonRealEnvido.Visible = false;
            this.buttonFaltaEnvido.Visible = false;
        }

        private void buttonTruco_Click(object sender, EventArgs e)
        {
            this.labelMovimientoPartida.Text = $"Jugador {this.partida.Turno} cantó ";

            if (this.partida.PuntosQuieroTruco != 1)
            {
                this.partida.PuntosNoQuieroTruco++;
            }
            this.partida.PuntosQuieroTruco++;
            this.QuienCanto();
            switch(this.partida.PuntosQuieroTruco)
            {
                case 2:
                    this.buttonTruco.Text = "RETRUCO";
                    this.labelMovimientoPartida.Text += "TRUCO";
                    this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                    break;
                case 3:
                    this.buttonTruco.Text = "VALE CUATRO";
                    this.labelMovimientoPartida.Text += "RETRUCO";
                    this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                    break;
                case 4:
                    this.buttonTruco.Visible = false;
                    this.labelMovimientoPartida.Text += "VALE CUATRO";
                    this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                    break;
            }
            this.Truco();

        }
        private void Truco()
        {
            this.partida.CambiarTurno();
            this.TaparCartas();
            this.labelTurnoJugador.Text = $"JUGADOR: {this.partida.Turno}";

            if (this.partida.Turno == 1)
            {
                this.MostrarCartas(this.partida.JugadorUno.Mazo);
            }
            else
            {
                this.MostrarCartas(this.partida.JugadorDos.Mazo);
            }

            this.pictureBoxCarta1.Enabled = false;
            this.pictureBoxCarta2.Enabled = false;
            this.pictureBoxCarta3.Enabled = false;

            this.buttonEnvido.Visible = false;
            this.buttonRealEnvido.Visible = false;
            this.buttonFaltaEnvido.Visible = false;

            this.buttonQuiero.Visible = true;
            this.buttonNoQuiero.Visible = true;

            this.partida.SeCantoTruco = true;
        }

        private void MostrarBotonTruco()
        {
            if (this.partida.PuntosQuieroTruco > 3)
            {
                this.buttonTruco.Visible = false;
            }
            else
            {
                if (this.partida.SeCantoTruco)
                {
                    if (this.partida.Turno == this.partida.QuienCanto)
                    {
                        this.buttonTruco.Visible = false;
                    }
                    else
                    {
                        this.buttonTruco.Visible = true;
                    }
                }
                else
                {
                    this.buttonTruco.Visible = true;
                }
            }     
        }

        private void buttonNoQuiero_Click(object sender, EventArgs e)
        {
            this.labelMovimientoPartida.Text = $"Jugador {this.partida.Turno} dijo NO QUIERO";
            this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
            if (this.partida.SeCantoTruco)
            {
                if (this.partida.Turno == 1)
                {
                    this.partida.JugadorDos.Puntos += this.partida.PuntosNoQuieroTruco;
                }
                else
                {
                    this.partida.JugadorUno.Puntos += this.partida.PuntosNoQuieroTruco;
                }
                this.CambiarRonda();
            }
            else
            {
                if (this.partida.Turno == 1)
                {
                    this.partida.JugadorDos.Puntos += this.partida.PuntosNoQuieroEnvido;
                }
                else
                {
                    this.partida.JugadorUno.Puntos += this.partida.PuntosNoQuieroEnvido;
                }
                this.buttonTruco.Visible = true;
                this.pictureBoxCarta1.Enabled = true;
                this.pictureBoxCarta2.Enabled = true;
                this.pictureBoxCarta3.Enabled = true;

                if (this.partida.QuienCanto == 1)
                {
                    this.partida.Turno = 1;
                    this.TaparCartas();
                    this.MostrarCartas(this.partida.JugadorUno.Mazo);
                    this.labelTurnoJugador.Text = $"JUGADOR: {this.partida.Turno}";
                }
                else
                {
                    this.partida.Turno = 2;
                    this.TaparCartas();
                    this.MostrarCartas(this.partida.JugadorDos.Mazo);
                    this.labelTurnoJugador.Text = $"JUGADOR: {this.partida.Turno}";
                }

                this.ActualizarInterfazGrafica();
            }

            this.buttonQuiero.Visible = false;
            this.buttonNoQuiero.Visible = false;

            this.buttonEnvido.Visible = false;
            this.buttonRealEnvido.Visible = false;
            this.buttonFaltaEnvido.Visible = false;
        }

        private void buttonMazo_Click(object sender, EventArgs e)
        {
            if (this.partida.Turno == 1)
            {
                this.labelMovimientoPartida.Text = $"Jugador 1 se fue al MAZO";
                this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                this.partida.JugadorDos.Puntos += this.partida.PuntosNoQuieroEnvido;
                this.partida.JugadorDos.Puntos += this.partida.PuntosNoQuieroTruco;
            }
            else
            {
                this.labelMovimientoPartida.Text = $"Jugador 2 se fue al MAZO";
                this.historialPartida.AppendLine(this.labelMovimientoPartida.Text);
                this.partida.JugadorUno.Puntos += this.partida.PuntosNoQuieroEnvido;
                this.partida.JugadorUno.Puntos += this.partida.PuntosNoQuieroTruco;
            }
            this.CambiarRonda();
        }

        private void ComprobarVictoria()
        {
            if (this.partida.JugadorUno.Puntos > 14)
            {
                MessageBox.Show("¡Ganó el jugador 1!", "VICTORIA");
                this.estadisticasUsuario.PartidasGanadas++;
                this.estadisticasUsuario.PartidasJugadas++;
                this.TerminarPartida();
            }
            else
            {
                if(this.partida.JugadorDos.Puntos > 14)
                {
                    MessageBox.Show("¡Ganó el jugador 2!", "VICTORIA");
                    this.estadisticasUsuario.PartidasPerdidas++;
                    this.estadisticasUsuario.PartidasJugadas++;
                    this.TerminarPartida();
                }
            }
        }

        private void TerminarPartida()
        {
            this.estadisticasUsuario.ActualizarWinRate();
            this.DialogResult = DialogResult.OK;
            this.sala.Ronda = this.partida.Ronda;
            this.sala.EstadoPartida = EEstadoPartida.TERMINADA.ToString();
            this.conexionSalas.ModificarSala(sala);
            this.conexionEstadisticasUsuario.ModificarEstadisticasUsuario(this.estadisticasUsuario);
        }
    }
}
