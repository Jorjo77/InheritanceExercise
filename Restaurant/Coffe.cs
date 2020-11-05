using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffe : HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.50M;
        public Coffe(string name, decimal CoffeePrice, double CoffeeMilliliters, double caffeine)
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            Caffeine = caffeine;
        }
        public double Caffeine { get; set; }
    }
}
