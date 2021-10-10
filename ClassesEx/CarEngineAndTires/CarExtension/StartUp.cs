using System;
using CarManufacturer;
 namespace CarManufacturer
{
   public class StartUp
    {
       public static void Main(string[] args)
        {

            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = 111;
            double fuelConsumption = 11;

            var firstCar = new Car();
            var secondCar = new Car(make, model, year);
            var thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
        }
    }
}
