using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class ArchivosXml<T> : IArchivos<T> where T : class, new()
    {
        public string path ="PartidasJugadas.xml";

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
