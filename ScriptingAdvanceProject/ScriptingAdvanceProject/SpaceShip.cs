using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingAdvanceProject
{
    class SpaceShip
    {
        int[,] size;
        
        void CreatingSize(int height, int width)
        {
            size = new int[height, width];
        }
    }
}
