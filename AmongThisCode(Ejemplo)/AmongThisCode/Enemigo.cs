using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmongThisCode
{
    public class Enemigo
    {
        private int vida;

        public Enemigo(int vida)
        {
            this.vida = vida;
        }

        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }
    }

}
