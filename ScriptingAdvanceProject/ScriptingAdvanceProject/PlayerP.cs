using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingAdvanceProject
{
    class PlayerP : Character
    {
        ObjectP objectP = new ObjectP();
        EnemyP enemyP;

        void AddObject()
        {
            powerLvl += objectP.powerLvl;
        }

        bool CompareLvl(EnemyP enemyP)
        {
            if (powerLvl >= enemyP.powerLvl)
                return true;
            else
                return false;
        }
    }
}
