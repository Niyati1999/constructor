using System;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Circle c1 = new Circle(4);
            Circle c2 = new Circle();
            c2.printData();
            c1.printData();
            Distance d1 = new Distance();
            d1.printValue();
            Distance d2 = new Distance(38);
            d2.printValue();
            Distance d3 = new Distance(26, 2);
            d3.printValue();
        }
    }
}
