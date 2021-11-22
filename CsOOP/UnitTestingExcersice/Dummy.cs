using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingExcersice
{
   public class Dummy
    {
        public Axe Wepon { get; set; }
        public Dummy(int attack, int xp, Axe axe)
        {
            Wepon = axe;
            HP = xp;
            XP = attack;
        }
        public int XP { get; set; }
        public int HP { get; set; }


    }
}
