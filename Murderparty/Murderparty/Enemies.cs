using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murderparty
{
    class Enemies
    {

        Random DiceIndex = new Random();
        int[] Enemy = new int[] { 1, 2, 3, 4, 5, 6 };
        int[] ArmMluck = new int[] { 0, 1, 2 };
        int[] luck = new int[] { 0, 1 };

        public int EnemyAttackP()
        {
            int EnemyP = 0, FEpunch = 5;
            EnemyP = FEpunch + Enemy[DiceIndex.Next(Enemy.Length)] + luck[DiceIndex.Next(luck.Length)];

            return EnemyP;
        }

        public int EnemyAttackK()
        {
            int fEKick = 7, EnemyK;
            EnemyK = fEKick + Enemy[DiceIndex.Next(Enemy.Length)] + luck[DiceIndex.Next(luck.Length)];
            return EnemyK;
        }
        public int EnemyDefense()
        {
            int armsMblock = 3, EnemyABlock = 0, pary = 0;

            pary = Enemy[DiceIndex.Next(Enemy.Length)] + ArmMluck[DiceIndex.Next(ArmMluck.Length )];

            if (pary > 4)
            {
                EnemyABlock = armsMblock + pary;
                return EnemyABlock;

            }
         
            else
            {
                EnemyABlock = armsMblock + pary;
                return EnemyABlock;
            }
        }

    }
}
