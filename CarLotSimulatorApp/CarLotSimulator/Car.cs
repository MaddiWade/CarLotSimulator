using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
     public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; } = true;

        public Car()
        {

        }

        public Car(int year, string make, string model, string engineNoise, string honknoise, bool isDriveable = true)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honknoise;
            IsDriveable = isDriveable;
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        
        public void MakeHornNoise()
        {
            Console.WriteLine(HonkNoise);
        }
        
    }
    

}
