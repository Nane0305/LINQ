using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Car
    {
        public string ? Name { get; set; }
        public UInt32 ? Year { get; set; }
        public decimal ? Price { get; set; }

        public Car()
        {
            this.Name = null;
            this.Year = null;
            this.Price = null;
        }
        public Car(string Name, UInt32 Year, decimal Price) : this()
        {
            this.Name = Name;
            this.Year = Year;
            this.Price = Price;
        }
        public override string ToString()
        {
            return $"Name:{Name} \nYear:{Year} \nPrice:{Price}";
        }
    }
}
