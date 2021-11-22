using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingExcersice
{
   public class Axe
    {
        public Axe(int durabilityPoints, int attack)
        {
            DurabilityPoints = durabilityPoints;
            AttackPower = attack;
        }
        public int DurabilityPoints { get; private set; }
        public int AttackPower { get; private set; }

        public string Attack(Dummy dummy)
        {
            if (dummy.HP > 0)
            {
                dummy.HP -= AttackPower;
                DurabilityPoints -= 1;
                if (dummy.HP - AttackPower <= 0)
                {

                    return "Succssfully killed Dummy. \n " +
                        "Earned 10 Xp";
                }
                else
                {
                    return $"Dummy's Health now: {dummy.HP - AttackPower}";
                }
            }
            else
            {
                return "Dummy's already death.";
            }

            
        }
    }
}
