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

        public void Attack(Dummy dummy)
        {
            dummy.HP -= this.AttackPower;
            this.DurabilityPoints -= 1;
        }
    }
}
