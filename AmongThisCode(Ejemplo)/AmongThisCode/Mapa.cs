using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmongThisCode
{
    class Mapa
    {
        private int[,] ubicacionPersonaje;
        private int[,] ubicacionEnemigos;

        public Mapa(int tamano)
        {
            ubicacionPersonaje = new int[tamano, tamano];
            ubicacionEnemigos = new int[tamano, tamano];
        }

        public void ColocarPersonaje(Personaje personaje, int[] posicion)
        {
            
            personaje.Posicion = posicion;
            ubicacionPersonaje[posicion[0], posicion[1]] = 1;
        }

        public void ColocarEnemigo(Enemigo enemigo, int[] posicion)
        {
            
            ubicacionEnemigos[posicion[0], posicion[1]] = enemigo.Vida;
        }

        public bool VerificarEnemigo(Personaje personaje)
        {
            int vidaEnemigo = ubicacionEnemigos[personaje.Posicion[0], personaje.Posicion[1]];
            if (vidaEnemigo > 0)
            {
                Enemigo enemigo = new Enemigo(vidaEnemigo);
                return personaje.Pelear(enemigo);
            }
            return true;
        }
    }

}
