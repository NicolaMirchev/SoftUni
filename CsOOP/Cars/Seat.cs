using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Seat : Car
    {
        public Seat(string model, string color) : base(model, color)
        { }
        public override string ToString()
        {
            return $"{this.Color} Seat {this.Model}";
        }

    }
}
