using System;
using System.Collections.Generic;
using System.Linq;

namespace SongQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            Queue<string> playList = new Queue<string>(songs);
            string command = Console.ReadLine();

            while (playList.Count > 0)
            {
                string[] data = command.Split(' ');
                if (data[0] == "Add")
                {
                    string songName = "";
                    for (int i = 1; i < data.Length; i++)
                    {
                        songName += data[i] + " ";
                    }
                    string trim = songName.Trim();
                    if (!playList.Contains(trim))
                    {
                        playList.Enqueue(trim);
                    }
                    else
                    {
                        Console.WriteLine($"{trim} is already contained!");
                    }

                }
                else if (data[0] == "Play")
                {
                    playList.Dequeue();
                }
                else if (data[0] == "Show")
                {
                    string[] showSongs = playList.ToArray();
                    Console.WriteLine(string.Join(", ", showSongs));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
