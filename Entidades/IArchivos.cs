using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Interfaz genérica para la serialización y deserialización de objetos.
    /// </summary>
    /// <typeparam name="T">Tipo de objeto a serializar y deserializar.</typeparam>
    public interface IArchivos<T> where T : class, new()
    {
        /// <summary>
        /// Serializa un objeto en un archivo.
        /// </summary>
        /// <param name="obj">Objeto a serializar.</param>
        /// <returns><c>true</c> si la serialización se realizó con éxito; de lo contrario, <c>false</c>.</returns>
        public bool Serializar(T obj);

        /// <summary>
        /// Deserializa un objeto desde un archivo.
        /// </summary>
        /// <returns>El objeto deserializado.</returns>
        public T Deserializar();   
    }
}
