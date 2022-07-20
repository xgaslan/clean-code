using System;

namespace OpenClosed.WithoutOpenClosed
{
    public class Car
    {
        public void Run()
        {
            Console.WriteLine("Vehicle started working");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle stopped.");
        }

        public void CalculateTripCost(Wolksvagen wolksvagen)
        {
            var calculate = FuelCostCalculator.Calculate(wolksvagen);
            Console.WriteLine($"Cost {calculate}.");
        }
    }

    public static class FuelCostCalculator
    {
        public static double Calculate(Wolksvagen wolksvagen)
        {
            var mileageMultiplier = 1.12;
            var fuelUsedPerKM = wolksvagen.FuelUsagePerKM;
            var fuelCost = mileageMultiplier * fuelUsedPerKM;
            return fuelCost;
        }

    }
}