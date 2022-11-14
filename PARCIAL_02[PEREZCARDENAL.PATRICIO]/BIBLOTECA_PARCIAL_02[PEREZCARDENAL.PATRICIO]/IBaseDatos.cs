using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public interface IBaseDatos<T>
    {

        static string CadenaConexion()
        {
            return @"Data Source=DESKTOP-D2JIHPC;Initial Catalog=BaseDatosTruco;Integrated Security=True";
        }

        List<T> ObtenerLista();

    }
}
