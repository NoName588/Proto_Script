namespace Tester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            
                // Creamos una instancia de la clase Mapa con una matriz de tamaño 3x3
                var mapa = new Mapa(3, 3);
                int i = 0;

            // Llenamos la matriz
            mapa.LlenarMatriz();

                // Comparamos el tamaño de la matriz con el tamaño esperado (3x3)
                Assert.AreEqual(3, mapa.Matriz.GetLength(0));
                Assert.AreEqual(3, mapa.Matriz.GetLength(1));
                {
                for ( int j = 0; j < mapa.Matriz.GetLength(1); j++)
                {
                    Assert.IsNotNull(mapa.Matriz[i, j]);
                }
                }

        }
    }
}