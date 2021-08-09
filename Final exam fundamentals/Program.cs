using System;
using System.Collections.Generic;
using System.Linq;

namespace Final_exam_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command = Console.ReadLine();
            while (command.ToLower() != "generate")
            {
                string[] commandArr = command.Split(">>>");

                switch (commandArr[0].ToLower())
                {
                    case "contains":
                  
                        if (activationKey.Contains(commandArr[1]))
                        {
                            Console.WriteLine($"{activationKey} contains {commandArr[1]}");
                        }
                        else
                        {
                            Console.WriteLine($"Substring not found!");
                        }
                        break;
                    case "flip":
                        string activity = commandArr[1];
                        int startingIndex = int.Parse(commandArr[2]);
                        int finishingIndex = int.Parse(commandArr[3]);
                        if (activity.ToLower() == "upper")
                        {
                            List<char> lis = activationKey.ToList();
                            for (int i = startingIndex; i < finishingIndex; i++)
                            {
                                lis[i] = char.ToUpper(lis[i]);
                            }
                            activationKey =string.Join("",lis.ToArray());
                            Console.WriteLine(activationKey);

                        }
                        else
                        {
                            List<char> listt = activationKey.ToList();
                            for (int i = startingIndex; i < finishingIndex; i++)
                            {
                                listt[i] = char.ToLower(listt[i]);
                            }
                            activationKey = string.Join("", listt.ToArray());
                            Console.WriteLine(activationKey);
                        }

                        break;
                    case "slice":
                        int start = int.Parse(commandArr[1]);
                        int end = int.Parse(commandArr[2]);
                        List<char> list = activationKey.ToList();

                        list.RemoveRange(start, end - start);
                        activationKey = string.Join("", list.ToArray());
                        Console.WriteLine(activationKey);
                        break;
                    
                    default:
                        break;
                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
