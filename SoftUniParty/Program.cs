using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var vip = new HashSet<string>();
            var regular = new HashSet<string>();

            string member = Console.ReadLine();
            while (member.ToLower() != "party")
            {
                if (char.IsDigit(member[0]) && member.Length == 8)
                {
                    vip.Add(member);
                }
                else if (member.Length == 8)
                {
                    regular.Add(member);
                } 
               member = Console.ReadLine();
            }

            member = Console.ReadLine();
            while (member.ToLower() != "end" )
            {
                if (vip.Contains(member))
                {
                    vip.Remove(member);
                }
                else if (regular.Contains(member))
                {
                    regular.Remove(member);
                }

                member = Console.ReadLine();
            }

            Console.WriteLine($"{vip.Count + regular.Count}");
            foreach (var person in vip)
            {
                Console.WriteLine(person);
            }
            foreach (var person in regular)
            {
                Console.WriteLine(person);
            }
        }
    }
}
