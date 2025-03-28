using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;

namespace MyRPG
{
    public class GameLevel
    {
        private Hardness hardness;
        public Hardness GetHardness() => hardness;

        private int num;
        public int GetNumRooms() => num;

        private List<Enemy> enemyList;
        private int actualOnes = 0;
        public int GetNumEnemies() => actualOnes;

        public GameLevel(int num, Hardness hardness)
        {
            this.hardness = hardness;
            this.num = num;

            enemyList = new List<Enemy>();
            for(int i = 0; i < num; i++)
            {
                enemyList.Add(null);
            }
        }

        public void SetEnemyInRoom(int num, Enemy enemy)
        {
            if(enemyList[num] != null) return;
            enemyList[num] = enemy;
            actualOnes++;   
        }

        public void PrintEnemies()
        {
            foreach (Enemy enemy in enemyList)
            {
                if(enemy == null) continue;
                int index = enemyList.IndexOf(enemy);
                Console.WriteLine($"Room {index.ToRoman()}: {enemy.GetName()}");
            }
        }
    }
}