using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            int heroesNum = int.Parse(Console.ReadLine());
            List<Heroe> heroes = new List<Heroe>();

            for (int i = 0; i < heroesNum; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = data[0];
                int hp = int.Parse(data[1]);
                int mp = int.Parse(data[2]);

                Heroe newHeroe = new Heroe(name, hp, mp);
                heroes.Add(newHeroe);
            }

            string command = Console.ReadLine();
            while (command.ToLower() != "end")
            {
                string[] data = command.Split(" - ");
                if (data[0].ToLower() == "castspell")
                {
                    string name = data[1];
                    int mp = int.Parse(data[2]);
                    string spellName = data[3];

                    h


                }
                else if (data[0].ToLower() == "takedamage")
                {

                }
                else if (data[0].ToLower() == "recharge")
                {

                }
                else if (data[0].ToLower() == "heal")
                {

                }



                command = Console.ReadLine();
            }


        }

    }
    class Heroe
    {

        public Heroe(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
    }
}
