using System;


namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        public Car()
        {

        }

        public Car(int year,
                   string make,
                   string model,
                   string engineNoise,
                   string honkNoise,
                   bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

        }

        public void MakeEngineNoise()
        {

            Console.WriteLine($"your engine goes {EngineNoise}"); 
        }

        public void MakeHonkNoise()
        {

            Console.WriteLine($"your horn goes {HonkNoise}"); 
        }

        public void YourCar()
        {
            if (IsDriveable)
            {
                Console.WriteLine($"You own a {Year}, {Make}, {Model}, and your car is driveable!");
            }
            else
            {
                Console.WriteLine($"You own a {Year}, {Make}, {Model}, and your ca is not driveable!");
            }
        }
    }
}
