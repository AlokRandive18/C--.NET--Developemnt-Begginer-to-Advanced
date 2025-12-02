using System;

namespace  AreaOfCircle{
class Area
{
    static void Main(string[] args)
    {
        double radius = 3.14;
        double pi = 3.14;

        double area = pi * radius * radius;

        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area of Circle : " + area);

        Console.ReadLine(); // Keeps the console open
    }
}
}