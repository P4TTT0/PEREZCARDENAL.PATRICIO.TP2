using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLOTECA_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    public class Usuario
    {
        #region --ATRIBUTOS--
        private int id;
        private string nombreUsuario;
        private string contraseña;
        #endregion

        #region --PROPIEDADES-- 
        public int Id { get => id; set => id = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña;  set => contraseña = value; }
       
        #endregion

        #region --CONSTRUCTORES--
        public Usuario() { }
        public Usuario(string nombre, string contraseña)
        {
            this.nombreUsuario = nombre;
            this.contraseña = contraseña;
        }
        #endregion

        #region --METODOS--
        public static bool operator ==(Usuario usuarioUno, Usuario usuarioDos)
        {
            bool validacion = false;

            if (usuarioUno is not null && usuarioDos is not null)
            {
                validacion = usuarioUno.nombreUsuario == usuarioDos.nombreUsuario && usuarioUno.contraseña == usuarioDos.contraseña;
            }

            return validacion;
        }

        public static bool operator !=(Usuario usuarioUno, Usuario usuarioDos)
        {
            return !(usuarioUno == usuarioDos);
        }

        public static bool operator ==(Usuario usuarioUno, int id)
        {
            bool validacion = false;

            if (usuarioUno is not null && id > -1)
            {
                validacion = usuarioUno.id == id;
            }

            return validacion;
        }

        public static bool operator !=(Usuario usuarioUno, int id)
        {
            return !(usuarioUno == id);
        }
        #endregion
    }
}
