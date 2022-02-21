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

            foreach(var car in lot.CarList)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model} Engine Noise: {car.EngineNoise} Honk Noise: {car.HonkNoise}, does is drive? {car.IsDriveable}");
            }

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

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
