using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    abstract class Car : ICar
    {
        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Model { get; protected set; }

        public string Color { get; protected set; }

        virtual public string Start()
        {
            return "Engine start";
        }

       virtual public string Stop()
        {
            return "Breaaak!";
        }
    }
}
