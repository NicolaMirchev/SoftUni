namespace SetCover
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] universe = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rowsOfJagged = int.Parse(Console.ReadLine());
            var jaggedArray = new List<int[]>();

            for (int row = 0; row < rowsOfJagged; row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < line.Length; col++)
                {
                    jaggedArray.Add(line);
                }
            }
                var set = ChooseSets(jaggedArray, universe);
                Console.WriteLine($"Sets to take ({set.Count}):");

                foreach (var item in set)
                {
                foreach (var number in set)
                {
                    Console.WriteLine($" {{{string.Join(", ", number)}}} ");
                }
                }
            
            
          
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            sets = sets.OrderByDescending(el => el.Length).ToList();
            var setsAnswer = new List<int[]>();

            var list = new List<int>(universe);

            for (int i = 0; i < sets.Count; i++)
            {
                var currentSet = new List<int>();
                for (int j = 0; j < sets[i].Length; j++)
                {
                    if (list.Contains(sets[i][j]))
                    {
                        currentSet.Add(sets[i][j]);

                        list.Remove(sets[i][j]);
                    }
                    else if (list.Count == 0)
                    {
                        break;
                    }
                }
                setsAnswer.Add(currentSet.ToArray());
            }

            return setsAnswer;
        }
    }
}
