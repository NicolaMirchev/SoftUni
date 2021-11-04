using System;
using System.Collections.Generic;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<IMember> memberIDs = new List<IMember>();

            while (input != "End")
            {
                string[] data = input.Split(' ');
                if (data.Length == 2)
                {
                    Robot newRobot = new Robot( data[0], data[1] );
                    memberIDs.Add(newRobot);
                }
                else
                {
                    Human newHuman = new Human(data[0], data[2], int.Parse(data[1]));
                    memberIDs.Add(newHuman);
                }

                input = Console.ReadLine();
            }
            string fakeIdEnd = Console.ReadLine();
            foreach (var member in memberIDs)
            {
                if (member.ID[member.ID.Length - 3] == fakeIdEnd[0])
                {
                    if (member.ID[member.ID.Length - 2] == fakeIdEnd[1])
                    {
                        if (member.ID[member.ID.Length - 1] == fakeIdEnd[2])
                        {
                            Console.WriteLine(member.ID);
                        }
                    }
                }
            }

        }
    }
}
