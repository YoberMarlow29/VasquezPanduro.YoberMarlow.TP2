using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
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

        public Usuario() 
        {
            this.nombre = "";
            this.apellido = "";
            this.correo = "";
            this.clave = "";

        }
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
        public Usuario(string nombre, string apellido, string correo, string clave):this(correo,clave)
        {
            ValidarCampoString(nombre, out this.nombre);
            ValidarCampoString(apellido, out this.apellido);

        }
        public bool ComprobarClave(string clave)
        {
            return clave == this.clave;
        }
        public override string ToString()
        {
            return this.Correo;
        }
        public override int GetHashCode()
        {
            return this.id;
        }

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
        private void ValidarCampoEmail(string email, out string emailValidado)
        {
            emailValidado = string.Empty;
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                throw new Exception("No es un email válido.");
            }
            emailValidado = email;
        }
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
