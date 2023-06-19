﻿using Entidades;
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

        [TestMethod]
        public void AgregarJugadorABaseDeDatos() 
        {
            //arrange
            ConexionBaseDeDatos baseDeDatos = new ConexionBaseDeDatos();
            Jugador jugador = new Jugador("Jugador", 0, 0, 0);
            bool resultado;
            //act
            resultado = baseDeDatos.AgregarJugador(jugador);
            //assert
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void ModificarJugadorDeBaseDeDatos() 
        {
            //arrange
            ConexionBaseDeDatos baseDeDatos = new ConexionBaseDeDatos();
            Jugador jugador = new Jugador("Rodrigo", 0, 0, 0);
            bool resultado;
            //act
            resultado = baseDeDatos.ModificarJugador(jugador);
            //assert
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void ObtenerListaJugadoresDeBaseDeDatos() 
        {
            //arrange
            ConexionBaseDeDatos baseDeDatos = new ConexionBaseDeDatos();
            List<Jugador> lista = new List<Jugador>();
            //act
            lista = baseDeDatos.ObtenerListaDeJugadores();
            //assert
            Assert.IsNotNull(lista);
        }



    }
}
