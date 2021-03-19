using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
        }

        public List<Car> Lot { get; set; } = new List<Car>();

       

        public void Printer() 
        {
            foreach (var car in Lot)
            {
                Console.WriteLine(car.Year + " " + car.Make + " " + car.Model);
            }
        }
    }
}
