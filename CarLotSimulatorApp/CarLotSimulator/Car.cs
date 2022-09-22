using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        //Default constructor
        public Car() 
        { 
        }

        //Alternative constructor using arguments
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string EngineNoise { get; set; } = "vroom vroom";
        public string HonkNoise { get; set; } = "Beep";
        public bool IsDriveable { get; set; } = false;


        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
        public void PrintCarInfo()
        {
            Console.WriteLine($"{Year} {Make} {Model}");
            Console.WriteLine($"Engine goes {EngineNoise} and the horn goes {HonkNoise}");
            var canDrive = IsDriveable ? "Car drives" : "Car does not drive";
            Console.WriteLine(canDrive);
        }
    }

    public class CarLot
    {
        public CarLot()
        {
            var cars = new List<Car>();
        }

        public List<Car> cars = new List<Car>();
        public int sizeLot = 0;

        public void AddCar(Car newCar)
        {
            cars.Add(newCar);
            sizeLot++;
        }
    }
}