using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivosJson<T> : IArchivos<T> where T : class, new()
    {
        public bool Serializar(T obj, string path)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            bool retorno;
            try
            {
                File.WriteAllText(path, json);
                retorno = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar el archivo '" + path + "': " + ex.Message, ex);
                retorno= false;
            }

            
            return retorno;
        }
        public T Deserializar(string path)
        {
            T aux = new T();
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                     aux = JsonConvert.DeserializeObject<T>(json);
                    return aux;
                }
                else
                {
                    File.WriteAllText(path, string.Empty);
                    return new T();
                }
            }
            catch (JsonSerializationException ex)
            {
                throw new JsonSerializationException("Error de deserialización en el archivo '" + path + "': " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar el archivo '" + path + "': " + ex.Message, ex);
            }
        }


    }
}
