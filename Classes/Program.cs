namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
          Car newCar = new Car();
            newCar.Year = 2005;
            newCar.Make = "Honda";
            newCar.Model = "Civic";
            Console.WriteLine($"Your car is a {newCar.Year} {newCar.Make} {newCar.Model}!");

        }
    }
}
