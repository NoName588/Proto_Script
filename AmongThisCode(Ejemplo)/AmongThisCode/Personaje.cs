using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmongThisCode
{
    class Personaje
    {
        public int Vida { get; set; }
        public int[] Posicion { get; set; }

        public void Mover(int[] nuevaPosicion)
        {
            
        }

        public bool Pelear(Enemigo enemigo)
        {
            if (enemigo.Vida > this.Vida)
            {
                return false; 
            }
            else
            {
                this.Vida += enemigo.Vida; 
                return true;
            }
        }
    }

}
