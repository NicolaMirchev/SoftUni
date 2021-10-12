using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoblyList
{
    class ListItem
    {
        public ListItem(int value)
        {
            Value = value;
        }

        public ListItem Previous { get; set; }
        public ListItem Next { get; set; }
        public int Value { get; set; }
    }
}
