using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Bags.Contracts
{
    public class Backpack : IBag
    {

        public Backpack()
        {
            Items = new List<string>();
        }
        public ICollection<string> Items { get; set; }

        public override string ToString()
        {
            if (Items.Count == 0)
            {
                return "none";
            }
            else
            {
                return string.Join(", ", Items);
            }
        }
    }
}
