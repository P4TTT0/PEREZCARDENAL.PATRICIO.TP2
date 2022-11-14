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
        public void Cartas_Desiguales_OK()
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
        public void Cartas_Desiguales_MAL()
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
    public class Test_Parcial_ESTADISTICAS_
    {

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
            List<Carta> mazoUno = new List<Carta>();


            Carta cartaUno = new Carta(12, EPalos.COPA, 7);
            Carta cartaDos = new Carta(11, EPalos.COPA, 6);
            //20 DE ENVIDO.

            Carta cartaTres = new Carta(12, EPalos.ESPADA, 1);
            Carta cartaCuatro = new Carta(6, EPalos.ESPADA, 7);
            //26 DE ENVIDO.

            Carta cartaCinco = new Carta(7, EPalos.ESPADA, 6);
            Carta cartaSeis = new Carta(4, EPalos.ORO, 1);
            //7 DE ENVIDO.

            mazoUno.Add(cartaUno);
            mazoUno.Add(cartaDos);
            mazoUno.Add(cartaTres);

            List<Carta> mazoDos = new List<Carta>();

            //33 DE ENVIDO.

            mazoDos.Add(cartaCuatro);
            mazoDos.Add(cartaCinco);
            mazoDos.Add(cartaSeis);

            Partida partida = new Partida();

            bool validacion = partida.CalcularPosibleEnvido(cartaUno, cartaDos) == 20 && partida.CalcularPosibleEnvido(cartaTres, cartaCuatro) == 26 && partida.CalcularPosibleEnvido(cartaCinco, cartaSeis) == 7;

            //ASSERT
            Assert.IsTrue(validacion);
        }
    }
}
