using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot = new CarLot();
            

            Car car1 = new Car();
            car1.Year = 2017;
            car1.Make = "Honda";
            car1.Model = "Accord";
            car1.EngineNoise = "Vroom Vroom";
            car1.HonkNoise = "beep beep";
            car1.IsDriveable = true;
           
            car1.MakeEngineNoise();
            car1.MakeHornNoise();
            lot.CarList.Add(car1);

            Car Becky = new Car() { Year = 1990, Make = "Ford", Model = "Explorer", EngineNoise = "Rattel", HonkNoise = "HONK", IsDriveable = false };

            Becky.MakeEngineNoise();
            Becky.MakeHornNoise();
            lot.CarList.Add(Becky);

            Car HotRod = new Car(1908, "Ford", "T", "Loud af", "Old fashion honk", false);

            HotRod.MakeEngineNoise();
            HotRod.MakeHornNoise();
            lot.CarList.Add(HotRod);

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach(var car in lot.CarList)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model} Engine Noise: {car.EngineNoise} Honk Noise: {car.HonkNoise}, does is drive? {car.IsDriveable}");
            }

            
        }
    }
}
