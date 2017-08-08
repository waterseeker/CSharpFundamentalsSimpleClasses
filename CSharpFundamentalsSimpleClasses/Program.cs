using System;

namespace CSharpFundamentalsSimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlass Supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            Console.WriteLine("{0} - {1} - {2}",
                myNewCar.Make,
                myNewCar.Model,
                myNewCar.Color);

            Console.ReadLine();
        }

        private static double determineMarketValue(Car car)
        {
            double carValue = 100.0;

            //hardcoding value here but you could include code that would
            //go online, lookup the car and return the current value. 

            return carValue;
        }

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

    }


}