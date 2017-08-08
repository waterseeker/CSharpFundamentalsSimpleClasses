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

            //double marketValueOfCar = DetermineMarketValue(myNewCar);
            //Console.WriteLine("This car is worth " + marketValueOfCar.ToString("C") + ".");

            Console.WriteLine("This car is worth : {0:C}", myNewCar.DetermineMarketValue());

            Console.ReadLine();
        }

        private static double DetermineMarketValue(Car car)
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

        public double DetermineMarketValue()
        {
            double carValue = 100.0;
            if (this.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;

            return carValue;
        }

    }


}