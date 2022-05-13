using Lucene.Net.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm
{
    class Graph <T>
    {
        public List<GraphElement<T>> Elements { get; set; }

        public Graph(params GraphElement<T>[] el)
        {
            Elements = new List<GraphElement<T>>();
            foreach (var item in el)
            {
                Elements.Add(item);
            }
        }


        public void DijkstraAlgorithm(GraphElement<T> startingElement)
        {
            Dictionary<GraphElement<T>, int> shortestScore = new Dictionary<GraphElement<T>, int>();
            HashSet<GraphElement<T>> visited = new HashSet<GraphElement<T>>();

            foreach (var item in Elements)
            {
                shortestScore.Add(item, int.MaxValue);
            }
            
            PriorityQueue


        }
    }
}
