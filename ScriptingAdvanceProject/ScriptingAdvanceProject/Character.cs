using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingAdvanceProject
{
    abstract class Character
    {
        public int live = 1;
        public int powerLvl = 0;

        bool IsAlive()
        {
            if (live == 1)
                return true;
            else
                return false;
        }
    }
}
