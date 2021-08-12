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
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();

            for (int i = 0; i < heroesNum; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = data[0];
                int hp = int.Parse(data[1]);
                int mp = int.Parse(data[2]);

                if (!heroes.ContainsKey(name))
                {
                    heroes.Add(name, new int[] { hp, mp });
                }
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

                    if (heroes[name][1] - mp >= 0)
                    {
                        heroes[name][1] -= mp;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[name][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!"); 
                    }


                }
                else if (data[0].ToLower() == "takedamage")
                {
                    string name = data[1];
                    int damage = int.Parse(data[2]);
                    string atackerName = data[3];

                    heroes[name][0] -= damage;
                    if (heroes[name][0] > 0)
                    {
                     Console.WriteLine($"{name} was hit for {damage} HP by {atackerName} and now has {heroes[name][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {atackerName}!");
                        heroes.Remove(name);
                    }
                }
                else if (data[0].ToLower() == "recharge")
                {
                    string name = data[1];
                    int mpAmount = int.Parse(data[2]);
                    int firstAmount = heroes[name][1];

                    heroes[name][1] += mpAmount;
                    if (heroes[name][1] > 200)
                    {
                        heroes[name][1] = 200;
                    }

                    Console.WriteLine($"{name} recharged for {heroes[name][1] - firstAmount} MP!");
                }
                else if (data[0].ToLower() == "heal")
                {
                    string name = data[1];
                    int hpAmount = int.Parse(data[2]);
                    int firstAmount = heroes[name][0];

                    heroes[name][0] += hpAmount;
                    if (heroes[name][0] > 100)
                    {
                        heroes[name][0] = 100;
                    }
                    Console.WriteLine($"{name} healed for {heroes[name][0] - firstAmount} HP!");
                }



                command = Console.ReadLine();
            }

            heroes = heroes.OrderByDescending(n => n.Value[0]).ThenBy(n => n.Key).ToDictionary(n => n.Key, v => v.Value);

            foreach (var heroe in heroes)
            {
                Console.WriteLine(heroe.Key);
                Console.WriteLine($"  HP: {heroe.Value[0]}");
                Console.WriteLine($"  MP: {heroe.Value[1]}");

            }


        }


    }
}
