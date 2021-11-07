using System;
using System.Collections.Generic;

namespace Raiding
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> group = new List<BaseHero>();

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                if (type == "Druid")
                {
                    var newHero = new Druid(name);
                    group.Add(newHero);
                    Console.WriteLine(newHero.CastAbility());

                }
                else if (type == "Paladin")
                {
                    var newHero = new Paladin(name);
                    group.Add(newHero);
                    Console.WriteLine(newHero.CastAbility());
                }
                else if (type == "Rogue")
                {
                    var newHero = new Rogue(name);
                    group.Add(newHero);
                    Console.WriteLine(newHero.CastAbility());
                }
                else if (type == "Warrior")
                {
                    var newHero = new Warrior(name);
                    group.Add(newHero);
                    Console.WriteLine(newHero.CastAbility());
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }


            }

            int bossPower = int.Parse(Console.ReadLine());

            int powerSum = 0;
            foreach (var hero in group)
            {
                powerSum += hero.Power;
            }

            if (powerSum >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }


        }
    }
}
