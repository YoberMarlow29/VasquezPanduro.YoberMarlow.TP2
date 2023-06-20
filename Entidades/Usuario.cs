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
                this.correo = correo;
                this.clave = clave;
            }

        }
        public Usuario(string nombre, string apellido, string correo, string clave):this(correo,clave)
        {
            this.nombre = nombre;
            this.apellido = apellido;

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

    }
}
