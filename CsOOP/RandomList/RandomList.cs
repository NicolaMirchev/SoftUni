using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    class RandomList : List<string>
    {

        public string RandomString()
        {
            var r = new Random();

            int index = r.Next(0, Count);

            return this[index];
        }
    }
}
