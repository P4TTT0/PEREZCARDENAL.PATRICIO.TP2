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
        /// <summary>
        /// Sobrecarga del operador == para comparar el nombre de usuario y la contraseña entre dos usuarios
        /// </summary>
        /// <param name="usuarioUno"></param>
        /// <param name="usuarioDos"></param>
        /// <returns>TRUE: Si ambos usuarios poseen mismo nombre de usuario y contraseña || FALSE: Si por lo menos uno de los atributos del usuario a comparar es distinto </returns>
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
        /// <summary>
        /// Sobrecarga del operador == para comparar una el ID de un usuario con un ID pasado por parametro
        /// </summary>
        /// <param name="usuarioUno"></param>
        /// <param name="id"></param>
        /// <returns>TRUE: Si la el id del usuario es igual al id pasado por parametro || FALSE: Si la id de la usuario no es igual al id pasado por parametro</returns>
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
        /// <summary>
        /// Sobrecarga del operador == para comparar el nombre de un usuario con un nombre pasado por parametro
        /// </summary>
        /// <param name="usuarioUno"></param>
        /// <param name="nombreUsuario"></param>
        /// <returns>TRUE: Si la el nombre del usuario es igual al nombre pasado por parametro || FALSE: Si la nombre del usuario no es igual al nombre pasado por parametro</returns>
        public static bool operator ==(Usuario usuarioUno, string nombreUsuario)
        {
            bool validacion = false;

            if (usuarioUno is not null && nombreUsuario is not null)
            {
                validacion = usuarioUno.nombreUsuario == nombreUsuario;
            }

            return validacion;
        }

        public static bool operator !=(Usuario usuarioUno, string nombreUsuario)
        {
            return !(usuarioUno == nombreUsuario);
        }

        public override bool Equals(object obj)
        {
            bool validacion = false;
            if (obj is Usuario)
            {
                validacion = this == ((Usuario)obj);
            }

            return validacion;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
