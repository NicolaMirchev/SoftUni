using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingExcersice
{
   public class Dummy
    {
        public Dummy(int attack, int hp)
        {
            HP = hp;
            Attack = attack;
        }
        public int Attack { get; set; }
        public int HP { get; set; }
    }
}
