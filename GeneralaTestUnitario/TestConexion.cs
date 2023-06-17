using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralaTestUnitario
{
    [TestClass]
    public class TestConexion
    {
        [TestMethod]
        public void ProbarConexionABaseDeDatos() 
        {
            //arrange
            ConexionBaseDeDatos baseDeDatos = new ConexionBaseDeDatos();
            bool resultado;
            //act
            resultado = baseDeDatos.ProbarConexion();
            //assert
            Assert.IsTrue(resultado);
        }
    }
}
