using Microsoft.VisualStudio.TestTools.UnitTesting;
using BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_;
using System.Collections.Generic;

namespace TEST_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    [TestClass]
    public class Test_Parcial_CARTA
    {
        [TestMethod]
        public void Cartas_Iguales_OK()
        {
            //ARRANGE
            Carta cartaUno = new Carta(12, EPalos.COPA, 7);
            Carta cartaDos = new Carta(11, EPalos.COPA, 6);
            Carta cartaTres = new Carta(4, EPalos.COPA, 1);
            Carta cartaCuatro = new Carta(1, EPalos.COPA, 14);

            //ACT
            bool validacion = (cartaUno == cartaDos) && (cartaTres == cartaCuatro);

            //ASSERT
            Assert.IsTrue(validacion);
        }

        [TestMethod]
        public void Cartas_Iguales_Mal()
        {
            //ARRANGE
            Carta cartaUno = new Carta(12, EPalos.COPA, 7);
            Carta cartaDos = new Carta(11, EPalos.ESPADA, 6);
            Carta cartaTres = new Carta(4, EPalos.ORO, 1);
            Carta cartaCuatro = new Carta(1, EPalos.BASTO, 14);
            //ACT
            bool validacion = (cartaUno == cartaDos) && (cartaTres == cartaCuatro);

            //ASSERT
            Assert.IsFalse(validacion);
        }

        [TestMethod]
        public void Cartas_Distintas_OK()
        {
            //ARRANGE
            Carta cartaUno = new Carta(12, EPalos.COPA, 7);
            Carta cartaDos = new Carta(11, EPalos.ESPADA, 6);
            Carta cartaTres = new Carta(4, EPalos.ORO, 1);
            Carta cartaCuatro = new Carta(1, EPalos.BASTO, 14);
            //ACT
            bool validacion = (cartaUno != cartaDos) && (cartaTres != cartaCuatro);

            //ASSERT
            Assert.IsTrue(validacion);
        }

        [TestMethod]
        public void Cartas_Distintas_MAL()
        {
            //ARRANGE
            Carta cartaUno = new Carta(12, EPalos.COPA, 7);
            Carta cartaDos = new Carta(11, EPalos.COPA, 6);
            Carta cartaTres = new Carta(4, EPalos.COPA, 1);
            Carta cartaCuatro = new Carta(1, EPalos.COPA, 14);

            //ACT
            bool validacion = (cartaUno != cartaDos) && (cartaTres != cartaCuatro);

            //ASSERT
            Assert.IsFalse(validacion);
        }
    }

    [TestClass]
    public class Test_Parcial_CONEXION_ESTADISTICAS_USUARIO
    {
        [TestMethod]
        public void ObtenerLista_OK()
        {
            //ARRANGE
            ConexionEstadisticasUsuario conexionEstadisticasUsuario = new ConexionEstadisticasUsuario();
            List<EstadisticasUsuario> listaEstadisticasUsuario;
            listaEstadisticasUsuario = conexionEstadisticasUsuario.ObtenerLista();

            //ACT
            bool validacion = listaEstadisticasUsuario.Count > 0;

            //ASSERT
            Assert.IsTrue(validacion);
        }

        [TestMethod]
        public void ObtenerEstadisticasUsuario_OK()
        {
            //ARRANGE
            ConexionEstadisticasUsuario conexionEstadisticasUsuario = new ConexionEstadisticasUsuario();
            EstadisticasUsuario EstadisticasUsuario;
            EstadisticasUsuario = conexionEstadisticasUsuario.ObtenerEstadisticasUsuario(0);

            //ACT
            bool validacion = EstadisticasUsuario is not null;

            //ASSERT
            Assert.IsTrue(validacion);
        }
    }

    [TestClass]
    public class Test_Parcial_JSON
    {
        [TestMethod]
        public void DeserializarJSON_OK()
        {
            //ARRANGE
            List<Carta> mazo;
            mazo = JSON.DeserializarJSON();

            //ACT
            bool validacion = mazo.Count > 0;

            //ASSERT
            Assert.IsTrue(validacion);
        }
    }

    [TestClass]
    public class Test_Parcial_PARTIDA
    {
        [TestMethod]
        public void Repartir_OK()
        {
            //ARRANGE
            List<Carta> mazoUno;
            List<Carta> mazoDos;
            Partida partida = new Partida();

            mazoUno = JSON.DeserializarJSON();
            mazoDos = partida.RepartirCartas(mazoUno);


            //ACT
            bool validacion = mazoDos.Count > 0;

            //ASSERT
            Assert.IsTrue(validacion);
        }

        [TestMethod]
        public void EliminarCarta_OK()
        {
            //ARRANGE
            List<Carta> mazoUno;
            Partida partida = new Partida();

            mazoUno = JSON.DeserializarJSON();
            partida.EliminarCartaMazo(mazoUno, 0);

            //ACT
            bool validacion = mazoUno[0] is null;

            //ASSERT
            Assert.IsTrue(validacion);
        }

        [TestMethod]
        public void CalcularPosibleEnvido_OK()
        {
            //ARRANGE
            Carta cartaUno = new Carta(12, EPalos.COPA, 7);
            Carta cartaDos = new Carta(11, EPalos.COPA, 6);
            //20 DE ENVIDO.

            Carta cartaTres = new Carta(12, EPalos.ESPADA, 1);
            Carta cartaCuatro = new Carta(6, EPalos.ESPADA, 7);
            //26 DE ENVIDO.

            Carta cartaCinco = new Carta(7, EPalos.ESPADA, 6);
            Carta cartaSeis = new Carta(4, EPalos.ORO, 1);
            //7 DE ENVIDO.

            Partida partida = new Partida();

            bool validacion = partida.CalcularPosibleEnvido(cartaUno, cartaDos) == 20 && partida.CalcularPosibleEnvido(cartaTres, cartaCuatro) == 26 && partida.CalcularPosibleEnvido(cartaCinco, cartaSeis) == 7;

            //ASSERT
            Assert.IsTrue(validacion);
        }

        [TestMethod]
        public void CalcularEnvido_OK()
        {

            //ARRANGE
            List<Carta> mazoUno = new List<Carta>();
            List<Carta> mazoDos = new List<Carta>();
            List<Carta> mazoTres = new List<Carta>();

            Partida partida = new Partida();


            Carta cartaUno = new Carta(12, EPalos.COPA, 0);
            Carta cartaDos = new Carta(11, EPalos.COPA, 0);
            Carta cartaTres = new Carta(6, EPalos.ESPADA, 0);
            //20 DE ENVIDO.

            Carta cartaCuatro = new Carta(6, EPalos.ESPADA, 0);
            Carta cartaCinco = new Carta(7, EPalos.ESPADA, 0);
            Carta cartaSeis = new Carta(4, EPalos.ESPADA, 0);
            //33 DE ENVIDO.

            Carta cartaSiete = new Carta(12, EPalos.ESPADA, 0);
            Carta cartaOcho = new Carta(7, EPalos.BASTO, 0);
            Carta cartaNueve = new Carta(4, EPalos.ORO, 0);
            //7 DE ENVIDO.

            mazoUno.Add(cartaUno);
            mazoUno.Add(cartaDos);
            mazoUno.Add(cartaTres);

            mazoDos.Add(cartaCuatro);
            mazoDos.Add(cartaCinco);
            mazoDos.Add(cartaSeis);

            mazoTres.Add(cartaSiete);
            mazoTres.Add(cartaOcho);
            mazoTres.Add(cartaNueve);


            //ACT
            bool validacion = partida.CalcularEnvido(mazoUno) == 20 && partida.CalcularEnvido(mazoDos) == 33 && partida.CalcularEnvido(mazoTres) == 7;

            //ASSERT
            Assert.IsTrue(validacion);
        }
    }


    [TestClass]
    public class Test_Parcial_SALAS
    {
        [TestMethod]
        public void Salas_Mismo_Indice_OK()
        {
            //ARRANGE
            ConexionSalas conexionSalas = new ConexionSalas();
            List<Salas> listaSalas = new List<Salas>();
            Salas sala = new Salas();

            listaSalas = conexionSalas.ObtenerLista();

            //ACT
            //En este caso la sala en la posicion 0 tiene el ID 1 - En caso de eliminar dicha sala esto romperia, pero es para hacer la prueba.
            bool validacion = listaSalas[0] == 1;

            //ASSERT
            Assert.IsTrue(validacion);
        }

        [TestMethod]
        public void Salas_Distinto_Indice_OK()
        {
            //ARRANGE
            ConexionSalas conexionSalas = new ConexionSalas();
            List<Salas> listaSalas = new List<Salas>();
            Salas sala = new Salas();

            listaSalas = conexionSalas.ObtenerLista();

            //ACT
            //En este caso la sala en la posicion 0 tiene el ID 1 - En caso de eliminar dicha sala esto romperia, pero es para hacer la prueba.
            bool validacion = listaSalas[0] != 3;

            //ASSERT
            Assert.IsTrue(validacion);
        }
    }

    [TestClass]
    public class Test_Parcial_USUARIO
    {
        [TestMethod]
        public void Usuarios_Iguales_OK()
        {
            //ARRANGE
            ConexionUsuario conexionUsuario = new ConexionUsuario();
            List<Usuario> listaUsuarios = new List<Usuario>();
            Usuario usuario = new Usuario("p4ttt0", "admin12");

            listaUsuarios = conexionUsuario.ObtenerLista();

            //ACT
            bool validacion = listaUsuarios[0] == usuario;

            //ASSERT
            Assert.IsTrue(validacion);

        }

        [TestMethod]
        public void Usuarios_Distintos_OK()
        {
            //ARRANGE
            ConexionUsuario conexionUsuario = new ConexionUsuario();
            List<Usuario> listaUsuarios = new List<Usuario>();
            Usuario usuario = new Usuario("p4ttt0", "0239123123");

            listaUsuarios = conexionUsuario.ObtenerLista();

            //ACT
            bool validacion = listaUsuarios[0] != usuario;

            //ASSERT
            Assert.IsTrue(validacion);

        }
    }
}
