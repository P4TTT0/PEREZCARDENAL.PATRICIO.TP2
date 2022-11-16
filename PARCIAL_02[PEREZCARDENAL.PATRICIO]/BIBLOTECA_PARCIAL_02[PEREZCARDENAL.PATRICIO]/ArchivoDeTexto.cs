using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public static class ArchivoDeTexto
    {
        public static StreamWriter streamWriter;
        public static StreamReader streamReader;
        public static string path;
        static ArchivoDeTexto()
        {
            ArchivoDeTexto.path = "HistorialPartidas";
        }

        public static bool GuardarHistorialSala(string historialPartida, int idSala)
        {
            bool validacion = false;
            try
            {
                using (ArchivoDeTexto.streamWriter = new StreamWriter(ArchivoDeTexto.path += $@"\Sala[{idSala}].txt"))
                {
                    ArchivoDeTexto.streamWriter.WriteLine(historialPartida);
                }
                validacion = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                validacion = false;
            }
            return validacion;
        }

        public static string LeerHistorialPartida(int idSala)
        {
            string historialPartida = "";

            try
            {
                using(ArchivoDeTexto.streamReader = new StreamReader(ArchivoDeTexto.path += $@"\Sala[{idSala}].txt"))
                {
                    historialPartida = ArchivoDeTexto.streamReader.ReadToEnd();
                }
            }
            catch(Exception e)
            {
                historialPartida = "¡ERROR EN CARGAR HISTORIAL O LA SALA NO POSEE UNO! (La partida pudo haberse jugado antes de la implementacion de los historiales)";
            }

            return historialPartida;
        }
    }

}
