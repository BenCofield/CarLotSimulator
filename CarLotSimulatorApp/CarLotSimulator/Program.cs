using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var CarLot = new CarLot();

            var car1 = new Car();
            car1.Year = 2018;
            car1.Make = "Mazda";
            car1.Model = "Something";

            CarLot.AddCar(car1);
            

            Console.WriteLine("Enter the year, make, and model: ");
            int newCarYear = int.Parse(Console.ReadLine());
            string newCarMake = Console.ReadLine();
            string newCarModel = Console.ReadLine();
            Console.WriteLine("Enter the engine noise and honk noise: ");
            string newCarEngineNoise = Console.ReadLine();
            string newCarHonkNoise = Console.ReadLine();
            Console.WriteLine("Is it driveable? y/n");
            char yesNo = char.Parse(Console.ReadLine());
            bool newCarDriveable = false;
            switch (yesNo)
            {
                case 'y':
                    newCarDriveable = true;
                    break;
                case 'n':
                    newCarDriveable = false;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            var car2 = new Car(newCarYear, newCarMake, newCarModel, newCarEngineNoise, newCarHonkNoise, newCarDriveable);
            CarLot.AddCar(car2);

            var car3 = new Car
            {
                Year = 1996,
                Make = "Toyota",
                Model = "Camry",
            };
            CarLot.AddCar(car3);

            for (int i = 0; i < CarLot.sizeLot; i++)
            {
                CarLot.cars[i].PrintCarInfo();
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
