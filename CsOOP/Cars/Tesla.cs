using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Tesla : Car, IElectricCar
    {
        public Tesla(string color,string model,int battery) : base(model, color)
        {
            Battery = battery;
        }
        public int Battery { get; private set; }
        public override string ToString()
        {
            return $"{this.Color} Tesla {Model} with {Battery} Batteries"; 
        }
    }
}
