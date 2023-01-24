namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of tires for the vehicle you want to create");

            var userInput = Console.ReadLine();

            var newBuild = VehicleFactory.GetVehicle(userInput);
            newBuild.Drive();

            Console.ReadLine();


             
        }
    }
}

