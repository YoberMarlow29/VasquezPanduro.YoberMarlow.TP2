using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Representa a un usuario del sistema.
    /// </summary>
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string correo;
        private string clave;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }

        /// <summary>
        /// Crea una instancia de la clase Usuario con valores predeterminados.
        /// </summary>
        public Usuario() 
        {
            this.nombre = "";
            this.apellido = "";
            this.correo = "";
            this.clave = "";

        }
        /// <summary>
        /// Crea una instancia de la clase Usuario con el correo y la clave proporcionados.
        /// </summary>
        /// <param name="correo">El correo del usuario.</param>
        /// <param name="clave">La clave del usuario.</param>
        /// <exception cref="System.Exception">Se produce si ya existe un usuario con el mismo correo.</exception>
        public Usuario(string correo, string clave):this() 
        {

            if (ExisteUsuarioConMismoCorreo(correo))
            {
                throw new Exception("Ya existe un usuario con el mismo correo.");
            }
            else 
            {
                ValidarCampoEmail(correo, out this.correo);
                ValidarContrasenia(clave, out this.clave);
            }

        }
        /// <summary>
        /// Crea una instancia de la clase Usuario con los valores proporcionados.
        /// </summary>
        /// <param name="nombre">El nombre del usuario.</param>
        /// <param name="apellido">El apellido del usuario.</param>
        /// <param name="correo">El correo del usuario.</param>
        /// <param name="clave">La clave del usuario.</param>
        public Usuario(string nombre, string apellido, string correo, string clave):this(correo,clave)
        {
            ValidarCampoString(nombre, out this.nombre);
            ValidarCampoString(apellido, out this.apellido);

        }
        public override string ToString()
        {
            return this.Correo;
        }
        public override int GetHashCode()
        {
            return this.id;
        }

        /// <summary>
        /// Verifica si existe otro usuario con el mismo correo.
        /// </summary>
        /// <param name="correo">El correo a verificar.</param>
        /// <returns>
        ///   <c>true</c> si existe otro usuario con el mismo correo; de lo contrario, <c>false</c>.
        /// </returns>
        public bool ExisteUsuarioConMismoCorreo(string correo) 
        {
            ConexionBaseDeDatos ado = new ConexionBaseDeDatos();
            foreach (Usuario jugador in ado.ObtenerListaDeUsuarios())
            {
                if (jugador.ToString() == correo)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Valida un campo de tipo email y lo asigna a una variable de instancia.
        /// </summary>
        /// <param name="email">El email a validar.</param>
        /// <param name="emailValidado">Variable donde se almacenará el email validado.</param>
        /// <exception cref="System.Exception">Se produce si el email no es válido.</exception>
        private void ValidarCampoEmail(string email, out string emailValidado)
        {
            emailValidado = string.Empty;
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                throw new Exception("No es un email válido.");
            }
            emailValidado = email;
        }
        /// <summary>
        /// Valida una contraseña y la asigna a una variable de instancia.
        /// </summary>
        /// <param name="contraseniaAValidar">La contraseña a validar.</param>
        /// <param name="contraseniaValidado">Variable donde se almacenará la contraseña validada.</param>
        /// <exception cref="System.ArgumentNullException">Se produce si la contraseña es nula.</exception>
        /// <exception cref="System.FormatException">Se produce si la contraseña tiene una longitud menor a 8 caracteres.</exception>
        private void ValidarContrasenia(string contraseniaAValidar, out string contraseniaValidado)
        {
            contraseniaValidado = string.Empty;

            if (contraseniaAValidar is null)
            {
                throw new ArgumentNullException("La contraseña no puede ser nula");
            }
            else if (contraseniaAValidar.Length < 8)
            {
                throw new FormatException("La contraseña debe tener un largo de 8 caracteres");
            }
            else
            {
                contraseniaValidado = contraseniaAValidar;
            }
        }
        /// <summary>
        /// Valida un campo de tipo string y lo asigna a una variable de instancia.
        /// </summary>
        /// <param name="campo">El campo a validar.</param>
        /// <param name="campoValidado">Variable donde se almacenará el campo validado.</param>
        /// <exception cref="System.Exception">Se produce si el campo es nulo o vacío.</exception>
        private void ValidarCampoString(string campo, out string campoValidado)
        {
            if (string.IsNullOrEmpty(campo))
            {
                throw new Exception("Ingresar un valor válido.");
            }
            campoValidado = campo;
        }
    }
}
