using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingAdvanceProject
{
    class BoxShip
    {
        PlayerP player = new PlayerP();
        EnemyP enemy = new EnemyP();
        ObjectP objectP = new ObjectP();
        int room = 0;

        public BoxShip(PlayerP playerP, EnemyP enemyP, ObjectP obj)
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
        //Con que esto aún no está muy claro
    }
}
