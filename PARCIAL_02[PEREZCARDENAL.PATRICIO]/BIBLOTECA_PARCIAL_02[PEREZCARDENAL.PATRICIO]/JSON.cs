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
        /// <summary>
        /// Metodo que se encarga de serializar una carta.
        /// </summary>
        /// <param name="cartaAux"></param>
        /// <returns>TRUE: Si se pudo serializar la carta || FALSE: Si no se pudo serializar la carta. </returns>
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
                validacion = false;
            }

            return validacion;
        }
        /// <summary>
        /// Metodo que se encarga de deserializar un mazo de cartas en una lista para luego retornarla
        /// </summary>
        /// <returns>Un mazo de cartas</returns>
        public static List<Carta> DeserializarJSON()
        {
            List<Carta> listaCartas = new List<Carta>();
            Carta auxCarta;
            string json;

            try
            {
                using(JSON.reader = new StreamReader(JSON.path))
                {
                    while((json = JSON.reader.ReadLine()) is not null)
                    {
                        auxCarta = JsonSerializer.Deserialize<Carta>(json);

                        listaCartas.Add(auxCarta);
                    }

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
