using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
            public void PlayerIsDead()
            {
                
                var player = new PlayerP();
                var strongerEnemy = new EnemyP();
                strongerEnemy.powerLvl = player.powerLvl + 1;

                
                var playerSurvives = player.CompareLvl(strongerEnemy);

                
                Assert.IsFalse(playerSurvives);
            }
        
    }
}
