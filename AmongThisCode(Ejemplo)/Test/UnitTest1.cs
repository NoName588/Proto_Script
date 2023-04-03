using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Creamos una instancia de la clase Mapa con una matriz de tamaño 3x3
            Mapa mapa = new Mapa(3, 3);

            // Llenamos la matriz
            mapa.LlenarMatriz();

            // Comparamos el tamaño de la matriz con el tamaño esperado
            Assert.AreEqual(3, mapa.Matriz.GetLength(0));
            Assert.AreEqual(3, mapa.Matriz.GetLength(1));

        }
    }
}
