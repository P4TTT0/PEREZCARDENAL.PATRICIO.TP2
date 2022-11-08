using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public static class JSON
    {
        public static StreamWriter writer;
        public static StreamReader reader;
        public static string path;

        static JSON()
        {
            JSON.path = @"..\..\..\..\FORMS_PARCIAL_02[PEREZCARDENAL.PATRICIO]\bin\Debug\net5.0-windows\Mazo.Json";
        }

        public static bool SerializarJSON(Carta cartaAux)
        {
            bool validacion = false;

            try
            {
                using(JSON.writer = new StreamWriter(JSON.path, true))
                {
                    string json = JsonSerializer.Serialize(cartaAux);

                    JSON.writer.WriteLine(json);
                    validacion = true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return validacion;
        }

        public static List<Carta> DeserializarJSON()
        {
            List<Carta> listaCartas = new List<Carta>();
            Carta auxCarta;

            try
            {
                using(JSON.reader = new StreamReader(JSON.path))
                {
                    string json = JSON.reader.ReadToEnd();

                    auxCarta = JsonSerializer.Deserialize<Carta>(json);

                    listaCartas.Add(auxCarta);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return listaCartas;
        }
    }
}
