
using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[]
            {
                new Car("Audi", 2005, 5000),
                new Car("BMW", 1999, 3000),
                new Car("Toyota", 2020, 304004),
                new Car("Mercedes", 2020, 4454545),
                new Car("Nisan", 2012, 12000),
                new Car("ZAZ", 2006, 8056)
            };
            var qwery = from car in cars
                        group car by car.Year > 2010;
            foreach (var item in qwery)
            {
                Console.Write($"Key: {item.Key}\nValue:");
                foreach (Car item2 in item)
                {
                    Console.Write($"\t{item2}");
                }
                Console.WriteLine();
            }
        }
    }
}