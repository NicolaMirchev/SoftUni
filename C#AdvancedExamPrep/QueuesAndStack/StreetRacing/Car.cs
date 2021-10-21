using System;
using System.Collections.Generic;
using System.Text;

namespace StreetRacing
{
    class Car
    {
        public Car(string make, string model, string licencePlate, int Hp, double weight)
        {
            Make = make;
            Model = model;
            LicensePlate = licencePlate;
            HorsePower = Hp;
            Weight = weight;
        }

        public string Make { get; set; }
        public string Model { get; set; }

        public string LicensePlate { get; set; }
        public int HorsePower { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine($"Make: {Make}");
            strBuilder.AppendLine($"Model: {Model}");
            strBuilder.AppendLine($"License Plate: {LicensePlate}");
            strBuilder.AppendLine($"Horse Power: {HorsePower}");
            strBuilder.AppendLine($"Weight {Weight}");

            return strBuilder.ToString();
        }
    }
}
