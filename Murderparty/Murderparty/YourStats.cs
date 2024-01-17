using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murderparty
{
   
    class YourStats
    {
        Random DiceIndex = new Random();
        int[] MaleEn = new   int[] {1,2,3,4,5,6};
        int[] ArmMluck = new int[] { 0, 1, 2 };
        //int[] ArmFluck = new int[] { 0, 1, 2 };
        //int[] FemaleEn = new int[] { 1, 2, 3, 4, 5, 6 };
        int[] luck = new int []{ 0,1};

        public int MaleAttackP()
        {
            int YouPunch = 0, FMpunch = 3;
            YouPunch = FMpunch + MaleEn[DiceIndex.Next(MaleEn.Length)] + luck[DiceIndex.Next(luck.Length)];

            return YouPunch;
        }

        public int MaleAttackK()
        {
            int fMKick = 7, YouKick ;
            YouKick = fMKick + MaleEn[DiceIndex.Next(MaleEn.Length )] + luck[DiceIndex.Next(luck.Length )];
            return YouKick;
        }
        public int MaleDefense()
        {
            int armsMblock = 3, YouBlock = 0, pary = 0;

            pary = MaleEn[DiceIndex.Next(MaleEn.Length)] + ArmMluck[DiceIndex.Next(ArmMluck.Length)];

            if (pary > 3)
            {
                YouBlock = armsMblock + pary;
                return YouBlock;

            }

            else
            {
                YouBlock = armsMblock + pary;
                return YouBlock;
            }
        }

        //public void FemaleAttackP()
        //{
        //    int FFpunch = 2,YouPunch;
        //    YouPunch = FFpunch + FemaleEn[DiceIndex.Next(FemaleEn.Length)] + luck[DiceIndex.Next(luck.Length)];
        //}

        //public void FemaleAttackK()
        //{
        //    int fFkick = 6,YouKick;
        //    YouKick = fFkick+ FemaleEn[DiceIndex.Next(FemaleEn.Length)] + luck[DiceIndex.Next(luck.Length)];

        //}

        //public void femaleDefense()
        //{
        //    int armFblock = 1, YouABlock = 0, pary = 0;

        //    pary = ArmFluck[DiceIndex.Next(ArmFluck.Length)];

        //    if (pary == 0)
        //    {
        //        YouABlock = armFblock + 0;
        //        Console.WriteLine("You have taken impact of the strike");
        //    }
        //    else if (pary == 1)
        //    {
        //        YouABlock = armFblock + 1;
        //        Console.WriteLine("You managed to parry th strike away with your arms");
        //    }
        //    else
        //    {
        //        YouABlock = armFblock + 2;
        //        Console.WriteLine("You managed to evade the strike");

        //    }

        //}
    }
}
