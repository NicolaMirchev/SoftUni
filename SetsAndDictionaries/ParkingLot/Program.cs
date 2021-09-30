using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var carNumber = new HashSet<string>();

            string command = Console.ReadLine();
            while (command!= "END")
            {
                string[] data =command.Split(", ");

                if (data[0] == "IN")
                {
                    carNumber.Add(data[1]);
                }
                else if (data[0] == "OUT")
                {

                    carNumber.Remove(data[1]);                    
                }

                command = Console.ReadLine();

            }
            if (carNumber.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in carNumber)
                {
                    Console.WriteLine(car);
                }   
            }

        }
    }
}
