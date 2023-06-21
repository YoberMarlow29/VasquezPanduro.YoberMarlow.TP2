using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Clase que implementa la interfaz IArchivos para la serialización y deserialización de objetos en formato XML.
    /// </summary>
    /// <typeparam name="T">Tipo de objeto a serializar y deserializar.</typeparam>
    public class ArchivosXml<T> : IArchivos<T> where T : class, new()
    {
        public string path ="PartidasJugadas.xml";
        /// <summary>
        /// Serializa un objeto en un archivo XML.
        /// </summary>
        /// <param name="obj">Objeto a serializar.</param>
        /// <returns><c>true</c> si la serialización se realizó con éxito; de lo contrario, <c>false</c>.</returns>
        public bool Serializar(T obj)
        {
            bool retorno=false;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (FileStream fileStream = new FileStream(this.path, FileMode.Create))
                {
                    serializer.Serialize(fileStream, obj);
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar la lista en formato XML y guardar en el archivo '" + this.path + "': " + ex.Message, ex);
                retorno = false;
            }
            return retorno;
        }
        /// <summary>
        /// Deserializa un objeto desde un archivo XML.
        /// </summary>
        /// <returns>El objeto deserializado.</returns>
        public T Deserializar()
        {
            if (!File.Exists(this.path))
            {
                return default(T);
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (StreamReader reader = new StreamReader(this.path))
                {
                    return (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error durante la deserialización: " + ex.Message);
            }
        }

    }
}
