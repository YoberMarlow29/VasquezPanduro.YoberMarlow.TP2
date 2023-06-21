using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que implementa la interfaz IArchivos para la serialización y deserialización de objetos en formato JSON.
    /// </summary>
    /// <typeparam name="T">Tipo de objeto a serializar y deserializar.</typeparam>
    public class ArchivosJson<T> : IArchivos<T> where T : class, new()
    {
        public string path="PartidasJugadas.Json";

        /// <summary>
        /// Serializa un objeto en un archivo JSON.
        /// </summary>
        /// <param name="obj">Objeto a serializar.</param>
        /// <returns><c>true</c> si la serialización se realizó con éxito; de lo contrario, <c>false</c>.</returns>
        public bool Serializar(T obj)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            bool retorno;
            try
            {
                File.WriteAllText(this.path, json);
                retorno = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar el archivo '" + this.path + "': " + ex.Message, ex);
                retorno= false;
            }
            
            return retorno;
        }
        /// <summary>
        /// Deserializa un objeto desde un archivo JSON.
        /// </summary>
        /// <returns>El objeto deserializado.</returns>
        public T Deserializar()
        {
            T aux = new T();
            try
            {
                if (File.Exists(this.path))
                {
                    string json = File.ReadAllText(this.path);
                     aux = JsonConvert.DeserializeObject<T>(json);
                    return aux;
                }
                else
                {
                    File.WriteAllText(this.path, string.Empty);
                    return new T();
                }
            }
            catch (JsonSerializationException ex)
            {
                throw new JsonSerializationException("Error de deserialización en el archivo '" + this.path + "': " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar el archivo '" + this.path + "': " + ex.Message, ex);
            }
        }
    }
}
