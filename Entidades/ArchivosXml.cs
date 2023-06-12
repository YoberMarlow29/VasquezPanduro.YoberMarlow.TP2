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
        public bool Serializar(T obj, string path)
        {
            bool retorno=false;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    serializer.Serialize(fileStream, obj);
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar la lista en formato XML y guardar en el archivo '" + path + "': " + ex.Message, ex);
                retorno = false;
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
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                    using (FileStream fileStream = new FileStream(path, FileMode.Open))
                    {
                        List<T> lista = (List<T>)serializer.Deserialize(fileStream);
                        return aux;
                    }
                }
                else
                {
                    File.WriteAllText(path, string.Empty);
                    return new T();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar el archivo XML '" + path + "': " + ex.Message, ex);
            }
        }


    }
}
