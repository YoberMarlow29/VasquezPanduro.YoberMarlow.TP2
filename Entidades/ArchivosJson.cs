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
        public string path= Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\" + "PartidasJugadas.Json";

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
