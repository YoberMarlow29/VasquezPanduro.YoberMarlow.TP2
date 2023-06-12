using System;
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
            throw new NotImplementedException();
        }
        public T Deserializar(string path)
        {
            throw new NotImplementedException();
        }


    }
}
