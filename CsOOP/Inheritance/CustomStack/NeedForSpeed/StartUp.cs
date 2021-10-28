namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var sportCar = new SportCar(200, 200);
            var familyCar = new FamilyCar(200, 200);

            sportCar.Drive(100);
            familyCar.Drive(100);

            System.Console.WriteLine(sportCar.Fuel);
            System.Console.WriteLine(familyCar.Fuel);
        }
    }
}
