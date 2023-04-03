using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingAdvanceProject
{
    class TrapShip
    {

        PlayerP player = new PlayerP();
        EnemyP enemy = new EnemyP();
        ObjectP objectP = new ObjectP();
        int room = 0;
        int lvlAcces = 0;

        public TrapShip(PlayerP playerP, EnemyP enemyP, ObjectP obj)
        {
            this.player = playerP;
            this.enemy = enemyP;
            this.objectP = obj;
        }

        bool RoomClear()
        {
            if (room == 0)
                return true;
            else
                return false;
        }

        bool CompareLvl()
        {
            if (lvlAcces <= player.powerLvl)
                return true;
            else
                return false;
        }
    }
}
