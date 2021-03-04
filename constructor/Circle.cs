using System;
using System.Collections.Generic;
using System.Text;

namespace constructor
{
    class Circle
    {
        public double radius { get; set; }
        public double area()
        {
            return Math.PI * radius * radius;
        }
        public void printData()
        {
            Console.WriteLine("Radius" +radius);
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle()
        {
            radius = 0;
        }
    }
}
