using System;
using System.Collections.Generic;


namespace CarLotSimulator
{
    public class Program
    {

        static void Main(string[] args) { 


            
                //TODO

                //Create a seperate class file called Car
                //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
                //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
                //The methods should take one string parameter: the respective noise property


                //Now that the Car class is created we can instanciate 3 new cars
                Car c1 = new Car();
                c1.Year = 2012;
                c1.Make = "Kia";
                c1.Model = "Serento";
                c1.EngineNoise = "Vroom, Vroom";
                c1.HonkNoise = "Beep, Beep";
                c1.IsDriveable = true;

                c1.YourCar();
                c1.MakeEngineNoise();
                c1.MakeHonkNoise();
            Console.WriteLine("");


            var c2 = new Car()
            {
                Year = 1996,
                Make = "Ford",
                Model = "F-150",
                EngineNoise = "Rumble Rumble",
                HonkNoise = "Honk Honk",
                IsDriveable = true,
            };

        c2.YourCar();
            c2.MakeEngineNoise();
            c2.MakeHonkNoise();
            Console.WriteLine("");


            var c3 = new Car(2020, "Chevy", "Corvet", "Zoom Zoom", "Beep Beep", true);

        c3.YourCar();
            c3.MakeEngineNoise();
            c3.MakeHonkNoise();
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            var myLot = new CarLot();
            
            myLot.Lot.Add(c1);
            myLot.Lot.Add(c2);
            myLot.Lot.Add(c3);

            
            myLot.Printer();

        }
    }
}